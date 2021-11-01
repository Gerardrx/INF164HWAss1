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
    public partial class Fireball : PictureBox
    {
        public int speed;

        public Fireball()
        {
            InitializeComponent();

            Image = global::INF164HWAss1.Properties.Resources.Fire;
            Visible = true;
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            Size = new Size(59, 62);
            BackColor = Color.Transparent;
        }

        public void moveFireball()
        {
            Location = new Point(Location.X - speed, Location.Y);
        }
    }
}
