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
    public partial class Coin : PictureBox
    {
        public Coin()
        {
            InitializeComponent();
            Image = global::INF164HWAss1.Properties.Resources.coin;
            Size = new Size(32, 32);
            Visible = true;
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;


        }

    }
}
