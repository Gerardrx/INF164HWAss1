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
        //private variables
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
        [Description("Min X Coordinate")]
        public int MinX // min xcord to travel to
        {
            get => minX;
            set => minX = value;
        }

        // used to make own properties that are editable in the design view
        [Category("Travel")]
        [Browsable(true)]
        [Description("Max X Coordinate")]
        public int MaxX // max xcord to travel to
        {
            get => maxX;
            set => maxX = value;
        }

        // used to make own properties that are editable in the design view
        [Category("Travel")]
        [Browsable(true)]
        [Description("Min Y Coordinate")]
        public int MinY // min ycord to travel to
        {
            get => minY;
            set => minY = value;
        }

        // used to make own properties that are editable in the design view
        [Category("Travel")]
        [Browsable(true)]
        [Description("Max Y Coordinate")]
        public int MaxY // max ycord to travel to
        {
            get => maxY;
            set => maxY = value;
        }

        //bla bla bla
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
