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
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();


            btnBack.Enabled = false;
            btnArcade.Enabled = false;
            btnLibrary.Enabled = false;
            btnSleep.Enabled = false;

            Opacity = 0;
            OpenFadeTimer.Start();

            this.BackColor = ColorTranslator.FromHtml("#66ceef");

            HappinessBarTimer.Start();
        }

        int mood = 100;
        int i = 0;

        private void OpenFadeTimer_Tick(object sender, EventArgs e)
        {
            //Fade in the form
            if (Opacity == 1)
            {
                OpenFadeTimer.Stop();

                btnBack.Enabled = true;
                btnArcade.Enabled = true;
                btnLibrary.Enabled = true;
                btnSleep.Enabled = true;
            }
            Opacity += 0.03;
        }

        private void CloseFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                CloseFadeTimer.Stop();
                this.Hide();

                //Create and display Menu form
                frmMenu mm = new frmMenu();
                mm.Visible = true;
            }
            Opacity -= 0.03;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseFadeTimer.Start();
        }

        private void btnArcade_Click(object sender, EventArgs e)
        {
            ArcadeFadeTimer.Start();
        }

        private void ArcadeFadeTimer_Tick(object sender, EventArgs e)
        {
            if(Opacity == 0)
            {
                ArcadeFadeTimer.Stop();
                this.Hide();

                Arcade a = new Arcade();
                a.Visible = true;
            }
            Opacity -= 0.03;
        }

        private void HappinessBarTimer_Tick(object sender, EventArgs e)
        {
            pgbHappinessBar.Value = i;
            i++;

            if (i != mood)
            {
                if (i < 25)
                {
                    pgbHappinessBar.ForeColor = Color.Red;
                    pbMood.Image = global::INF164HWAss1.Properties.Resources.Sad_Face;
                }
                else if (i < 50 && i >= 25)
                {
                    pgbHappinessBar.ForeColor = Color.Orange;
                }
                else if (i == 50)
                {
                    pgbHappinessBar.ForeColor = Color.RoyalBlue;
                    pbMood.Image = global::INF164HWAss1.Properties.Resources.Nutral_face;
                }
                else if (i > 50 && i < 75)
                {
                    pgbHappinessBar.ForeColor = Color.Yellow;
                    pbMood.Image = global::INF164HWAss1.Properties.Resources.Happy_face;
                }
                else if (i >= 75)
                {
                    pgbHappinessBar.ForeColor = Color.Green;
                }
            }else if (i == mood)
            {
                switch(i)
                {
                    case 50:
                        pgbHappinessBar.ForeColor = Color.RoyalBlue;
                        pbMood.Image = global::INF164HWAss1.Properties.Resources.Nutral_face;
                        break;
                }
                HappinessBarTimer.Stop();
                pgbHappinessBar.Value = mood;
            }
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            SleepFadeTimer.Start();
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            ArcadeFadeTimer.Start();
        }

        private void SleepFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                SleepFadeTimer.Stop();
                this.Hide();

                frmSleep s = new frmSleep();
                s.Visible = true;
            }
            Opacity -= 0.03;
        }

        private void LibraryFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                ArcadeFadeTimer.Stop();
                this.Hide();

                Arcade a = new Arcade();
                a.Visible = true;
            }
            Opacity -= 0.03;
        }
    }
}
