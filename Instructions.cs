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
    public partial class frmInstructions : Form
    {
        public frmInstructions()
        {
            InitializeComponent();

            btnBack.Enabled = false;

            Opacity = 0;
            OpenFadeTimer.Start();

            //load the instructions from rich text file
            rtbInstructions.LoadFile("Instructions.rtf");
            InstructionLine = rtbInstructions.Lines;
            rtbInstructions.Text = "______________________Press Space Bar_____________________\n\n";
        }

        //Declare variables
        int i = 0;
        string[] InstructionLine;
        int j = 0;
        char[] charArr;
        string line, buffer;
        bool running = false;
        int k = 0;
        int g = 0;
        bool completed = false;

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

        private void rtbInstructions_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                //Removes the ding when enter is pressed
                e.Handled = true;

                if(g == 0)
                {
                    running = true;
                    g++;
                }

                if (completed == true)
                {
                    g = 0;
                    completed = false;
                }

                if (i <= InstructionLine.Length - 1)
                {
                    if (running == true)
                    {
                        running = false;
                        WriteLine();
                        rtbInstructions.AppendText("\n");
                        i++;
                    }
                }
                else
                {
                    switch (j)
                    {
                        case 0:
                            rtbInstructions.AppendText("Stop\n");

                            MessageBox.Show("Please leave me alone. :(", "Stop it!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            break;
                    }
                }
            }
        }
        private void WriteLine()
        {
            line = InstructionLine[i];
            charArr = line.ToCharArray();

            for (k = 0; k < charArr.Length; k++)
            {
                buffer = Convert.ToString(charArr[k]);
                rtbInstructions.AppendText(buffer);
                Task.Delay(750).Wait(75);

                if(k == charArr.Length-1)
                    completed = true;
            }
            rtbInstructions.Focus();
        }
    }
}

