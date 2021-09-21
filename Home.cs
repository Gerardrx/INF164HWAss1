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
            SleepBarTimer.Start();
            LibraryBarTimer.Start();
            ArcadeBarTimer.Start();
        }

        int mood = 60;
        int sleepScore = 50;
        int arcadeScore = 20;
        int libraryScore = 75;
        int i = 0;
        int s = 0;
        int a = 0;
        int l = 0;

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
                this.Dispose();

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
                this.Dispose();

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
                    pgbHappinessBar.ForeColor = Color.FromArgb(0, 192, 0);
                }
            }
            else if (i == mood)
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
            LibraryFadeTimer.Start();
        }

        private void SleepFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                SleepFadeTimer.Stop();
                this.Dispose();

                frmSleep s = new frmSleep();
                s.Visible = true;
            }
            Opacity -= 0.03;
        }

        private void LibraryFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                LibraryFadeTimer.Stop();
                this.Dispose();

                Library l = new Library();
                l.Visible = true;
            }
            Opacity -= 0.03;
        }

        private void SleepBarTimer_Tick(object sender, EventArgs e)
        {
            pgbSleep.Value = s;
            s++;

            if (s != sleepScore)
            {
                if (s < 25)
                {
                    pgbSleep.ForeColor = Color.Red;
                }
                else if (s < 50 && s >= 25)
                {
                    pgbSleep.ForeColor = Color.Orange;
                }
                else if (s == 50)
                {
                    pgbSleep.ForeColor = Color.RoyalBlue;
                }
                else if (s > 50 && s < 75)
                {
                    pgbSleep.ForeColor = Color.Yellow;
                }
                else if (s >= 75)
                {
                    pgbSleep.ForeColor = Color.FromArgb(0, 192, 0);
                }
            }
            else if (s == sleepScore)
            {
                switch (s)
                {
                    case 50:
                        pgbSleep.ForeColor = Color.RoyalBlue;
                        break;
                }
                SleepBarTimer.Stop();
                pgbSleep.Value = sleepScore;
            }
        }

        private void ArcadeBarTimer_Tick(object sender, EventArgs e)
        {
            pgbArcade.Value = a;
            a++;

            if (a != arcadeScore)
            {
                if (a < 25)
                {
                    pgbArcade.ForeColor = Color.Red;
                }
                else if (a < 50 && a >= 25)
                {
                    pgbArcade.ForeColor = Color.Orange;
                }
                else if (a == 50)
                {
                    pgbArcade.ForeColor = Color.RoyalBlue;
                }
                else if (a > 50 && a < 75)
                {
                    pgbArcade.ForeColor = Color.Yellow;
                }
                else if (a >= 75)
                {
                    pgbArcade.ForeColor = Color.FromArgb(0, 192, 0);
                }
            }
            else if (a == arcadeScore)
            {
                switch (a)
                {
                    case 50:
                        pgbArcade.ForeColor = Color.RoyalBlue;
                        break;
                }
                ArcadeBarTimer.Stop();
                pgbArcade.Value = arcadeScore;
            }
        }

        private void LibraryBarTimer_Tick(object sender, EventArgs e)
        {
            pgbLibrary.Value = l;
            l++;

            if (l != libraryScore)
            {
                if (l < 25)
                {
                    pgbLibrary.ForeColor = Color.Red;
                }
                else if (l < 50 && l >= 25)
                {
                    pgbLibrary.ForeColor = Color.Orange;
                }
                else if (l == 50)
                {
                    pgbLibrary.ForeColor = Color.RoyalBlue;
                }
                else if (l > 50 && l < 75)
                {
                    pgbLibrary.ForeColor = Color.Yellow;
                }
                else if (l >= 75)
                {
                    pgbLibrary.ForeColor = Color.FromArgb(0, 192, 0);
                }
            }
            else if (l == libraryScore)
            {
                switch (l)
                {
                    case 50:
                        pgbLibrary.ForeColor = Color.RoyalBlue;
                        break;
                }
                LibraryBarTimer.Stop();
                pgbLibrary.Value = libraryScore;
            }
        }
    }
}
