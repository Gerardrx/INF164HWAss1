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
    public partial class GameOverArcade : Form
    {
        //Private variables
        private int coins;

        public GameOverArcade()
        {
            InitializeComponent();

            Opacity = 0;
            OpenFadeTimer.Start();

            this.Controls.Add(this.pbBackground);
            pbBackground.Controls.Add(this.lblGameover);
            pbBackground.Controls.Add(this.lblGameOverCoins);
            pbBackground.Controls.Add(this.pbGameOverCoins);
        }

        private void GameOverArcade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CloseFadeTimer.Start();
            }
        }

        private void OpenFadeTimer_Tick(object sender, EventArgs e) //Fade in
        {
            if (Opacity == 1)
            {
                OpenFadeTimer.Stop();
            }
            Opacity += 0.03;
        }

        private void CloseFadeTimer_Tick(object sender, EventArgs e) //Fade out
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
