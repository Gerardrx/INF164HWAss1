
namespace INF164HWAss1
{
    partial class Arcade
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbClickMe = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCoins = new System.Windows.Forms.Label();
            this.pbHearts = new System.Windows.Forms.PictureBox();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.lblBorder = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbClickMe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHearts)).BeginInit();
            this.SuspendLayout();
            // 
            // pbClickMe
            // 
            this.pbClickMe.BackColor = System.Drawing.Color.Transparent;
            this.pbClickMe.BackgroundImage = global::INF164HWAss1.Properties.Resources.bicMan;
            this.pbClickMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbClickMe.Location = new System.Drawing.Point(817, 518);
            this.pbClickMe.Name = "pbClickMe";
            this.pbClickMe.Size = new System.Drawing.Size(75, 75);
            this.pbClickMe.TabIndex = 1;
            this.pbClickMe.TabStop = false;
            this.pbClickMe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbClickMe_MouseDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(562, 744);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 51);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 850;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Goudy Stout", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.Location = new System.Drawing.Point(12, 33);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(186, 32);
            this.lblCoins.TabIndex = 3;
            this.lblCoins.Text = "Coins: 0";
            // 
            // pbHearts
            // 
            this.pbHearts.BackgroundImage = global::INF164HWAss1.Properties.Resources.heart_3;
            this.pbHearts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHearts.Location = new System.Drawing.Point(491, 12);
            this.pbHearts.Name = "pbHearts";
            this.pbHearts.Size = new System.Drawing.Size(240, 78);
            this.pbHearts.TabIndex = 4;
            this.pbHearts.TabStop = false;
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Font = new System.Drawing.Font("Goudy Stout", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplier.Location = new System.Drawing.Point(1029, 24);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(249, 66);
            this.lblMultiplier.TabIndex = 5;
            this.lblMultiplier.Text = "X1000";
            // 
            // lblBorder
            // 
            this.lblBorder.BackColor = System.Drawing.Color.Lime;
            this.lblBorder.Location = new System.Drawing.Point(825, 518);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(80, 80);
            this.lblBorder.TabIndex = 6;
            // 
            // Arcade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1290, 879);
            this.Controls.Add(this.lblMultiplier);
            this.Controls.Add(this.pbHearts);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbClickMe);
            this.Controls.Add(this.lblBorder);
            this.Name = "Arcade";
            this.Text = "Arcade";
            ((System.ComponentModel.ISupportInitialize)(this.pbClickMe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHearts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClickMe;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox pbHearts;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.Label lblBorder;
    }
}