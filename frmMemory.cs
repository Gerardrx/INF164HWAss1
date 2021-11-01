using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class frmSleep : Form
    {
        int placeHolder1 = 0, placeHolder2 = 0;
        int ss = 4, ms = 6;
        int startTime = 0;
        int correctCounter = 0;
        int incorrectGuesses = 0;
        public int sleepScore = 10;

        Random rand = new Random();
        PictureBox imgPlaceHolder1, imgPlaceHolder2;

        List<int> randList = new List<int>();
        List<int> duplicateRandList = new List<int>();

        Bitmap[] imageArr = new Bitmap[10];

        public frmSleep()
        {
            InitializeComponent();

            OpenFadeTimer.Start();
            Opacity = 0;

            btnBack.Enabled = false;
            btnStart.Enabled = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseFadeTimer.Start();
        }

        private void OpenFadeTimer_Tick(object sender, EventArgs e)
        {
            //Fade in the form
            if (Opacity == 1)
            {
                OpenFadeTimer.Stop();
                btnBack.Enabled = true;
                btnStart.Enabled = true;
            }
            Opacity += 0.03;
        }

        private void CloseFadeTimer_Tick(object sender, EventArgs e)
        {
            //Fade out the form
            if (Opacity == 0)
            {
                CloseFadeTimer.Stop();
                this.Dispose();
            }
            Opacity -= 0.03;
        }

        private void frmSleep_Load(object sender, EventArgs e)
        {
            //Assigns an image to each index of the array
            imageArr[0] = Properties.Resources.resized_Bulbasaur;
            imageArr[1] = Properties.Resources.resized_Charmander;
            imageArr[2] = Properties.Resources.resized_Clefairy;
            imageArr[3] = Properties.Resources.resized_Pikachu;
            imageArr[4] = Properties.Resources.resized_Rattata;
            imageArr[5] = Properties.Resources.resized_Squirtle;
            imageArr[6] = Properties.Resources.resized_Vulpix;
            imageArr[7] = Properties.Resources.resized_Zubat;

            //Assigns random numbers to the tags of each picturebox
            for (int i = 0; i < 8; i++)
                tlpIcons.Controls[i].Tag = uniqueRand();
            for (int z = 8; z < 16; z++)
                tlpIcons.Controls[z].Tag = duplicateRand();

            for (int x = 0; x < 16; x++)
                tlpIcons.Controls[x].Enabled = false;
        }

        private int uniqueRand() //Method to ensure numbers are not repeated
        {
            int randNum;
            randNum = rand.Next(0, 8);
            if (!randList.Contains(randNum))
            {
                randList.Add(randNum);
                return randNum;
            }
            else
            {
                do
                {
                    randNum = rand.Next(0, 8);
                    if (!randList.Contains(randNum))
                    {
                        randList.Add(randNum);
                        return randNum;
                    }

                }
                while (randList.Contains(randNum));
            }

            return randNum;
        }

        private int duplicateRand() //Duplicate method, Ensures all random numbers are unique
        {
            int randNum;
            randNum = rand.Next(0, 8);
            if (!duplicateRandList.Contains(randNum))
            {
                duplicateRandList.Add(randNum);
                return randNum;
            }
            else
            {
                do
                {
                    randNum = rand.Next(0, 8);
                    if (!duplicateRandList.Contains(randNum))
                    {
                        duplicateRandList.Add(randNum);
                        return randNum;
                    }

                }
                while (duplicateRandList.Contains(randNum));
            }

            return randNum;
        }


        //Checks if the tags of the pictureboxes match
        private void checkMatch(PictureBox cBox)
        {


            if (imgPlaceHolder1 == null)
            {
                imgPlaceHolder1 = cBox;
            }
            else if (imgPlaceHolder1 != null && imgPlaceHolder2 == null)
            {
                imgPlaceHolder2 = cBox;
            }

            if (imgPlaceHolder1 != null && imgPlaceHolder2 != null)
            {
                placeHolder1 = Convert.ToInt32(imgPlaceHolder1.Tag);
                placeHolder2 = Convert.ToInt32(imgPlaceHolder2.Tag);

                if (placeHolder1 == placeHolder2)//if match, increment counter and disable picture
                {
                    correctCounter++;

                    imgPlaceHolder1.Enabled = false;
                    imgPlaceHolder2.Enabled = false;
                }
                else
                {
                    delay();//delays the images disappearing after incorrect clicks
                    if(imgPlaceHolder1 != null)
                        imgPlaceHolder1.BackgroundImage = null;
                    if (imgPlaceHolder2 != null)
                        imgPlaceHolder2.BackgroundImage = null;
                    incorrectGuesses++;
                    
                }
                imgPlaceHolder1 = null;
                imgPlaceHolder2 = null;
            }

            if (correctCounter == 8)
            {
                gameTimer.Enabled = false;
                MessageBox.Show("Congratulations! you win");
                calculateScore();

            }


        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            //Shows the images contained in each picturebox
            tlpIcons.Controls[0].BackgroundImage = imageArr[Convert.ToInt32(pbImg1.Tag)];
            tlpIcons.Controls[1].BackgroundImage = imageArr[Convert.ToInt32(pbImg2.Tag)];
            tlpIcons.Controls[2].BackgroundImage = imageArr[Convert.ToInt32(pbImg3.Tag)];
            #region Repetition 
            tlpIcons.Controls[3].BackgroundImage = imageArr[Convert.ToInt32(pbImg4.Tag)];
            tlpIcons.Controls[4].BackgroundImage = imageArr[Convert.ToInt32(pbImg5.Tag)];
            tlpIcons.Controls[5].BackgroundImage = imageArr[Convert.ToInt32(pbImg6.Tag)];
            tlpIcons.Controls[6].BackgroundImage = imageArr[Convert.ToInt32(pbImg7.Tag)];
            tlpIcons.Controls[7].BackgroundImage = imageArr[Convert.ToInt32(pbImg8.Tag)];
            tlpIcons.Controls[8].BackgroundImage = imageArr[Convert.ToInt32(pbImg9.Tag)];
            tlpIcons.Controls[9].BackgroundImage = imageArr[Convert.ToInt32(pbImg10.Tag)];
            tlpIcons.Controls[10].BackgroundImage = imageArr[Convert.ToInt32(pbImg11.Tag)];
            tlpIcons.Controls[11].BackgroundImage = imageArr[Convert.ToInt32(pbImg12.Tag)];
            tlpIcons.Controls[12].BackgroundImage = imageArr[Convert.ToInt32(pbImg13.Tag)];
            tlpIcons.Controls[13].BackgroundImage = imageArr[Convert.ToInt32(pbImg14.Tag)];
            tlpIcons.Controls[14].BackgroundImage = imageArr[Convert.ToInt32(pbImg15.Tag)];
            tlpIcons.Controls[15].BackgroundImage = imageArr[Convert.ToInt32(pbImg16.Tag)];
            #endregion //enclosed in region to reduce clutter 
            startTimer.Enabled = true;
            btnStart.Enabled = false;
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            
            ms--;
            if (ms == 0)
            {
                ms = 6;
                ss--;

                if (ss == 0)
                {
                    startTimer.Enabled = false;
                    gameTimer.Enabled = true;
                    lblTime.Visible = false;
                    for (int i = 0; i < 16; i++) //Resets all images and enables pictureboxes
                    {
                        tlpIcons.Controls[i].BackgroundImage = null;
                        tlpIcons.Controls[i].Enabled = true;
                    }
                }
            }

            lblTime.Text = ss + ":" + ms;

            
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Handles the milliseconds and seconds contained within the label for time
            ms--;
            if (ms == 0)
            {
                ms = 0;
                ss--;
            }

            lblTime.Text = ss + ":" + ms;

        }

        private void delay()//Delays everything by a certain number of milliseconds
        {
            delayTimer.Enabled = true;

            delayTimer.Tick += (s, e) => { delayTimer.Enabled = false; };

            while (delayTimer.Enabled)
                Application.DoEvents();
        }

        private void calculateScore()
        {
            switch (incorrectGuesses)
            {
                case int n when (n == 0):
                    sleepScore = 5;
                    break;
                case int n when (n > 0 && n < 3):
                    sleepScore = 4;
                    break;
                case int n when (n > 2 && n < 7):
                    sleepScore = 3;
                    break;
                case int n when (n > 6 && n < 15):
                    sleepScore = 2;
                    break;
                case int n when (n >= 15):
                    sleepScore = 9;
                    break;
            }
        }

        /*All click events show the image contained in each picturebox, and sends a reference of the picturebox to 
         the checkMatch method to check if the tags of two pictureboxes clicked matches*/
        private void pbImg1_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[0].BackgroundImage = imageArr[Convert.ToInt32(pbImg1.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }

        private void pbImg2_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[1].BackgroundImage = imageArr[Convert.ToInt32(pbImg2.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }
        private void pbImg3_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[2].BackgroundImage = imageArr[Convert.ToInt32(pbImg3.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }
        #region Remaining Click Events
        private void pbImg4_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[3].BackgroundImage = imageArr[Convert.ToInt32(pbImg4.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }

        private void pbImg5_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[4].BackgroundImage = imageArr[Convert.ToInt32(pbImg5.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }

        private void pbImg6_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[5].BackgroundImage = imageArr[Convert.ToInt32(pbImg6.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }

        private void pbImg7_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[6].BackgroundImage = imageArr[Convert.ToInt32(pbImg7.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }

        private void pbImg8_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[7].BackgroundImage = imageArr[Convert.ToInt32(pbImg8.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }

        private void pbImg9_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[8].BackgroundImage = imageArr[Convert.ToInt32(pbImg9.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }

        private void pbImg10_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[9].BackgroundImage = imageArr[Convert.ToInt32(pbImg10.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }

        private void pbImg11_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[10].BackgroundImage = imageArr[Convert.ToInt32(pbImg11.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }

        private void pbImg12_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[11].BackgroundImage = imageArr[Convert.ToInt32(pbImg12.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }

        private void pbImg13_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[12].BackgroundImage = imageArr[Convert.ToInt32(pbImg13.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }

        private void pbImg14_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[13].BackgroundImage = imageArr[Convert.ToInt32(pbImg14.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }



        private void pbImg15_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[14].BackgroundImage = imageArr[Convert.ToInt32(pbImg15.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }

        private void pbImg16_Click(object sender, EventArgs e)
        {
            tlpIcons.Controls[15].BackgroundImage = imageArr[Convert.ToInt32(pbImg16.Tag)];
            PictureBox clickedBox = sender as PictureBox;
            checkMatch(clickedBox);
        }

        #endregion


    }
}
