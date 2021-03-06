using System;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class frmLoading : Form
    {
        //private variables
        private int i = 0;

        public frmLoading()
        {
            InitializeComponent();

            if (!FontInstalled())
            {
                MessageBox.Show("Unispace font not installed \nPlease install font for program to run properly\nThe .tff file is in debug and Resources");
            }
            LoadingTimer.Start();

            try
            {
                // Create player for music and play music
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("Dub_Techno___Selection_016.wav");
                player.Play();
            }
            catch (Exception)
            {
                MessageBox.Show("Music file not found" +
                    "\nplease ensure the .wav song is in the debug folder");
            }
        }

        private void LoadingTimer_Tick(object sender, EventArgs e)
        {
            i++;

            if (i <= 75)
            {
                pgbLoading.Value = i;
            }

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
                this.BackColor = System.Drawing.Color.SteelBlue;
            }
        }

        static bool FontInstalled() //check if font is installed
        {
            using (var ifc = new InstalledFontCollection())
            {
                return ifc.Families.Any(f => f.Name == "Unispace");
            }
        }
    }
}
