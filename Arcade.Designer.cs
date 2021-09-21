
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
            this.OpenFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pbHearts = new System.Windows.Forms.PictureBox();
            this.pbClickMe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClickMe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(808, 17);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(183, 65);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 840;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.Location = new System.Drawing.Point(16, 14);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(130, 33);
            this.lblCoins.TabIndex = 3;
            this.lblCoins.Text = "Coins: 0";
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.Font = new System.Drawing.Font("Goudy Stout", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplier.Location = new System.Drawing.Point(1029, 25);
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
            this.lblBorder.Size = new System.Drawing.Size(81, 83);
            this.lblBorder.TabIndex = 6;
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
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(264, 17);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(183, 65);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1016, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(261, 65);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close Temporary";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pbHearts
            // 
            this.pbHearts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHearts.Image = global::INF164HWAss1.Properties.Resources.heart_3;
            this.pbHearts.Location = new System.Drawing.Point(490, 12);
            this.pbHearts.Name = "pbHearts";
            this.pbHearts.Size = new System.Drawing.Size(240, 78);
            this.pbHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHearts.TabIndex = 4;
            this.pbHearts.TabStop = false;
            // 
            // pbClickMe
            // 
            this.pbClickMe.BackColor = System.Drawing.Color.Transparent;
            this.pbClickMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbClickMe.Image = global::INF164HWAss1.Properties.Resources.DogNose;
            this.pbClickMe.Location = new System.Drawing.Point(830, 523);
            this.pbClickMe.Name = "pbClickMe";
            this.pbClickMe.Size = new System.Drawing.Size(75, 75);
            this.pbClickMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClickMe.TabIndex = 1;
            this.pbClickMe.TabStop = false;
            this.pbClickMe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbClickMe_MouseDown);
            // 
            // Arcade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1290, 878);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMultiplier);
            this.Controls.Add(this.pbHearts);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbClickMe);
            this.Controls.Add(this.lblBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Button button1;
    }
}