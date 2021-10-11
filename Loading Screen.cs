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
        //50 timer

        public frmLoading()
        {
            InitializeComponent();

            LoadingTimer.Start();

            Arcade a = new Arcade();
            a.Visible = true;

            frmSleep s = new frmSleep();
            s.Visible = true;



            //Create player for music and play music
            System.Media.SoundPlayer player = new System.Media.SoundPlayer("Dub_Techno___Selection_016.wav");
            player.Play();
        }

        int i = 0;

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            i++;
            
            if(i <= 75)
                pgbLoading.Value = i;

            if (i == 87)
            {
                LoadingTimer.Stop();

                //Hide the loading form
                this.Hide();

                //Create a new menu form
                frmMenu mm = new frmMenu();
                mm.Visible = true;

                Application.VisualStyleState = System.Windows.Forms.VisualStyles.VisualStyleState.NoneEnabled;
            }
            else if (i == 25)
            {
                //Change the backround colour
                this.BackColor = System.Drawing.Color.DeepSkyBlue;
            }
            else if (i == 50)
            {
                //Change the backround colour
                this.BackColor = System.Drawing.Color.DodgerBlue;
            }
            else if (i == 75)
            {
                //Change the backround colour
                this.BackColor = System.Drawing.Color.DodgerBlue;
            }
        }
    }
}
