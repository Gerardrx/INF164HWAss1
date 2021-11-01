using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class frmHome : Form
    {

        private int coins;
        private int memory;
        private int read;
        private Save save;

        public frmHome()
        {
            InitializeComponent();

            ReadDataFromFile();

            btnBack.Enabled = false;
            btnArcade.Enabled = false;
            btnLibrary.Enabled = false;
            btnMemory.Enabled = false;
            btnArcade2.Enabled = false;

            Opacity = 0;
            OpenFadeTimer.Start();

            UpdateScore();

            HappinessBarTimer.Start();

            //Tooltips for scores
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(lblCoins, "Total coins");

            System.Windows.Forms.ToolTip ToolTip2 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(lblSleepScore, "Points for memory");

            System.Windows.Forms.ToolTip ToolTip3 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(lblIntelligenceScore, "Points for intelligence");

            System.Windows.Forms.ToolTip ToolTip4 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(pgbHappinessBar, "Keep Mametchi happy by playing games and reading books.");
        }

        int mood = 100;
        int i = 0;

        private void btnBack_Click(object sender, EventArgs e)
        {
            WriteDataToFile();
            CloseFadeTimer.Start();
        }

        private void btnArcade_Click(object sender, EventArgs e)
        {
            ArcadeFadeTimer.Start();
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
                    pbMood.Image = global::INF164HWAss1.Properties.Resources.Nutral_face;
                }
                else if (i == 50)
                {
                    pgbHappinessBar.ForeColor = Color.RoyalBlue;
                    pbMood.Image = global::INF164HWAss1.Properties.Resources.Nutral_face;
                }
                else if (i > 50 && i < 75)
                {
                    pgbHappinessBar.ForeColor = Color.Yellow;
                    pbMood.Image = global::INF164HWAss1.Properties.Resources.Nutral_face;
                }
                else if (i >= 75)
                {
                    pgbHappinessBar.ForeColor = Color.FromArgb(0, 192, 0);
                    pbMood.Image = global::INF164HWAss1.Properties.Resources.Happy_face;
                }
            }
            else if (i == mood)
            {
                switch (i)
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


        public void WriteDataToFile()
        {
            save.Book = read;
            save.Coins = coins;
            save.Brain = memory;

            FileStream outFile = new FileStream("save.ser", FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(outFile, save);
            outFile.Close();
        }

        public void ReadDataFromFile()
        {
            try
            {
                FileStream inFile = new FileStream("save.ser", FileMode.Open, FileAccess.Read);
                BinaryFormatter bFormatter = new BinaryFormatter();
                save = (Save)bFormatter.Deserialize(inFile);
                inFile.Close();

            }
            catch (FileNotFoundException)
            {
                save = new Save();
                MessageBox.Show("save not found");
            }

            coins = save.Coins;
            memory = save.Brain;
            read = save.Book;
        }

        private void SleepFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                SleepFadeTimer.Stop();

                frmSleep s = new frmSleep();
                this.Hide();
                s.ShowDialog();
                this.Show();
                OpenFadeTimer.Start();
            }
            Opacity -= 0.03;
        }

        private void LibraryFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                LibraryFadeTimer.Stop();

                Library l = new Library();
                this.Hide();
                l.ShowDialog();
                this.Show();
                OpenFadeTimer.Start();
            }
            Opacity -= 0.03;
        }

        private void ArcadeFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                ArcadeFadeTimer.Stop();

                Arcade a = new Arcade();
                this.Hide();
                WriteDataToFile();
                a.ShowDialog();
                ReadDataFromFile();
                this.coins = this.coins + a.coin;
                this.Show();
                OpenFadeTimer.Start();
                UpdateScore();
            }
            Opacity -= 0.03;
            
        }

        private void OpenFadeTimer_Tick(object sender, EventArgs e)
        {
            //Fade in the form
            if (Opacity == 1)
            {
                OpenFadeTimer.Stop();
                btnArcade2.Enabled = true;
                btnBack.Enabled = true;
                btnArcade.Enabled = true;
                btnLibrary.Enabled = true;
                btnMemory.Enabled = true;
            }
            Opacity += 0.03;
        }

        private void CloseFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                this.Dispose();
                CloseFadeTimer.Stop();
            }
            Opacity -= 0.03;
        }

        private void btnArcade2_Click(object sender, EventArgs e)
        {
            Runner r = new Runner();
            WriteDataToFile();
            this.Hide();
            r.ShowDialog();
            ReadDataFromFile();
            this.coins = this.coins + r.coins;
            this.Show();
            UpdateScore();
        }


        private void UpdateScore()
        {
            lblCoins.Text = "" + coins;
            lblIntelligenceScore.Text = "" + memory;
            lblSleepScore.Text = "" + read;
        }
    }
}
