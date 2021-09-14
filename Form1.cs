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
    public partial class frmWelcomeMenu : Form
    {
        public frmWelcomeMenu()
        {
            InitializeComponent();

            LoadingTimer.Start();
            pbLoadingScreen.BringToFront();
            this.Size = new Size(385, 388);
        }

        int time = 0;

        private void btnPlay_Click(object sender, EventArgs e)
        {

        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseFadeTimer.Start();            
        }

        private void CloseFadeTimer_Tick(object sender, EventArgs e)
        {
            if(Opacity == 0)
            {
                CloseFadeTimer.Stop();
                this.Close();
            }
            Opacity -= 0.02;
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            time++;
            
            if(time == 4)
            {
                pbLoadingScreen.Visible = false;
                Opacity = 0;
                this.Size = new Size(1022, 500);
                StartPosition = FormStartPosition.CenterScreen;
                LoadingTimer.Stop();
                OpenFadeTimer.Start();
            }
        }

        private void OpenFadeTimer_Tick(object sender, EventArgs e)
        {
            if(Opacity == 1)
            {
                OpenFadeTimer.Stop();
            }
            Opacity += 0.1;
        }
    }
}
