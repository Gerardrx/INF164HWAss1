using System;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            btnInstructions.Enabled = false;
            btnPlay.Enabled = false;
            btnClose.Enabled = false;

            //Fade in form
            Opacity = 0;
            OpenFadeTimer.Start();

            ClockTimer.Start();

            //Make pb able to use pb as background
            pbBackground.Controls.Add(this.lblSeconds);
            pbBackground.Controls.Add(this.lblTitle);
            pbBackground.Controls.Add(this.lblTimeA);
            pbBackground.Controls.Add(this.pbDogThingGIF);
            pbBackground.Controls.Add(this.pbExtraPic);
            pbBackground.Controls.Add(this.pbWelcomeGIF);
            pbBackground.Controls.Add(this.pbPic);
            pbBackground.Controls.Add(this.pbmanbic);
        }

        private void btnPlay_Click(object sender, EventArgs e) //go to home screen
        {
            HomeFadeTimer.Start();
        }

        private void btnInstructions_Click(object sender, EventArgs e) //go to instructions screen
        {
            InstructionsFadeTimer.Start(); 
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseFadeTimer.Start();
        }

        private void CloseFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                CloseFadeTimer.Stop();

                //Close the program
                Application.Exit();
            }
            Opacity -= 0.03;
        }

        private void OpenFadeTimer_Tick(object sender, EventArgs e)
        {
            //Fade in the form
            if (Opacity == 1)
            {
                OpenFadeTimer.Stop();

                btnInstructions.Enabled = true;
                btnPlay.Enabled = true;
                btnClose.Enabled = true;
            }
            Opacity += 0.03;
        }

        private void InstructionsFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                InstructionsFadeTimer.Stop();

                //Create and display Instructions form
                frmInstructions i = new frmInstructions();
                this.Hide();
                i.ShowDialog();
                this.Show();
                OpenFadeTimer.Start();
            }
            Opacity -= 0.03;
        }

        private void HomeFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                HomeFadeTimer.Stop();

                //Create and display Home form
                frmHome h = new frmHome();
                this.Hide();
                h.ShowDialog();
                this.Show();
                OpenFadeTimer.Start();
            }
            Opacity -= 0.03;
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            //clock
            lblTimeA.Text = DateTime.Now.ToString("HH:mm");
            lblSeconds.Text = DateTime.Now.ToString("ss");
        }
    }
}
