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

            Opacity = 0;
            OpenFadeTimer.Start();

            this.BackColor = ColorTranslator.FromHtml("#66ceef");
        }

        private void OpenFadeTimer_Tick(object sender, EventArgs e)
        {
            //Fade in the form
            if (Opacity == 1)
            {
                OpenFadeTimer.Stop();
            }
            Opacity += 0.03;
        }

        private void CloseFadeTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity == 0)
            {
                CloseFadeTimer.Stop();
                this.Hide();

                //Create and display Instructions form
                frmMenu mm = new frmMenu();
                mm.Visible = true;
            }
            Opacity -= 0.03;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmMenu mm = new frmMenu();
            mm.Visible = true;
        }

        private void btnArcade_Click(object sender, EventArgs e)
        {
            Arcade a = new Arcade();
            a.Visible = true;
        }
    }
}
