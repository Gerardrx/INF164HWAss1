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

            ClockTimer.Start();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            HomeFadeTimer.Start();
        }

        private void btnInstructions_Click(object sender, EventArgs e)
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
            if(Opacity == 1)
            {
                OpenFadeTimer.Stop();
            }
            Opacity += 0.03;
        }

        private void InstructionsFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                InstructionsFadeTimer.Stop();
                this.Hide();

                //Create and display Instructions form
                frmInstructions i = new frmInstructions();
                i.Visible = true;
            }
            Opacity -= 0.03;
        }

        private void HomeFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                HomeFadeTimer.Stop();
                this.Hide();

                //Create and display Home form
                frmHome h = new frmHome();
                h.Visible = true;
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
