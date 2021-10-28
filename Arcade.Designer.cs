
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
            this.OpenFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblBorder = new System.Windows.Forms.Label();
            this.pbClickMe = new System.Windows.Forms.PictureBox();
            this.pbHearts = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbClickMe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(294, 36);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(163, 52);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1000;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.BackColor = System.Drawing.Color.Transparent;
            this.lblCoins.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.Location = new System.Drawing.Point(14, 12);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(204, 45);
            this.lblCoins.TabIndex = 3;
            this.lblCoins.Text = "Coins: 0";
            // 
            // lblMultiplier
            // 
            this.lblMultiplier.AutoSize = true;
            this.lblMultiplier.BackColor = System.Drawing.Color.Transparent;
            this.lblMultiplier.Font = new System.Drawing.Font("Unispace", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultiplier.Location = new System.Drawing.Point(1241, 13);
            this.lblMultiplier.Name = "lblMultiplier";
            this.lblMultiplier.Size = new System.Drawing.Size(228, 77);
            this.lblMultiplier.TabIndex = 5;
            this.lblMultiplier.Text = "X1000";
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
            this.btnBack.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(995, 36);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(163, 52);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1237, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 52);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close Temporary";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lblBorder
            // 
            this.lblBorder.BackColor = System.Drawing.Color.Lime;
            this.lblBorder.Location = new System.Drawing.Point(636, 514);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(72, 67);
            this.lblBorder.TabIndex = 6;
            // 
            // pbClickMe
            // 
            this.pbClickMe.BackColor = System.Drawing.Color.Transparent;
            this.pbClickMe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbClickMe.Image = global::INF164HWAss1.Properties.Resources.ChickManWoman;
            this.pbClickMe.Location = new System.Drawing.Point(641, 521);
            this.pbClickMe.Name = "pbClickMe";
            this.pbClickMe.Size = new System.Drawing.Size(67, 60);
            this.pbClickMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClickMe.TabIndex = 1;
            this.pbClickMe.TabStop = false;
            this.pbClickMe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbClickMe_MouseDown);
            // 
            // pbHearts
            // 
            this.pbHearts.BackColor = System.Drawing.Color.Transparent;
            this.pbHearts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHearts.Image = global::INF164HWAss1.Properties.Resources.heart_3;
            this.pbHearts.Location = new System.Drawing.Point(560, 12);
            this.pbHearts.Name = "pbHearts";
            this.pbHearts.Size = new System.Drawing.Size(322, 98);
            this.pbHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHearts.TabIndex = 4;
            this.pbHearts.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbBackground.Image = global::INF164HWAss1.Properties.Resources.Tunnel;
            this.pbBackground.Location = new System.Drawing.Point(0, -3);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(1510, 1090);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBackground.TabIndex = 9;
            this.pbBackground.TabStop = false;
            // 
            // Arcade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1500, 1080);
            this.Controls.Add(this.pbClickMe);
            this.Controls.Add(this.lblBorder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMultiplier);
            this.Controls.Add(this.pbHearts);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbBackground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Arcade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arcade";
            ((System.ComponentModel.ISupportInitialize)(this.pbClickMe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox pbHearts;
        private System.Windows.Forms.Label lblMultiplier;
        private System.Windows.Forms.Timer OpenFadeTimer;
        private System.Windows.Forms.Timer CloseFadeTimer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Label lblBorder;
        private System.Windows.Forms.PictureBox pbClickMe;
    }
}