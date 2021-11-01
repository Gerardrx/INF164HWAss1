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
        private int buffTime;
        private int x;
        private int y;
        private Panel boxCol = new Panel();
        private Random rand = new Random();


        public Arcade()

        {
            InitializeComponent();

            this.KeyPreview = true;

            Opacity = 0;
            OpenFadeTimer.Start();

            boxCol.Visible = false;

            pgbBufferTime.ForeColor = Color.Red;
            pgbBufferTime.Value = 100;

            pbBackground.Controls.Add(this.pbCoin);
            pbBackground.Controls.Add(this.pbKeys1);
            pbBackground.Controls.Add(this.wizzard1);
            pbBackground.Controls.Add(this.pbHearts);
            pbBackground.Controls.Add(this.lblCoins);
            pbBackground.Controls.Add(this.lblControls1);
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            MoveFireball();
            MovePigeons();
            Movement();
            WizzWall();

            if (wizzard1.YForce != 0)
            {
                wizzard1.moveVertical();
            }

            if(shoot && shooting && buffTime == 0)
            {
                shoot = false;
                SpawnFireball();
            }

        }

        private void Movement()
        {
            if (up)
            {
                wizzard1.YForce = -2; //move wizzard up
            }
            else if(down)
            {
                wizzard1.YForce = 2;//move wizzard down
            }
        }

        private void SpawnFireball()
        {
            FireballTimer.Start();

            Fireball f = new Fireball();
            f.Location = new Point(wizzard1.Location.X - 40, wizzard1.Location.Y);
            f.speed = 3;
            pbBackground.Controls.Add(f);
        }

        private void MoveFireball()
        {
            foreach(Control f in pbBackground.Controls)
            {
                if (f is Fireball)
                {
                    ((Fireball)f).moveFireball();
                }
            }
        }

        private void FireballTimer_Tick(object sender, EventArgs e)
        {
            buffTime++;
            pgbBufferTime.Value = buffTime;

            if (buffTime == 100)
            {
                shooting = false;
                pgbBufferTime.Value = pgbBufferTime.Maximum;
                buffTime = 0;
                FireballTimer.Stop();
            }
        }

        private bool checkCollisions(Fireball n, Pigeon i)
        {
            foreach(Control f in pbBackground.Controls)
            {
                if (f is Fireball)
                {
                    if (f.Bounds.IntersectsWith(i.Bounds))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void SpawnPigeon()
        {
            Pigeon p = new Pigeon();
            p.Location = new Point(0, rand.Next(45, 313));
            p.speed = rand.Next(1, 4);

            while (checkSpawn(p))
            {
                p.Location = new Point(0, rand.Next(37, 322));
            }
            pbBackground.Controls.Add(p);
        }

        private bool checkSpawn(Pigeon n)
        {
            foreach(Control p in pbBackground.Controls)
            {
                if(p is Pigeon)
                {
                    if(p.Bounds.IntersectsWith(n.Bounds))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void MovePigeons()
        {
            foreach(Control p in pbBackground.Controls)
            {
                if(p is Pigeon)
                {
                    ((Pigeon)p).movePigeon();
                }
            }
        }

        private void WizzWall()
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

        private void Arcade_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                if (lblControls2.Visible == true)
                {
                    lblControls2.Visible = false;
                    pbKeys2.Visible = false;
                }
                
                if (!shooting)
                {
                    shoot = true;
                    shooting = true;
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
        }

        private void btnBack_Click(object sender, EventArgs e) //return to home form
        {
            CloseFadeTimer.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //start game timer
            GameTimer.Start();
            SpawnTimer.Start();
            gbStart.Visible = false;

        }

        private void gameOver()
        {
            GameTimer.Stop();
            FireballTimer.Stop();

            MessageBox.Show("Game Over");
        }

        private void SpawnTimer_Tick(object sender, EventArgs e)
        {
            SpawnPigeon();
        }















        private void OpenFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                OpenFadeTimer.Stop();
            }
            Opacity += 0.03;
        }

        private void CloseFadeTimer_Tick(object sender, EventArgs e)
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
