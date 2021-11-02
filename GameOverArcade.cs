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
        //public variables
        public int coins;

        public GameOverArcade()
        {
            InitializeComponent();

            Opacity = 0;
            OpenFadeTimer.Start();

            pbBackground.Controls.Add(this.lblGameover);
            pbBackground.Controls.Add(this.lblGameOverCoins);
            pbBackground.Controls.Add(this.pbGameOverCoins);
        }

        public void updateCoin() //get coin value from arcade
        {
            lblGameOverCoins.Text = "" + coins;
        }

        private void GameOverArcade_KeyUp(object sender, KeyEventArgs e) // key registration
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
