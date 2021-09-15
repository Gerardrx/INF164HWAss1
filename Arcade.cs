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
        int coins = 0;
        bool flag = false;
        bool bomb = false;
        int speed = 1000;
        int hearts = 3;

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
            choosePicture();
            int x = rand.Next(75,this.Size.Width - 75);
            int y = rand.Next(105,this.Size.Height - 75);

            pbClickMe.Location = new Point(x, y);
            lblBorder.Location = new Point(x - 2, y - 2);


        }
        private void choosePicture()
        {
            pbClickMe.BackgroundImage = global::INF164HWAss1.Properties.Resources.bomba;
            //pbClickMe.Size.Width 
            ///inside bigger if
            double prob = rand.Next(0, 100);
            if (prob < 10 & coins > 10)
            {
                pbClickMe.BackgroundImage = global::INF164HWAss1.Properties.Resources.bomba1;
                bomb = true;
                prob = prob + 0.5;
            }
           
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            movePicture();
            flag = true;
            lblBorder.BackColor = Color.Transparent;
        }

        private void pbClickMe_MouseDown(object sender, MouseEventArgs e)
        {
            if(bomb)
            {
                hearts--;
                pbClickMe.BackgroundImage = global::INF164HWAss1.Properties.Resources.bomba;
                lblBorder.BackColor = Color.Transparent;

                GameTimer.Interval = 5000;

                switch (hearts)
                {
                    case 1:
                        pbHearts.BackgroundImage = global::INF164HWAss1.Properties.Resources.Heart_1;
                        break;
                    case 2:
                        pbHearts.BackgroundImage = global::INF164HWAss1.Properties.Resources.heart_2;
                        break;
                    case 3:
                        pbHearts.BackgroundImage = global::INF164HWAss1.Properties.Resources.heart_3;
                        break;
                    case 0:
                        pbHearts.BackgroundImage = global::INF164HWAss1.Properties.Resources.Heart_0;
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
                speed = speed - 5;
                GameTimer.Interval = speed;
                
            }
        }
    }
}
