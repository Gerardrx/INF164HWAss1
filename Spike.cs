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
    public partial class Spike : PictureBox
    {
        private char heading;
        private int minX;
        private int maxX;
        private int minY;
        private int maxY;
        private int speed;

        public Spike()
        {
            InitializeComponent();
            SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
                  //Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    this.Invalidate();
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

        [Category("Travel")]
        [Browsable(true)]
        [Description("Travel Speed")]
        public int Speed 
        { 
            get => speed; 
            set => speed = value; 
        }

        public void moveSpike()
        {
            if (Heading == 'u')
            {
                if (Location.Y > MinY)
                {
                    Location = new Point(Location.X, Location.Y - speed);
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
                    Location = new Point(Location.X, Location.Y + speed);
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
                    Location = new Point(Location.X - speed, Location.Y);
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
                    Location = new Point(Location.X + speed, Location.Y);
                }
                else
                {
                    Heading = 'l';
                }
            }
        }


















    }
}
