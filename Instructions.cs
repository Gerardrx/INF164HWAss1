﻿using System;
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
    public partial class frmInstructions : Form
    {
        public frmInstructions()
        {
            InitializeComponent();

            Opacity = 0;
            OpenFadeTimer.Start();

            //load the instructions from rich text file
            rtbInstructions.LoadFile("Instructions.rtf");
            InstructionLine = rtbInstructions.Lines;
            rtbInstructions.Clear();
        }

        //Declare variables
        int i = 0;
        string[] InstructionLine;
        int j = 0;

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
            }
            Opacity += 0.03;
        }

        private void CloseFadeTimer_Tick(object sender, EventArgs e)
        {
            //Fade out the form
            if (Opacity == 0)
            {
                CloseFadeTimer.Stop();

                this.Hide();

                //open new menu form
                frmMenu mm = new frmMenu();
                mm.Visible = true;
            }
            Opacity -= 0.03;
        }

        private void frmInstructions_Load(object sender, EventArgs e)
        {
            this.BackColor = ColorTranslator.FromHtml("#66ceef");
        }

        private void rtbInstructions_Click(object sender, EventArgs e)
        {
            if (i <= InstructionLine.Length-1)
            {
                rtbInstructions.AppendText(InstructionLine[i] + "\n");
                i++;
            }
            else
            {
                switch(j)
                {
                    case 0:
                        rtbInstructions.AppendText("Hey, I can't tell you any more!\n");
                        break;

                    case 1:
                        rtbInstructions.AppendText("Google it, I don't know.\n");
                        break;

                    case 2:
                        rtbInstructions.AppendText("I told you I don't know.\n");
                        break;

                    case 3:
                        rtbInstructions.AppendText("I wouldn't do that if I was you.\n");
                        break;

                    case 4:
                        rtbInstructions.AppendText("Stop that!\n");
                        break;

                    case 5:
                        rtbInstructions.AppendText("-911, what's your emergency?-\n");
                        break;

                    case 6:
                        rtbInstructions.AppendText("This person won't stop clicking me\n");
                        break;

                    case 7:
                        rtbInstructions.AppendText("-Sir we are sending help, please be patient.\n");
                        break;

                    case 8:
                        rtbInstructions.AppendText("The police are on their way!\n");
                        break;

                    case 9:
                        rtbInstructions.AppendText("Violet, do you have a vissual?\n");
                        break;

                    case 10:
                        rtbInstructions.AppendText("Rodger. Permission to fire?\n");
                        break;

                    case 11:
                        rtbInstructions.AppendText("Take out the suspect!\n");
                        MessageBox.Show("Tango Down", "RIP User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                        break;
                }
                j++;
            }
        }
    }
}

