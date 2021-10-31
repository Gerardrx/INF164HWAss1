using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class Arcade : Form
    {
        public Arcade()

        {
            InitializeComponent();

            Opacity = 0;
            OpenFadeTimer.Start();

            pbClickMe.Visible = false;

            pbBackground.Controls.Add(this.pbClickMe);
            pbBackground.Controls.Add(this.pbHearts);
            pbBackground.Controls.Add(this.lblCoins);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            GameTimer.Start();



        }
      
        private void gameOver()
        {
            GameTimer.Enabled = false;
            pbClickMe.Visible = false;

            MessageBox.Show("Game Over");

        }

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
    }
}
