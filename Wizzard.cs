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
        //private variables
        private int yForce = 0;

        public Wizzard()
        {
            InitializeComponent();
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
            Location = new Point(Location.X, Location.Y + YForce);
        }

        private void moveDown() // move down
        {
            Location = new Point(Location.X, Location.Y + YForce);
        }

        public void moveVertical()
        {
            if(yForce > 0)
            {
                moveDown();
            }
            if(yForce < 0)
            {
                moveUp();
            }
        }
    }
}
