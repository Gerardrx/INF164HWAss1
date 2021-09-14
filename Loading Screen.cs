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
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();

            LoadingTimer.Start();

            Arcade a = new Arcade();
            a.Visible = true;
        }

        int time = 0;

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            time++;

            if (time == 3)
            {
                LoadingTimer.Stop();

                //Hide the loading form
                this.Hide();

                //Create a new menu form
                frmMenu mm = new frmMenu();
                mm.Visible = true;
            }
            else if (time == 1)
            {
                //Change the backround colour
                this.BackColor = System.Drawing.Color.DeepSkyBlue;
            }
            else if (time == 2)
            {
                //Change the backround colour
                this.BackColor = System.Drawing.Color.DodgerBlue;
            }
        }
    }
}
