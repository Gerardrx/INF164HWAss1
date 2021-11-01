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
    public partial class Pigeon : PictureBox
    { 
        public int speed;
        public bool dead = false;

        public Pigeon()
        {
            InitializeComponent();

            Image = global::INF164HWAss1.Properties.Resources.pidgion;
            Visible = true;
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Size = new Size(77, 71);
            BackColor = Color.Transparent;
        }

        public void movePigeon()
        {
            Location = new Point(Location.X + speed, Location.Y);
        }
    }
}
