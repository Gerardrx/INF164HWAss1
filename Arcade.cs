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
        Random rand = new Random();
        int coins = 0;

        public Arcade()
        {
            InitializeComponent();
        }

        private void Arcade_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GameTimer.Start();
        }

        private void movePicture()
        {
            int x = rand.Next(this.Size.Width - 75);
            int y = rand.Next(this.Size.Height - 75);

            if (x < 0)
            {
                x = 0;
            }

            if (y < 0)
            {
                y = 0;
            }

            pictureBox1.Location = new Point(x, y);
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            movePicture();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            coins++;
            lblCoins.Text = "Coins: " + coins;
            
        }
    }
}
