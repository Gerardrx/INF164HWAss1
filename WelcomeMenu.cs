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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();

            //Fade in form
            Opacity = 0;
            OpenFadeTimer.Start();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //Create and display Home form
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            this.Hide();

            Instructions i = new Instructions();
            i.Visible = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            CloseFadeTimer.Start();            
        }

        private void CloseFadeTimer_Tick(object sender, EventArgs e)
        {
            //Fade out the form
            if (Opacity == 0)
            {
                CloseFadeTimer.Stop();

                //Close the program
                Application.Exit();
            }
            Opacity -= 0.02;
        }

        private void OpenFadeTimer_Tick(object sender, EventArgs e)
        {
            //Fade in the form
            if(Opacity == 1)
            {
                OpenFadeTimer.Stop();
            }
            Opacity += 0.02;
        }
    }
}
