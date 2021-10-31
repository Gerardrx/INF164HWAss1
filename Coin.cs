using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class Coin : PictureBox
    {
        public Coin()
        {
            InitializeComponent();
            Image = global::INF164HWAss1.Properties.Resources.coin;
            Visible = true;
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

    }
}
