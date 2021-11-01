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
        private int x;
        private int y;


        public Arcade()

        {
            InitializeComponent();

            //start game timer

            Opacity = 0;
            OpenFadeTimer.Start();

            pbClickMe.Visible = false;

            //blControls.Text = "hhi\n";

            pbBackground.Controls.Add(this.pbClickMe);
            pbBackground.Controls.Add(this.pbHearts);
            pbBackground.Controls.Add(this.lblCoins);
        }

        private void Movement()
        {
            if (up)
            {
                wizzard1.YForce = -5;
            }
            else if(down)
            {
                wizzard1.YForce = 5;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameTimer.Start();
            gbStart.Visible = false;
            
        }
      
        private void gameOver() 
        {
            GameTimer.Stop();
            pbClickMe.Visible = false;

            MessageBox.Show("Game Over");
        }

        private void btnBack_Click(object sender, EventArgs e) //return to home form
        {
            CloseFadeTimer.Start();
        }

        private void CheckCollision() //check collision with form bounds
        {
            x = wizzard1.Location.X;
            y = wizzard1.Location.Y;


        }

        private void Arcade_KeyDown(object sender, KeyEventArgs e) //check for key down
        {
            if (e.KeyValue == (char)Keys.Up || e.KeyValue == (char)Keys.W)
            {
                up = true;
            }
            if (e.KeyValue == (char)Keys.Down || e.KeyValue == (char)Keys.S)
            {
                down = true;
            }
            lblControls.Visible = false;
        }

        private void Arcade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Up || e.KeyValue == (char)Keys.W)
            {
                up = false;
            }
            if (e.KeyValue == (char)Keys.Down || e.KeyValue == (char)Keys.S)
            {
                down = false;
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Movement();
            CheckCollision();

            if(wizzard1.YForce != 0)
            {
                wizzard1.moveVertical();
            }
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
