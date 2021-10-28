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
    public partial class Runner : Form
    {
        int x;
        int y;
        int coins = 0;

        Random rand = new Random();

        public Runner()
        {
            InitializeComponent();
            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            moveAllGhosts();
            CheckDeath();
        }

        private void Runner_KeyDown(object sender, KeyEventArgs e)
        {
            x = player1.Location.X;
            y = player1.Location.Y;

            if (e.KeyValue == (char)Keys.Up || e.KeyValue == (char)Keys.W)
            {
                player1.moveUp();
            }

            if (e.KeyValue == (char)Keys.Down || e.KeyValue == (char)Keys.S)
            {
                player1.moveDown();
            }

            if (e.KeyValue == (char)Keys.Left || e.KeyValue == (char)Keys.A)
            {
                player1.moveLeft();
            }

            if (e.KeyValue == (char)Keys.Right || e.KeyValue == (char)Keys.D)
            {
                player1.moveRight();
            }
            checkCollision();
        }

        private void checkCollision()
        {
            foreach (Control w in this.Controls)
            {
                if (w is Wall)
                {
                    if (w.Bounds.IntersectsWith(player1.Bounds))
                    {
                        if (player1.Left < ((PictureBox)w).Left && player1.Direction == 'r')
                        {
                            x = ((PictureBox)w).Location.X - player1.Width - 1;
                        }
                        else if (player1.Left > ((PictureBox)w).Left && player1.Direction == 'l')
                        {
                            x = ((PictureBox)w).Location.X + ((PictureBox)w).Width + 1;
                        }

                        else if (player1.Top < ((PictureBox)w).Top && player1.Direction == 'd')
                        {
                            y = ((PictureBox)w).Location.Y - player1.Height - 1;
                        }
                        else if (player1.Top > ((PictureBox)w).Top && player1.Direction == 'u')
                        {
                            y = ((PictureBox)w).Location.Y + ((PictureBox)w).Height + 1;
                        }
                        player1.Location = new Point(x, y);
                    }
                }

                if (w is Coin)
                {
                    if (player1.Bounds.IntersectsWith(w.Bounds))
                    {
                        w.Visible = false;
                        coins++;
                        //label1.Text = "" + coins;

                        Controls.Remove(w);
                        GenerateCoin();
                    }

                }
            }
        }

        private void moveAllGhosts()
        {
            foreach(Control g in this.Controls)
            {
                if(g is Ghost)
                {
                    ((Ghost)g).moveGhost();
                }
            }
        }

        private void CheckDeath()
        {
            foreach (Control g in this.Controls)
            {
                if (g is Ghost)
                {
                    if (g.Bounds.IntersectsWith(player1.Bounds))
                    {
                        gameTimer.Stop();
                        MessageBox.Show("Game Over");
                    }
                }
            }
        }

        private void GenerateCoin()
        {
            Coin c = new Coin();
            Controls.Add(c);

            c.Location = new Point(rand.Next(0, this.Size.Width -50), rand.Next(0, this.Size.Height - 50));
            while (checkCoinCollision(c))
            {
                c.Location = new Point(rand.Next(0, this.Size.Width -50), rand.Next(0, this.Size.Height - 50));
            }   
        }

        private bool checkCoinCollision(Coin c)
        {
            foreach (Control w in this.Controls)
            {
                if(w is Wall)
                {
                    if (w.Bounds.IntersectsWith(c.Bounds))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

    }
}
