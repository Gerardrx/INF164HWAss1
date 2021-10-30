using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INF164HWAss1
{

    //COPYRIGHT Gerard Geldenhuys, Do not Distribute

    public partial class Runner : Form
    {
        public int coins = 0;

        private int x;
        private int y;
        
        private bool floor = false;
        private bool jump = false;
        private bool jumping = false;

        private bool space = false;
        private bool left = false;
        private bool right = false;

        private Random rand = new Random();
        private Panel BoxCollider = new Panel();
        private Panel SpikeCollider = new Panel();
        private Coin c;

        public Runner()
        {
            InitializeComponent();

            gameTimer.Start();
            x = player1.Location.X;
            y = player1.Location.Y;
            Cursor.Hide();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            movement();
            moveAllSpikes();
            CheckDeath();
            fallCheck();

            if (jump)
            {
                jumping = true;
                jumpPlayer();
            }

            checkCollision();
            if (player1.XForce != 0)
            {
                player1.moveHorizontal();

                if(player1.XForce > 0)
                {
                    player1.XForce--;
                }
                else
                {
                    player1.XForce++;
                }  
            }

        }

        private void Runner_KeyDown(object sender, KeyEventArgs e)
        {
            x = player1.Location.X;
            y = player1.Location.Y;

            if (e.KeyValue == (char)Keys.Space || e.KeyValue == (char)Keys.Up)
            {
                space = true;
            }
            if (e.KeyValue == (char)Keys.Left || e.KeyValue == (char)Keys.A)
            {
                left = true;
            }
            if (e.KeyValue == (char)Keys.Right || e.KeyValue == (char)Keys.D)
            {
                right = true;
            }
            lblControls.Visible = false;
        }

        private void movement()
        {
            if (space && floor && !jumping)
            {
                jump = true;
                player1.YForce = -18;
            }
            if (left)
            {
                player1.XForce = -5;
            }
            if (right)
            {
                player1.XForce = +5;
            }
            checkCollision();
        }

        private void Runner_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Space || e.KeyValue == (char)Keys.Up)
            {
                space = false;
            }
            if (e.KeyValue == (char)Keys.Left || e.KeyValue == (char)Keys.A)
            {
                left = false;
            }
            if (e.KeyValue == (char)Keys.Right || e.KeyValue == (char)Keys.D)
            {
                right = false;
            }
            if (e.KeyValue == (char)Keys.Escape)
            {
                this.Dispose();
            }
            if (e.KeyValue == (char)Keys.R)
            {
                Restart();
            }
        }

        private void fallCheck()
        {
            if (!jump)
            {
                BoxCollider.Size = new Size (player1.Size.Width, player1.Size.Height);
                BoxCollider.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                BoxCollider.Visible = false;

                floor = false;
                foreach (Control w in this.Controls)
                {
                    if (w is Wall)
                    {
                        if (BoxCollider.Bounds.IntersectsWith(w.Bounds))
                        {
                            floor = true;
                        }
                    }
                }
            }
            if (!floor)
            {
                player1.YForce = 5;
                player1.fall();
                checkCollision();
            }

            player1.Floor = floor;
        }

        private void jumpPlayer()
        {
            if(player1.YForce < 0 && floor)
            {
                player1.jump();
                player1.stopLeft = false;
                player1.stopRight = false;      
            }
            else
            {
                jump = false;
                floor = false;
                jumping = false;
            }
        }

        private void checkCollision()
        {
            x = player1.Location.X;
            y = player1.Location.Y;

            player1.stopLeft = false;
            player1.stopRight = false;

            BoxCollider.Size = player1.Size;
            BoxCollider.Visible = false;
            foreach (Control w in this.Controls)
            {
                if (w is Wall)
                {
                    BoxCollider.Size = player1.Size;
                    BoxCollider.Location = new Point(player1.Location.X - 5, player1.Location.Y - 4); // hitting left
                    if (BoxCollider.Bounds.IntersectsWith(w.Bounds))
                    {
                        player1.stopLeft = true;
                    }

                    BoxCollider.Location = new Point(player1.Location.X + 5, player1.Location.Y - 4); //hitting right
                    if (BoxCollider.Bounds.IntersectsWith(w.Bounds))
                    {
                       player1.stopRight = true;
                    }

                    BoxCollider.Size = new Size(player1.Size.Width -30, player1.Size.Height -30);
                    BoxCollider.Location = new Point(player1.Location.X + 15, player1.Location.Y -4 ); //hitting head
                    if (jump && BoxCollider.Bounds.IntersectsWith(w.Bounds))
                    {
                        player1.Location = new Point(x, y + 3);
                        jump = false;
                        jumping = false;
                        floor = false;
                    }
                }

                if (w is Coin)
                {
                    if (player1.Bounds.IntersectsWith(w.Bounds))
                    {
                        coins++;
                        lblCoins.Text = "" + coins;
                        GenerateCoin((Coin)w);
                        Controls.Remove(w);
                        lblInstructions.Visible = false;
                    }
                }
            }
        }

        private void moveAllSpikes()
        {
            foreach (Control g in this.Controls)
            {
                if (g is Spike)
                {
                    ((Spike)g).moveSpike();
                }
            }
        }

        private void CheckDeath()
        {
            SpikeCollider.Visible = false;
            foreach (Control g in this.Controls)
            {
                if (g is Spike)
                {
                    SpikeCollider.Size = new Size(g.Size.Width - 50,g.Size.Height - 50);
                    SpikeCollider.Location = new Point(g.Location.X + 25, g.Location.Y +25);
                    

                    if (SpikeCollider.Bounds.IntersectsWith(player1.Bounds))
                    {
                         GameOver();
                    }
                }
                else if(g is PictureBox && (string) g.Tag == "floorSpike")
                {
                    SpikeCollider.Size = new Size(g.Size.Width - 20, g.Size.Height - 4);
                    SpikeCollider.Location = new Point(g.Location.X + 10, g.Location.Y + 4);

                    if (SpikeCollider.Bounds.IntersectsWith(player1.Bounds))
                    {
                         GameOver();
                    }
                }
            }
        }

        private void GameOver()
        {
            gameTimer.Stop();
            pbGameOver.Visible = true;
            lblRestart.Visible = true;
        }


        private void Restart()
        {
            coins = 0;
            player1.Location = new Point(70, 900);
            lblControls.Visible = true;
            lblInstructions.Visible = true;
            gameTimer.Start();
            left = false;
            right = false;
            space = false;
            jump = false;
            jumping = false;
            this.Controls.Add(coin1);
            this.Controls.Remove(c);
            lblCoins.Text = "0";
            pbGameOver.Visible = false;
            lblRestart.Visible = false;
        }


        private void GenerateCoin(Coin old)
        {
            c = new Coin();
            Controls.Add(c);
            c.Size = old.Size;
            c.SendToBack();

            c.Location = new Point(rand.Next(20, this.Size.Width - 20), rand.Next(20, this.Size.Height - 20));
            while (checkCoinCollision(c))
            {
                c.Location = new Point(rand.Next(20, this.Size.Width - 20), rand.Next(20, this.Size.Height - 20));
            }
        }

        private bool checkCoinCollision(Coin c)
        {
            foreach (Control w in this.Controls)
            {
                if (w is Wall || w is NoCoinSpawn ||(w is PictureBox && (string) w.Tag == "floorSpike"))
                {
                    if (w.Bounds.IntersectsWith(c.Bounds))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}



        