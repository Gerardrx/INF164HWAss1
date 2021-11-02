using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class Arcade : Form
    {
        //public variables
        public int coin;

        //private variables
        private bool up = false;
        private bool down = false;
        private bool shoot = false;
        private bool shooting = false;
        private bool enter = false;
        private int buffTime;
        private int timePoof = 0;
        private int timePoof2 = 0;
        private int timeWiz = 0;
        private int hearts = 3;
        private Panel boxCol = new Panel();
        private Panel boxCol2 = new Panel();
        private Random rand = new Random();

        public Arcade()
        {
            InitializeComponent();

            Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;

            this.KeyPreview = true;

            //set opacity for fades
            Opacity = 0;
            OpenFadeTimer.Start();

            //hide panel
            boxCol.Visible = false;

            //progress bar changes
            pgbBufferTime.ForeColor = Color.Red;
            pgbBufferTime.Value = 100;

            //make transparency work
            pbBackground.Controls.Add(this.pbCoin);
            pbBackground.Controls.Add(this.lblCoins);

            pbBackground.Controls.Add(this.pbKeys1);
            pbBackground.Controls.Add(this.pbKeys2);

            pbBackground.Controls.Add(this.lblControls1);
            pbBackground.Controls.Add(this.lblControls2);

            pbBackground.Controls.Add(this.wizzard1);
            pbBackground.Controls.Add(this.pbHearts);
            pbBackground.Controls.Add(this.lblWizz);
            pbBackground.Controls.Add(this.lblEcape);

            pbBackground.Controls.Add(this.pbPressStart);
            pbBackground.Controls.Add(this.lblStartPress);
            lblStartPress.BringToFront();
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //Set coin value of lbl
            lblCoins.Text = "" + coin;

            //Call methods
            checkWizzPigeonCollisions();
            removePoof();
            removePoof2();
            MoveFireball();
            checkCollisionsFirePigeon();
            MovePigeons();
            WizMovement();
            WizzWall();
            health();
            checkPigeonColWall();

            //stop wizzard movment 
            if (wizzard1.YForce != 0)
            {
                wizzard1.moveVertical();
            }

            //Wait to shoot fireball
            if (shoot && shooting && buffTime == 0)
            {
                shoot = false;
                SpawnFireball();
            }
        }

        private void Start()
        {
            //start game timer
            GameTimer.Start();
            SpawnTimer.Start();

            //Display Controls
            pbKeys1.Visible = true;
            pbKeys2.Visible = true;
            lblControls1.Visible = true;
            lblWizz.Visible = true;
            lblControls2.Visible = true;
            pbPressStart.Visible = false;
            lblStartPress.Visible = false;
        }

        //Wizzard methods ***********************************************
        private void WizMovement()
        {
            if (up)
            {
                wizzard1.YForce = -2; //move wizzard up
            }
            else if (down)
            {
                wizzard1.YForce = 2; //move wizzard down
            }
        }

        private void WizzardTimer_Tick(object sender, EventArgs e)
        {
            timeWiz++;

            if (timeWiz == 40) //call reset wizzard after poof
            {
                timeWiz = 0;
                WizzardTimer.Stop();
                restWiz();
            }
        }

        private void restWiz() //reset wizzard after poof
        {
            if (hearts != 0)
            {
                wizzard1.SizeMode = PictureBoxSizeMode.CenterImage;
                wizzard1.Size = new Size(61, 62);
                wizzard1.Image = global::INF164HWAss1.Properties.Resources.Toaddude;
                wizzard1.stopDown = false;
                wizzard1.stopUp = false;
            }
            else
            {
                wizzard1.Hide(); //hide if hearts = 0
            }
        }

        //Pigeon methods ************************************************
        private void SpawnPigeon() //create pigeons
        {
            Pigeon p = new Pigeon();
            p.Location = new Point(0, rand.Next(45, 313));
            p.speed = rand.Next(1, 4);

            while (checkSpawn(p)) //check for other pigeons spawn collision
            {
                p.Location = new Point(0, rand.Next(37, 322));
            }
            pbBackground.Controls.Add(p);
        }

        private void MovePigeons() //move towards wizzard
        {
            foreach (Control p in pbBackground.Controls)
            {
                if (p is Pigeon)
                {
                    ((Pigeon)p).movePigeon(); //call class method
                }
            }
        }

        private void SpawnTimer_Tick(object sender, EventArgs e)
        {
            SpawnPigeon(); //timer interval sets amount spawned
        }

        //FireBall methods ***********************************************
        private void SpawnFireball() //create fireball
        {
            FireballTimer.Start();

            Fireball f = new Fireball();
            f.Location = new Point(wizzard1.Location.X - 40, wizzard1.Location.Y);
            f.speed = 3;
            pbBackground.Controls.Add(f);
        }

        private void MoveFireball() //move towards pigeon
        {
            foreach (Control f in pbBackground.Controls)
            {
                if (f is Fireball)
                {
                    ((Fireball)f).moveFireball();
                }
            }
        }

        private void FireballTimer_Tick(object sender, EventArgs e) //set the delay between each fireball
        {
            buffTime++;
            pgbBufferTime.Value = buffTime;

            if (buffTime == 100) //no spam fireballs
            {
                shooting = false;
                pgbBufferTime.Value = buffTime;
                buffTime = 0;
                FireballTimer.Stop();
            }
        }

        //Collision methods ***********************************************
        private void checkPigeonColWall() //check for col of pigeon and defence point
        {
            foreach (Control p in pbBackground.Controls)
            {
                if (p is Pigeon)
                {
                    foreach (Control w in this.Controls)
                    {
                        if (w is Wall)
                        {
                            boxCol2.Size = p.Size;
                            boxCol2.Location = new Point(p.Location.X + 4, p.Location.Y);
                            if (boxCol2.Bounds.IntersectsWith(wall3.Bounds))
                            {
                                ((Pigeon)p).dead = true;
                                ((Pigeon)p).Stop = true;
                                PoofTimer2.Start();
                            }
                        }
                    }
                }
            }
        }

        private void checkCollisionsFirePigeon() //check for col of pigeon and fireball
        {
            foreach (Control f in pbBackground.Controls)
            {
                if (f is Fireball)
                {
                    foreach (Control p in pbBackground.Controls)
                    {
                        if (p is Pigeon)
                        {
                            if (f.Bounds.IntersectsWith(p.Bounds))
                            {
                                ((Pigeon)p).Image = global::INF164HWAss1.Properties.Resources.Poof_Effect;
                                ((Pigeon)p).dead = true;
                                f.Dispose();
                                PoofTimer.Start(); // create a poof effect
                                coin++;
                            }
                        }
                    }
                }
            }
        }

        private void checkWizzPigeonCollisions() //check for col of pigeon and wizzard
        {
            foreach (Control p in pbBackground.Controls)
            {
                if (p is Pigeon)
                {
                    if (p.Bounds.IntersectsWith(wizzard1.Bounds))
                    {
                        if(((Pigeon)p).dead)
                        {
                            p.Dispose();
                        }
                        else
                        {
                            wizzard1.SizeMode = PictureBoxSizeMode.Zoom;
                            wizzard1.Size = new Size(77, 71);
                            wizzard1.Image = global::INF164HWAss1.Properties.Resources.Poof_Effect;
                            ((Pigeon)p).dead = true;
                            p.Dispose();
                            WizzardTimer.Start();
                            hearts--;

                            if (coin != 0) //no negative coins
                            {
                                coin--;
                            }
                        }
                    }
                }
            }
        }

        private void WizzWall() //set movemnt area of wizzard
        {
            foreach (Control w in this.Controls)
            {
                if (w is Wall)
                {
                    boxCol.Size = wizzard1.Size;
                    boxCol.Location = new Point(wizzard1.Location.X, wizzard1.Location.Y - 2);
                    if (w.Bounds.IntersectsWith(boxCol.Bounds))
                    {
                        wizzard1.stopUp = true;
                    }
                    boxCol.Size = wizzard1.Size;
                    boxCol.Location = new Point(wizzard1.Location.X, wizzard1.Location.Y + 2);
                    if (w.Bounds.IntersectsWith(boxCol.Bounds))
                    {
                        wizzard1.stopDown = true;
                    }
                }
            }
        }

        private bool checkSpawn(Pigeon n) //no pigeon on pigeon collision
        {
            foreach (Control p in pbBackground.Controls)
            {
                if (p is Pigeon)
                {
                    if (p.Bounds.IntersectsWith(n.Bounds))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //Poof methods ***************************************************************
        private void PoofTimer_Tick(object sender, EventArgs e) //time until disappear
        {
            timePoof++;
        }

        private void PoofTimer2_Tick(object sender, EventArgs e)
        {
            timePoof2++;
        }

        private void removePoof() //pigeon and fireball
        {
            if (timePoof == 1)
            {
                foreach (Control p in pbBackground.Controls)
                {
                    if (p is Pigeon && ((Pigeon)p).dead)
                    {
                        p.Dispose();
                        PoofTimer.Stop();
                        timePoof = 0;
                    }
                }
            }
        }

        private void removePoof2() //pigeon and wall
        {
            if (timePoof2 == 27)
            {
                foreach (Control p in pbBackground.Controls)
                {
                    if (p is Pigeon && ((Pigeon)p).dead)
                    {
                        p.Dispose();
                        PoofTimer2.Stop();
                        timePoof2 = 0;

                        hearts--;

                        if(coin != 0)
                        {
                            coin--;
                        }
                    }
                }
            }
        }

        //Key register methods ***************************************************************
        private void Arcade_KeyDown(object sender, KeyEventArgs e) //check for key down
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if(lblControls1.Visible == true)
                {
                    lblWizz.Visible = false;
                    lblControls1.Visible = false;
                }
                pbKeys1.Visible = false;
                up = true;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                down = true;
            }
        }

        private void Arcade_KeyUp(object sender, KeyEventArgs e) //check for key up
        {
            if(e.KeyCode == Keys.Space)
            {
                if (pbPressStart.Visible == true)
                {
                    Start();
                }
                else if (!shooting)
                {
                    shoot = true;
                    shooting = true;

                    if (lblControls2.Visible == true)
                    {
                        lblControls2.Visible = false;
                        pbKeys2.Visible = false;
                    }
                }
            }
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                up = false;
                wizzard1.YForce = 0;
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                down = false;
                wizzard1.YForce = 0;
            }
            if (e.KeyCode == Keys.Enter)
            {
                enter = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                CloseFadeTimer.Start();
            }
        }

        //Controls *********************************************************

        private void health() //set health loss
        {
            if (hearts == 2)
            {
                pbHearts.Image = global::INF164HWAss1.Properties.Resources.heart_2;
            }
            else if (hearts == 1)
            {
                pbHearts.Image = global::INF164HWAss1.Properties.Resources.Heart_1;
            }
            else if (hearts == 0)
            {
                pbHearts.Image = global::INF164HWAss1.Properties.Resources.Heart_0;
                //gameOver();
            }
        }

        private void restart() //restart game
        {
            // reset all to original positions
            wizzard1.Location = new Point(1023, 322);
        }

        private void gameOver() //end of game
        {
            GameTimer.Stop();
            FireballTimer.Stop();
        }

        //*******************************************************************
        private void OpenFadeTimer_Tick(object sender, EventArgs e) //fade in
        {
            if (Opacity == 1)
            {
                OpenFadeTimer.Stop();
            }
            Opacity += 0.03;
        }

        private void CloseFadeTimer_Tick(object sender, EventArgs e) //fade out
        {
            if (Opacity == 0)
            {
                CloseFadeTimer.Stop();
                this.Dispose();
            }
            Opacity -= 0.03;
        }
    }
}
