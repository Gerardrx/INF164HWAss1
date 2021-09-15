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
    public partial class Arcade : Form
    {
        private Random rand = new Random();
        private Size size = new Size(60, 50);
        private Size sizeBomb = new Size(230, 200);

        int coins = 0;
        bool flag = false;
        bool bomb = false;
        bool skip = false;
        int speed = 1000;
        int hearts = 3;
        double prob;
        
        public Arcade()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#66ceef");
            choosePicture();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameTimer.Start();
            flag = true;
        }

        private void movePicture()
        {
            pbClickMe.Size = size;
            //   pbClickMe.Size = size;
            int x = rand.Next(75,this.Size.Width - 75);
            int y = rand.Next(105,this.Size.Height - 75);

            pbClickMe.Location = new Point(x, y);
            lblBorder.Location = new Point(x - 2, y - 2);
            choosePicture();
            skip = true;
        }
        private void choosePicture()
        {
            pbClickMe.Image = global::INF164HWAss1.Properties.Resources.bicMan;
            //pbClickMe.Size.Width 
            ///inside bigger if
            prob = rand.Next(0, 100);
            if (prob < 10 & coins > 2)//10%
            {
                pbClickMe.Image = global::INF164HWAss1.Properties.Resources.bomba2;
                bomb = true; 
                pbClickMe.Location = new Point(pbClickMe.Location.X - 65, pbClickMe.Location.Y - 45);
                pbClickMe.Size = sizeBomb;           
            }
            prob += 1.5;


        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (skip)
            {
                skip = false;
            }
            else
            {
                movePicture();
                flag = true;
            }

            lblBorder.BackColor = Color.Transparent;
            //pbClickMe.Size = size;
        }

        private void pbClickMe_MouseDown(object sender, MouseEventArgs e)
        {
            if(bomb)
            {
                hearts--;
                coins--;
                pbClickMe.Image = global::INF164HWAss1.Properties.Resources.bomba;
                lblBorder.BackColor = Color.Transparent;
                skip = true;

                GameTimer.Interval = 10000;

                switch (hearts)
                {
                    case 1:
                        pbHearts.Image = global::INF164HWAss1.Properties.Resources.Heart_1;
                        break;
                    case 2:
                        pbHearts.Image = global::INF164HWAss1.Properties.Resources.heart_2;
                        break;
                    case 3:
                        pbHearts.Image = global::INF164HWAss1.Properties.Resources.heart_3;
                        break;
                    case 0:
                        pbHearts.Image = global::INF164HWAss1.Properties.Resources.Heart_0;
                        break;
                }
                bomb = false;
            }

            if (flag)
            {
                coins++;
                lblCoins.Text = "Coins: " + coins;
                flag = false;

                lblBorder.BackColor = Color.Green;
                speed -= 5;
                GameTimer.Interval = speed;
                
            }
        }
    }
}
