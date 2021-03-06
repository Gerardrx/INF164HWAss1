using System;
using System.Drawing;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class frmInstructions : Form
    {

        //private variables
        private int i = 0;
        private int k = 0;
        private string[] InstructionLine;
        private string line;
        private string buffer;
        private char[] charArr;
        private bool typing = false;

        public frmInstructions()
        {
            InitializeComponent();

            btnBack.Enabled = false;

            Opacity = 0;
            OpenFadeTimer.Start();

            //load the instructions from rich text file
            rtbInstructions.LoadFile("Instructions.rtf");
            InstructionLine = rtbInstructions.Lines;
            rtbInstructions.Text = "_______________Press Space Bar________________\n";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CloseFadeTimer.Start();
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

                if (i <= InstructionLine.Length - 1)
                {
                    if (typing == false)
                    {
                        WriteLine();
                        rtbInstructions.AppendText("\n");
                        i++;
                    }
                    else
                    {
                        TypeTimer.Stop();
                        rtbInstructions.AppendText(toEnd());
                        typing = false;
                    }

                }
            }
        }

        private void WriteLine()
        {
            line = InstructionLine[i];
            charArr = line.ToCharArray();

            TypeTimer.Start();
            typing = true;
            k = 0;

        }

        private void TypeTimer_Tick(object sender, EventArgs e) //type out words from txt file
        {
            if (k < charArr.Length)
            {
                buffer = Convert.ToString(charArr[k]);
                rtbInstructions.AppendText(buffer);
                rtbInstructions.Focus();
                k++;
            }
            else
            {
                TypeTimer.Stop();
                typing = false;
            }

        }

        private String toEnd() //if press then jump to end of line
        {
            string temp = "";
            for (int j = k; j < charArr.Length; j++)
            {
                temp += charArr[j];
            }

            return temp;
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
            }
            Opacity -= 0.03;
        }
    }
}

