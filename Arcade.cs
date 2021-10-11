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
    public partial class Arcade : Form
    {
        private Random rand = new Random();
        private Size size = new Size(52, 52);
        private Size sizeBomb = new Size(230, 200);

        private int coins = 0;
        private bool nextRound = false;
        private bool bomb = false;
        private bool skip = false;
        private int speed = 750;
        private int hearts = 3;
        private int round = 0;
        private double prob;
        private bool currentlyAnimating = false;
        private Bitmap mGif = new Bitmap(global::INF164HWAss1.Properties.Resources.piano);

        public Arcade()

        {
            InitializeComponent();           
            Opacity = 0;
            OpenFadeTimer.Start();

            this.BackColor = ColorTranslator.FromHtml("#66ceef");
            choosePicture();

            pbClickMe.Visible = false;
            lblBorder.Visible = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameTimer.Start();
            nextRound = true;
            pbClickMe.BackColor = Color.Transparent;
        }

        private void movePicture()
        {
            pbClickMe.Size = size;
            int x = rand.Next(75, this.Size.Width - 75);
            int y = rand.Next(105, this.Size.Height - 75);

            pbClickMe.Location = new Point(x, y);
            lblBorder.Location = new Point(x - 1, y - 1);
            choosePicture();
            skip = false;
        }
        private void choosePicture()
        {
            int pic = rand.Next(0, 8);

            switch (pic)
            {
                case 0:
                    pbClickMe.Image = global::INF164HWAss1.Properties.Resources.bicMan;
                    break;
                case 1:
                    pbClickMe.Image = global::INF164HWAss1.Properties.Resources.toot;
                    break;
                case 2:
                    pbClickMe.Image = global::INF164HWAss1.Properties.Resources.bicLady;
                    break;
                case 3:
                    pbClickMe.Image = global::INF164HWAss1.Properties.Resources.bikeMan;
                    break;
                case 4:
                    pbClickMe.Image = global::INF164HWAss1.Properties.Resources.PlantBoi;
                    break;
                case 5:
                    pbClickMe.Image = global::INF164HWAss1.Properties.Resources.PenguMan;
                    break;
                case 6:
                    pbClickMe.Image = global::INF164HWAss1.Properties.Resources.ChickManWoman;
                    break;
                case 7:
                    pbClickMe.Image = global::INF164HWAss1.Properties.Resources.DogNose;
                    break;
            }

            if (round % 3 == 0 && round > 0)
            {
                prob = rand.Next(0, 100);
                if (prob <= 50)
                {
                    pbClickMe.Image = global::INF164HWAss1.Properties.Resources.bomba2;
                    bomb = true;
                    pbClickMe.Location = new Point(pbClickMe.Location.X - 65, pbClickMe.Location.Y - 45);
                    pbClickMe.Size = sizeBomb;
                }
                prob += 3;
            }

        }
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (skip)
            {
                int duration = 1900 - speed;
                GameTimer.Interval = duration;
                skip = false;
            }
            else
            {
                if (hearts <= 0)
                {
                    gameOver();
                }

                bomb = false;
                movePicture();
                nextRound = true;
            }

            lblBorder.BackColor = Color.Transparent;
            round++;

            pbClickMe.Visible = true;
            lblBorder.Visible = true;
        }

        private void pbClickMe_MouseDown(object sender, MouseEventArgs e)
        {
            if (bomb)
            {
                hearts--;
                coins--;
                pbClickMe.Image = global::INF164HWAss1.Properties.Resources.bomba;
                lblBorder.BackColor = Color.Transparent;
                skip = true;

                switch (hearts)
                {
                    case 3:
                        pbHearts.Image = global::INF164HWAss1.Properties.Resources.heart_3;
                        break;
                    case 2:
                        pbHearts.Image = global::INF164HWAss1.Properties.Resources.heart_2;
                        break;
                    case 1:
                        pbHearts.Image = global::INF164HWAss1.Properties.Resources.Heart_1;
                        break;
                    case 0:
                        pbHearts.Image = global::INF164HWAss1.Properties.Resources.Heart_0;
                        break;
                }
                bomb = false;
            }

            if (nextRound)
            {
                coins++;
                lblCoins.Text = "Coins: " + coins;
                nextRound = false;

                lblBorder.BackColor = Color.Green;
                speed -= 3;
            }
            GameTimer.Interval = speed;
        }

        private void gameOver()
        {
            GameTimer.Enabled = false;
            lblBorder.Visible = false;
            pbClickMe.Visible = false;

            MessageBox.Show("Game Over");

        }

 /*        private void AnimateImage()
        {
            if (!currentlyAnimating)
            {
                ImageAnimator.Animate(mGif, new EventHandler(this.OnFormChanged));
                currentlyAnimating = true;
            }
            
        }

        private void OnFormChanged(object o,EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            AnimateImage();
            ImageAnimator.UpdateFrames();
            e.Graphics.DrawImage(this.mGif, new Point(0, 0));
        }*/














        private void OpenFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                OpenFadeTimer.Stop();
            }
            Opacity += 0.03;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseFadeTimer.Start();
        }

        private void CloseFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                CloseFadeTimer.Stop();

                this.Dispose();

                frmHome h = new frmHome();
                h.Visible = true;
            }
            Opacity -= 0.03;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
