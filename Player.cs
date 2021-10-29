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
        private char direction;
        private int xForce = 0;
        private int yForce = 0;
        private bool floor = false;
        private bool running = false;
        public bool stopLeft = false;
        public bool stopRight = false;


        public Player()
        {
            InitializeComponent();
        }

        [Category("Travel")]
        [Browsable(true)]
        [Description("Direction of travel l r")]
        public char Direction 
        { 
            get => direction;
            set 
            { 
                if(value == 'l')
                {
                    Image = global::INF164HWAss1.Properties.Resources.maskdudeRunLeft;
                }
                if(value == 'r')
                {
                    Image = global::INF164HWAss1.Properties.Resources.maskdudeRunRight;
                }

                direction = value; 
            }
             
        }

        public int XForce 
        { 
            get => xForce;
            set 
            {
                xForce = value;
                if(value == 0)
                {
                    if(Direction == 'l')
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

        public bool Running 
        { 
            get => running;
            set 
            { 
                if(running != value)
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
        public int YForce 
        { 
            get => yForce;
            set
            {
                yForce = value;
                if (value == 0)
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

        public bool Floor
        {
            get => floor;
            set
            {

                if(floor != value)
                {
                    floor = value;

                    if (value)
                    {
                        if (running)
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
                        else 
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



        public void moveHorizontal()
        {
            if(XForce < 0 && !stopLeft)
            {
                moveLeft();
                stopRight = false;
                stopLeft = false;
            }
            else if(XForce > 0 && !stopRight)
            {
                moveRight();
                stopLeft = false;
                stopRight = false;
            }
        }

        private void moveLeft()
        {
            Location = new Point(Location.X + XForce, Location.Y); //-
            if(direction != 'l')
            {
                Direction = 'l';
            }
        }
        private void moveRight()
        {
            Location = new Point(Location.X + XForce, Location.Y);//+
            if (direction != 'r')
            {
                Direction = 'r';
            }
        }
        public void moveUp()
        {
            Location = new Point(Location.X, Location.Y - 5);
            if (direction != 'u')
            {
                Direction = 'u';
            }
        }
        public void fall()
        {
            Location = new Point(Location.X, Location.Y + YForce); //+ 5
            YForce += 2;
            if (Direction == 'l')
            {
                Image = global::INF164HWAss1.Properties.Resources.maskdudeFallLeft;
            }
            else
            {
                Image = global::INF164HWAss1.Properties.Resources.maskdudeFallRight;
            }
        }
        public void jump()
        {

            Location = new Point(Location.X , Location.Y + YForce); //-5
                        
            YForce++;

            if (Direction == 'l')
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
