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

        public Arcade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameTimer.Start();
            flag = true;
        }

        private void movePicture()
        {
            int x = rand.Next(75,this.Size.Width - 75);
            int y = rand.Next(105,this.Size.Height - 75);

            pbClickMe.Location = new Point(x, y);
            lblBorder.Location = new Point(x - 2, y - 2);
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            movePicture();
            flag = true;
            lblBorder.BackColor = Color.Transparent;
        }

        private void pbClickMe_MouseDown(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                coins++;
                lblCoins.Text = "Coins: " + coins;
                flag = false;

                lblBorder.BackColor = Color.Green;
                
            }
        }

    }
}
