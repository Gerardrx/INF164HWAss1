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
    public partial class Player : PictureBox
    {
        char direction;


        public Player()
        {
            InitializeComponent();
        }


        [Category("Travel")]
        [Browsable(true)]
        [Description("Direction of travel u d l r")]
        public char Direction 
        { 
            get => direction;
            set 
            { 
                if(value == 'l')
                {

                }
                if(value == 'r')
                {

                }

                direction = value; 
            }
             
        }

        public void moveLeft()
        {
            Location = new Point(Location.X - 5, Location.Y);
            Direction = 'l';
        }
        public void moveRight()
        {
            Location = new Point(Location.X + 5, Location.Y);
            Direction = 'r';
        }
        public void moveUp()
        {
            Location = new Point(Location.X, Location.Y - 5);
            Direction = 'u';
        }
        public void moveDown()
        {
            Location = new Point(Location.X, Location.Y + 5);
            Direction = 'd';
        }

    }
}
