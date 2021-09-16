
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arcade));
            this.btnStart = new System.Windows.Forms.Button();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblMultiplier = new System.Windows.Forms.Label();
            this.lblBorder = new System.Windows.Forms.Label();
            this.pbHearts = new System.Windows.Forms.PictureBox();
            this.pbClickMe = new System.Windows.Forms.PictureBox();
            this.OpenFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClickMe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(539, 11);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 42);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 850;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.Location = new System.Drawing.Point(11, 9);
            this.lblCoins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(82, 25);
            this.lblCoins.TabIndex = 3;
            this.lblCoins.Text = "Coins: 0";
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Font = new System.Drawing.Font("Goudy Stout", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplier.Location = new System.Drawing.Point(686, 16);
            this.lblMultiplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(165, 44);
            this.lblMultiplier.TabIndex = 5;
            this.lblMultiplier.Text = "X1000";
            // 
            // lblBorder
            // 
            this.lblBorder.BackColor = System.Drawing.Color.Lime;
            this.lblBorder.Location = new System.Drawing.Point(550, 337);
            this.lblBorder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(53, 52);
            this.lblBorder.TabIndex = 6;
            // 
            // pbHearts
            // 
            this.pbHearts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHearts.Image = global::INF164HWAss1.Properties.Resources.heart_3;
            this.pbHearts.Location = new System.Drawing.Point(327, 8);
            this.pbHearts.Margin = new System.Windows.Forms.Padding(2);
            this.pbHearts.Name = "pbHearts";
            this.pbHearts.Size = new System.Drawing.Size(160, 51);
            this.pbHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHearts.TabIndex = 4;
            this.pbHearts.TabStop = false;
            // 
            // pbClickMe
            // 
            this.pbClickMe.BackColor = System.Drawing.Color.Transparent;
            this.pbClickMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbClickMe.Image = global::INF164HWAss1.Properties.Resources.bicMan;
            this.pbClickMe.Location = new System.Drawing.Point(553, 340);
            this.pbClickMe.Margin = new System.Windows.Forms.Padding(2);
            this.pbClickMe.Name = "pbClickMe";
            this.pbClickMe.Size = new System.Drawing.Size(50, 49);
            this.pbClickMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClickMe.TabIndex = 1;
            this.pbClickMe.TabStop = false;
            this.pbClickMe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbClickMe_MouseDown);
            // 
            // OpenFadeTimer
            // 
            this.OpenFadeTimer.Interval = 10;
            this.OpenFadeTimer.Tick += new System.EventHandler(this.OpenFadeTimer_Tick);
            // 
            // CloseFadeTimer
            // 
            this.CloseFadeTimer.Interval = 10;
            this.CloseFadeTimer.Tick += new System.EventHandler(this.CloseFadeTimer_Tick);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(176, 11);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 42);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Arcade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(860, 571);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMultiplier);
            this.Controls.Add(this.pbHearts);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbClickMe);
            this.Controls.Add(this.lblBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Arcade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arcade";
            ((System.ComponentModel.ISupportInitialize)(this.pbHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClickMe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClickMe;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox pbHearts;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.Label lblBorder;
        private System.Windows.Forms.Timer OpenFadeTimer;
        private System.Windows.Forms.Timer CloseFadeTimer;
        private System.Windows.Forms.Button btnBack;
    }
}