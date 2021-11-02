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
    public partial class Wizzard : PictureBox
    {
        //public variables
        public bool stopUp = false;
        public bool stopDown = false;

        //private variables
        private int yForce = 0;

        public Wizzard()
        {
            InitializeComponent();

            Image = global::INF164HWAss1.Properties.Resources.Wizzard;
        }

        public int YForce
        {
            get => yForce;
            set
            {
                yForce = value;
            }
        }

        private void moveUp() // move up
        {
            Location = new Point(Location.X, Location.Y + yForce);
        }

        private void moveDown() // move down
        {
            Location = new Point(Location.X, Location.Y + yForce);
        }

        public void moveVertical()
        {
            if(yForce > 0 && !stopDown)
            {
                stopDown = false;
                stopUp = false;
                moveDown();
            }
            if(yForce < 0 && !stopUp)
            {
                stopDown = false;
                stopUp = false;
                moveUp();
            }
        }
    }
}
