using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class Player : PictureBox
    {
        //private variables
        private char direction;
        private int xForce = 0;
        private int yForce = 0;
        private bool floor = false;
        private bool running = false;

        // public variables set in runner
        public bool stopLeft = false;
        public bool stopRight = false;


        ///IMPORTANT if you set a gif over and over it wont play
        ///a lot of the code here is to prevent it from happening
        ///ie only setting gif once

        public Player()
        {
            InitializeComponent();
            BackColor = Color.Transparent;
        }

        // used to make own properties that are editable in the design view
        [Category("Travel")]
        [Browsable(true)]
        [Description("Direction of travel l r")]
        public char Direction // direction of travel
        {
            get => direction;
            set
            {
                if (value == 'l')  // if direction change change gif
                {
                    Image = global::INF164HWAss1.Properties.Resources.maskdudeRunLeft;
                }
                if (value == 'r')
                {
                    Image = global::INF164HWAss1.Properties.Resources.maskdudeRunRight;
                }

                direction = value;
            }

        }

        // if no [###] not editable in design view
        public int XForce
        {
            get => xForce;
            set
            {
                xForce = value;
                if (value == 0)
                {
                    if (Direction == 'l') // change gif
                    {
                        Image = global::INF164HWAss1.Properties.Resources.maskdudeIdleLeft;
                    }
                    else
                    {
                        Image = global::INF164HWAss1.Properties.Resources.maskdudeIdleRight;
                    }
                    Running = false;
                }
                else
                {
                    Running = true;
                }
            }
        }

        public bool Running // if running change gif
        {
            get => running;
            set
            {
                if (running != value)
                {
                    running = value;

                    if (running)
                    {
                        if (Direction == 'l')
                        {
                            Image = global::INF164HWAss1.Properties.Resources.maskdudeRunLeft;
                        }
                        if (Direction == 'r')
                        {
                            Image = global::INF164HWAss1.Properties.Resources.maskdudeRunRight;
                        }
                    }
                }

            }
        }
        public int YForce // same stuff here
        {
            get => yForce;
            set
            {
                yForce = value;
                if (value == 0)
                {
                    if (Direction == 'l') // chaneg gif if stopping
                    {
                        Image = global::INF164HWAss1.Properties.Resources.maskdudeIdleLeft;
                    }
                    else
                    {
                        Image = global::INF164HWAss1.Properties.Resources.maskdudeIdleRight;
                    }
                }
            }
        }

        public bool Floor // bla bla bla again
        {
            get => floor;
            set
            {

                if (floor != value) // change gif if on ground
                {
                    floor = value;

                    if (value)
                    {
                        if (running) // if running after hitting floor
                        {
                            if (Direction == 'l')
                            {
                                Image = global::INF164HWAss1.Properties.Resources.maskdudeRunLeft;
                            }
                            else
                            {
                                Image = global::INF164HWAss1.Properties.Resources.maskdudeRunRight;
                            }
                        }
                        else //if stopped after hitting floor
                        {
                            if (Direction == 'l')
                            {
                                Image = global::INF164HWAss1.Properties.Resources.maskdudeIdleLeft;
                            }
                            else
                            {
                                Image = global::INF164HWAss1.Properties.Resources.maskdudeIdleRight;
                            }
                        }

                    }

                }
            }
        }

        /// more fun stuff
        /// moving player based on xforce amount
        public void moveHorizontal()
        {
            if (XForce < 0 && !stopLeft)
            {
                moveLeft();
                stopRight = false;
                stopLeft = false;
            }
            else if (XForce > 0 && !stopRight)
            {
                moveRight();
                stopLeft = false;
                stopRight = false;
            }
        }

        //called by method above
        private void moveLeft()
        {
            Location = new Point(Location.X + XForce, Location.Y); //-
            if (direction != 'l')
            {
                Direction = 'l';
            }
        }

        //called by method above
        private void moveRight()
        {
            Location = new Point(Location.X + XForce, Location.Y);//+
            if (direction != 'r')
            {
                Direction = 'r';
            }
        }

        // just move down 
        public void fall()
        {
            Location = new Point(Location.X, Location.Y + YForce); //+ 5
            YForce += 2;
            if (Direction == 'l') // change gif to falling
            {
                Image = global::INF164HWAss1.Properties.Resources.maskdudeFallLeft;
            }
            else
            {
                Image = global::INF164HWAss1.Properties.Resources.maskdudeFallRight;
            }
        }
        public void jump() // move up when jumping
        {

            Location = new Point(Location.X, Location.Y + YForce); //-5

            YForce++;

            if (Direction == 'l') // jump left right gif
            {
                Image = global::INF164HWAss1.Properties.Resources.maskdudeJumpLeft;
            }
            else
            {
                Image = global::INF164HWAss1.Properties.Resources.maskdudeJumpRight;
            }
        }

    }
}
