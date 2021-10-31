using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class Wall : PictureBox
    {
        public Wall()
        {
            InitializeComponent();
            BringToFront(); // keeps player from overlapping with floor
        }
    }
}
