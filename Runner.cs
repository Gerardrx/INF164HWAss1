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

    //COPYRIGHT Gerard Geldenhuys, Do not Distribute

    public partial class Runner : Form
    {
        // public variable for home page score
        public int coins = 0;

        //private variables for program
        private int x;
        private int y;
        
        private bool floor = false;
        private bool jump = false;
        private bool jumping = false;

        private bool space = false;
        private bool left = false;
        private bool right = false;

        private Random rand = new Random();
        private Panel BoxCollider = new Panel();
        private Panel SpikeCollider = new Panel();
        private Coin c;

        public Runner()
        {
            InitializeComponent();

            gameTimer.Start();
            x = player1.Location.X; //gets locarion for first time
            y = player1.Location.Y;
            Cursor.Hide();
        }

        private void gameTimer_Tick(object sender, EventArgs e) // every milisecond
        {
            movement(); // move player
            moveAllSpikes(); //moves spikes
            CheckDeath(); // checks for spike death
            fallCheck(); // checks if floor is under player

            if (jump) // if jump command given
            {
                jumping = true;
                jumpPlayer();
            }

            checkCollision(); // checks collisions with walls
            if (player1.XForce != 0) // moves players if has inertia
            {
                player1.moveHorizontal();

                if(player1.XForce > 0)
                {
                    player1.XForce--;
                }
                else
                {
                    player1.XForce++;
                }  
            }

        }

        private void Runner_KeyDown(object sender, KeyEventArgs e) // key down checker
        {
            x = player1.Location.X;
            y = player1.Location.Y;

            if (e.KeyValue == (char)Keys.Space || e.KeyValue == (char)Keys.Up)
            {
                space = true;
            }
            if (e.KeyValue == (char)Keys.Left || e.KeyValue == (char)Keys.A)
            {
                left = true;
            }
            if (e.KeyValue == (char)Keys.Right || e.KeyValue == (char)Keys.D)
            {
                right = true;
            }
            lblControls.Visible = false;
        }

        private void movement() // moves player
        {
            if (space && floor && !jumping) // if on floor for jump
            {
                jump = true;
                player1.YForce = -18;
            }
            if (left)
            {
                player1.XForce = -5;
            }
            if (right)
            {
                player1.XForce = +5;
            }
            checkCollision(); // checks collision with walls
        }

        private void Runner_KeyUp(object sender, KeyEventArgs e) // stops movement
        {
            if (e.KeyValue == (char)Keys.Space || e.KeyValue == (char)Keys.Up)
            {
                space = false;
            }
            if (e.KeyValue == (char)Keys.Left || e.KeyValue == (char)Keys.A)
            {
                left = false;
            }
            if (e.KeyValue == (char)Keys.Right || e.KeyValue == (char)Keys.D)
            {
                right = false;
            }
            if (e.KeyValue == (char)Keys.Escape) // exit game
            {
                Cursor.Show();
                this.Dispose();
            }
            if (e.KeyValue == (char)Keys.R) // restart game
            {
                Restart();
            }
        }

        private void fallCheck() // check if floor is underneath
        {
            if (!jump)
            {
                // box collider is a cool piece of code that moves a panel of same size as player down to check for floor collision
                BoxCollider.Size = player1.Size;
                BoxCollider.Location = new Point(player1.Location.X, player1.Location.Y + 5);
                BoxCollider.Visible = false;

                floor = false;
                foreach (Control w in this.Controls) // for each thing in the form
                {
                    if (w is Wall) // is wall / floor
                    {
                        if (BoxCollider.Bounds.IntersectsWith(w.Bounds))
                        {
                            floor = true;
                        }
                    }
                }
            }
            if (!floor) // if no floor fall
            {
                player1.YForce = 5;
                player1.fall();
                checkCollision();
            }

            player1.Floor = floor; // used for player animation
        }

        private void jumpPlayer() // jumps player
        {
            if(player1.YForce < 0 && floor)
            {
                player1.jump();
                player1.stopLeft = false; // you can move if next to wall
                player1.stopRight = false; // same here
            }
            else // if at end of jump start fall
            {
                jump = false; 
                floor = false;
                jumping = false;
            }
        }

        private void checkCollision() // check collision with walls and ceiling
        {
            x = player1.Location.X;
            y = player1.Location.Y;

            player1.stopLeft = false;
            player1.stopRight = false;

            BoxCollider.Size = player1.Size;
            BoxCollider.Visible = false;
            foreach (Control w in this.Controls)
            {
                if (w is Wall)
                {
                    BoxCollider.Size = player1.Size; // Move panel to left of player to detiremine if there is a wall on the left
                    BoxCollider.Location = new Point(player1.Location.X - 5, player1.Location.Y - 4); // hitting left
                    if (BoxCollider.Bounds.IntersectsWith(w.Bounds))
                    {
                        player1.stopLeft = true; // cant move left in player code
                    }

                    // Move panel to right of player to detiremine if there is a wall on the right
                    BoxCollider.Location = new Point(player1.Location.X + 5, player1.Location.Y - 4); //hitting right
                    if (BoxCollider.Bounds.IntersectsWith(w.Bounds))
                    {
                       player1.stopRight = true;
                    }

                    // Move panel to up of player to detiremine if there is a ceiling
                    BoxCollider.Size = new Size(player1.Size.Width -30, player1.Size.Height -30);
                    BoxCollider.Location = new Point(player1.Location.X + 15, player1.Location.Y -4 ); //hitting head
                    if (jump && BoxCollider.Bounds.IntersectsWith(w.Bounds))
                    {
                        player1.Location = new Point(x, y + 3); // keeps from getting stuck in ceiling
                        jump = false;
                        jumping = false;
                        floor = false;
                    }
                }

                if (w is Coin) // if you hit a coin
                {
                    if (player1.Bounds.IntersectsWith(w.Bounds))
                    {
                        coins++; // more moela
                        lblCoins.Text = "" + coins;
                        GenerateCoin((Coin)w); // generates new coin
                        Controls.Remove(w); // deletes old coin
                        lblInstructions.Visible = false; // go away
                    }
                }
            }
        }

        private void moveAllSpikes() // moves spikes based on properties set in designer
        {
            foreach (Control g in this.Controls)
            {
                if (g is Spike)
                {
                    ((Spike)g).moveSpike(); // move baba move
                }
            }
        }

        private void CheckDeath() // see if dead
        {
            SpikeCollider.Visible = false;
            foreach (Control g in this.Controls)
            {
                if (g is Spike) // was g beacuse it used to be ghosts
                {
                    //collider for spikes because hitbox to big cant jump over
                    SpikeCollider.Size = new Size(g.Size.Width - 44,g.Size.Height - 44);
                    SpikeCollider.Location = new Point(g.Location.X + 22, g.Location.Y +22);

                    if (SpikeCollider.Bounds.IntersectsWith(player1.Bounds))
                    {
                         GameOver(); // die
                    }
                }
                else if(g is PictureBox && (string) g.Tag == "floorSpike") // if a floor spike
                {
                    //change size of floor spike collider
                    SpikeCollider.Size = new Size(g.Size.Width - 20, g.Size.Height - 4);
                    SpikeCollider.Location = new Point(g.Location.X + 10, g.Location.Y + 4);

                    if (SpikeCollider.Bounds.IntersectsWith(player1.Bounds))
                    {
                         GameOver(); //die
                    }
                }
            }
        }

        private void GameOver()
        {
            gameTimer.Stop(); // stop everything
            pbGameOver.Visible = true; // game over screen
            lblRestart.Visible = true;
        }

        private void Restart()
        {
            // reset all to original positions
            coins = 0;
            player1.Location = new Point(70, 900);
            lblControls.Visible = true;
            lblInstructions.Visible = true;
            gameTimer.Start();
            left = false;
            right = false;
            space = false;
            jump = false;
            jumping = false;
            this.Controls.Add(coin1);
            this.Controls.Remove(c);
            lblCoins.Text = "0";
            pbGameOver.Visible = false;
            lblRestart.Visible = false;
        }


        private void GenerateCoin(Coin old) // cool code
        {
            //new coin same size
            c = new Coin();
            Controls.Add(c);
            c.Size = old.Size; // used to be different size coins
            c.SendToBack(); // back so that spikes go over

            // generates random position
            c.Location = new Point(rand.Next(20, this.Size.Width - 20), rand.Next(20, this.Size.Height - 20));
            while (checkCoinCollision(c)) // until found a open space
            {
                c.Location = new Point(rand.Next(20, this.Size.Width - 20), rand.Next(20, this.Size.Height - 20));
            }
        }

        private bool checkCoinCollision(Coin c) // for some reason very hard to code
        {
            foreach (Control w in this.Controls)
            {// cant collide with walls / floor spikes
                if (w is Wall || w is NoCoinSpawn ||(w is PictureBox && (string) w.Tag == "floorSpike"))
                {
                    if (w.Bounds.IntersectsWith(c.Bounds))
                    {
                        return true; // if opeing found true
                    }
                }
            }
            return false;
        }

    }

    // if your reading this you are very interessted in my code
    // check player.cs, spike.cs for more insight
}



        