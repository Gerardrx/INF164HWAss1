using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class Spike : PictureBox
    {
        //private variables
        private char heading;
        private int speed;

        public Spike()
        {
            InitializeComponent();
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        // used to make own properties that are editable in the design view
        [Category("Travel")]
        [Browsable(true)]
        [Description("Direction of travel u d l r")]
        public char Heading // direction of spike movement
        {
            get => heading;
            set => heading = value;

        }

        // used to make own properties that are editable in the design view
        [Category("Travel")]
        [Browsable(true)]
        [Description("Travel Speed")]
        public int Speed //rate of travel
        {
            get => speed;
            set => speed = value;
        }

        public void moveSpike() // move spike based on heading and speed
        {
            if (heading == 'u' || heading == 'd')
            {
                Location = new Point(Location.X, Location.Y + speed);
            }
            else if (heading == 'l' || heading == 'r')
            {
                Location = new Point(Location.X + speed, Location.Y);
            }
        }
    }
}
