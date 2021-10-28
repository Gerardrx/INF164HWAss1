using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;

namespace INF164HWAss1
{
    public partial class Ghost : PictureBox
    {
        private char heading;
        private int minX;
        private int maxX;
        private int minY;
        private int maxY;

        public Ghost()
        {
            InitializeComponent();
        }

        [Category("Travel")]
        [Browsable(true)]
        [Description("Direction of travel u d l r")]
        public char Heading
        {
            get => heading;
            set
            {
                if (value == 'l')
                {
                  //  Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                }
                if (value == 'r')
                {
                   //Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                }
                heading = value;
            }
        }

        [Category("Travel")]
        [Browsable(true)]
        [Description("Min X Coordinate")]
        public int MinX
        {
            get => minX;
            set => minX = value;
        }

        [Category("Travel")]
        [Browsable(true)]
        [Description("Max X Coordinate")]
        public int MaxX
        {
            get => maxX;
            set => maxX = value;
        }

        [Category("Travel")]
        [Browsable(true)]
        [Description("Min Y Coordinate")]
        public int MinY
        {
            get => minY;
            set => minY = value;
        }

        [Category("Travel")]
        [Browsable(true)]
        [Description("Max Y Coordinate")]
        public int MaxY
        {
            get => maxY;
            set => maxY = value;
        }

        /*        [Category("Appearance")]
                [Browsable(true)]
                [Description("Image when going left")]
                public Image ImageLeft 
                { 
                    get => imageLeft; 
                    set => imageLeft = value;
                }

                [Category("Custom")]
                [Browsable(true)]
                [Description("Image when going right")]
                public Image ImageRight 
                { 
                    get => imageRight; 
                    set => imageRight = value; 
                }*/

        public void moveGhost()
        {
            if (Heading == 'u')
            {
                if (Location.Y > MinY)
                {
                    Location = new Point(Location.X, Location.Y - 1);
                }
                else
                {
                    Heading = 'd';
                }
            }
            else if (Heading == 'd')
            {
                if (Location.Y < MaxY)
                {
                    Location = new Point(Location.X, Location.Y + 1);
                }
                else
                {
                    Heading = 'u';
                }
            }
            else if (Heading == 'l')
            {
                if (Location.X > MinX)
                {
                    Location = new Point(Location.X - 1, Location.Y);
                }
                else
                {
                    Heading = 'r';
                }
            }
            else if (Heading == 'r')
            {
                if (Location.X < MaxX)
                {
                    Location = new Point(Location.X + 1, Location.Y);
                }
                else
                {
                    Heading = 'l';
                }
            }
        }


















    }
}
