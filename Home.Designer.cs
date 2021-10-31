
namespace INF164HWAss1
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.OpenFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMemory = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.btnArcade = new System.Windows.Forms.Button();
            this.ArcadeFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.SleepFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.LibraryFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.pgbHappinessBar = new System.Windows.Forms.ProgressBar();
            this.HappinessBarTimer = new System.Windows.Forms.Timer(this.components);
            this.lblHappyLevel = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnArcade2 = new System.Windows.Forms.Button();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbGIF2 = new System.Windows.Forms.PictureBox();
            this.pbChickGIF = new System.Windows.Forms.PictureBox();
            this.pbMood = new System.Windows.Forms.PictureBox();
            this.lblCoins = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblIntelligenceScore = new System.Windows.Forms.Label();
            this.lblSleepScore = new System.Windows.Forms.Label();
            this.pbBackBottom = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pbWizzard = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGIF2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChickGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWizzard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
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
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(894, 404);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 33);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMemory
            // 
            this.btnMemory.BackColor = System.Drawing.Color.DarkCyan;
            this.btnMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemory.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemory.ForeColor = System.Drawing.Color.White;
            this.btnMemory.Location = new System.Drawing.Point(792, 123);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(217, 42);
            this.btnMemory.TabIndex = 1;
            this.btnMemory.Text = "Memory";
            this.btnMemory.UseVisualStyleBackColor = false;
            this.btnMemory.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackColor = System.Drawing.Color.DarkCyan;
            this.btnLibrary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.ForeColor = System.Drawing.Color.White;
            this.btnLibrary.Location = new System.Drawing.Point(792, 32);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(217, 42);
            this.btnLibrary.TabIndex = 2;
            this.btnLibrary.Text = "Library";
            this.btnLibrary.UseVisualStyleBackColor = false;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // btnArcade
            // 
            this.btnArcade.BackColor = System.Drawing.Color.DarkCyan;
            this.btnArcade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArcade.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArcade.ForeColor = System.Drawing.Color.White;
            this.btnArcade.Location = new System.Drawing.Point(792, 210);
            this.btnArcade.Name = "btnArcade";
            this.btnArcade.Size = new System.Drawing.Size(217, 42);
            this.btnArcade.TabIndex = 3;
            this.btnArcade.Text = "Arcade";
            this.btnArcade.UseVisualStyleBackColor = false;
            this.btnArcade.Click += new System.EventHandler(this.btnArcade_Click);
            // 
            // ArcadeFadeTimer
            // 
            this.ArcadeFadeTimer.Interval = 10;
            this.ArcadeFadeTimer.Tick += new System.EventHandler(this.ArcadeFadeTimer_Tick);
            // 
            // SleepFadeTimer
            // 
            this.SleepFadeTimer.Interval = 10;
            this.SleepFadeTimer.Tick += new System.EventHandler(this.SleepFadeTimer_Tick);
            // 
            // LibraryFadeTimer
            // 
            this.LibraryFadeTimer.Interval = 10;
            this.LibraryFadeTimer.Tick += new System.EventHandler(this.LibraryFadeTimer_Tick);
            // 
            // pgbHappinessBar
            // 
            this.pgbHappinessBar.BackColor = System.Drawing.Color.LightBlue;
            this.pgbHappinessBar.Location = new System.Drawing.Point(12, 355);
            this.pgbHappinessBar.Name = "pgbHappinessBar";
            this.pgbHappinessBar.Size = new System.Drawing.Size(252, 20);
            this.pgbHappinessBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbHappinessBar.TabIndex = 6;
            // 
            // HappinessBarTimer
            // 
            this.HappinessBarTimer.Interval = 25;
            this.HappinessBarTimer.Tick += new System.EventHandler(this.HappinessBarTimer_Tick);
            // 
            // lblHappyLevel
            // 
            this.lblHappyLevel.AutoSize = true;
            this.lblHappyLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblHappyLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHappyLevel.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHappyLevel.ForeColor = System.Drawing.Color.White;
            this.lblHappyLevel.Location = new System.Drawing.Point(42, 325);
            this.lblHappyLevel.Name = "lblHappyLevel";
            this.lblHappyLevel.Size = new System.Drawing.Size(192, 25);
            this.lblHappyLevel.TabIndex = 7;
            this.lblHappyLevel.Text = "Happiness Meter";
            this.lblHappyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(380, 4);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(259, 60);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Mametchi";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnArcade2
            // 
            this.btnArcade2.BackColor = System.Drawing.Color.DarkCyan;
            this.btnArcade2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArcade2.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArcade2.ForeColor = System.Drawing.Color.White;
            this.btnArcade2.Location = new System.Drawing.Point(792, 295);
            this.btnArcade2.Name = "btnArcade2";
            this.btnArcade2.Size = new System.Drawing.Size(217, 42);
            this.btnArcade2.TabIndex = 76;
            this.btnArcade2.Text = "Arcade 2";
            this.btnArcade2.UseVisualStyleBackColor = false;
            this.btnArcade2.Click += new System.EventHandler(this.btnArcade2_Click);
            // 
            // pbBackground
            // 
            this.pbBackground.BackColor = System.Drawing.Color.Transparent;
            this.pbBackground.Image = global::INF164HWAss1.Properties.Resources.Background_Moving_Pic;
            this.pbBackground.Location = new System.Drawing.Point(0, -1);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(1022, 384);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBackground.TabIndex = 77;
            this.pbBackground.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::INF164HWAss1.Properties.Resources.maskdudeIdleLeft;
            this.pictureBox2.Location = new System.Drawing.Point(959, 252);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::INF164HWAss1.Properties.Resources.coin;
            this.pictureBox1.Location = new System.Drawing.Point(11, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // pbGIF2
            // 
            this.pbGIF2.BackColor = System.Drawing.Color.Transparent;
            this.pbGIF2.Image = global::INF164HWAss1.Properties.Resources.GIfBoigif;
            this.pbGIF2.Location = new System.Drawing.Point(882, 80);
            this.pbGIF2.Name = "pbGIF2";
            this.pbGIF2.Size = new System.Drawing.Size(38, 39);
            this.pbGIF2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGIF2.TabIndex = 70;
            this.pbGIF2.TabStop = false;
            // 
            // pbChickGIF
            // 
            this.pbChickGIF.BackColor = System.Drawing.Color.Transparent;
            this.pbChickGIF.Image = global::INF164HWAss1.Properties.Resources.Chick;
            this.pbChickGIF.Location = new System.Drawing.Point(585, 67);
            this.pbChickGIF.Name = "pbChickGIF";
            this.pbChickGIF.Size = new System.Drawing.Size(54, 51);
            this.pbChickGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbChickGIF.TabIndex = 69;
            this.pbChickGIF.TabStop = false;
            // 
            // pbMood
            // 
            this.pbMood.BackColor = System.Drawing.Color.Transparent;
            this.pbMood.Image = global::INF164HWAss1.Properties.Resources.Nutral_face;
            this.pbMood.Location = new System.Drawing.Point(409, 92);
            this.pbMood.Name = "pbMood";
            this.pbMood.Size = new System.Drawing.Size(197, 254);
            this.pbMood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMood.TabIndex = 4;
            this.pbMood.TabStop = false;
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.BackColor = System.Drawing.Color.Transparent;
            this.lblCoins.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.Color.Yellow;
            this.lblCoins.Location = new System.Drawing.Point(49, 13);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(25, 25);
            this.lblCoins.TabIndex = 78;
            this.lblCoins.Text = "0";
            this.lblCoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::INF164HWAss1.Properties.Resources.SleepScore;
            this.pictureBox3.Location = new System.Drawing.Point(85, 256);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(48, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 79;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::INF164HWAss1.Properties.Resources.SmartScore;
            this.pictureBox4.Location = new System.Drawing.Point(9, 90);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 51);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 80;
            this.pictureBox4.TabStop = false;
            // 
            // lblIntelligenceScore
            // 
            this.lblIntelligenceScore.AutoSize = true;
            this.lblIntelligenceScore.BackColor = System.Drawing.Color.Transparent;
            this.lblIntelligenceScore.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntelligenceScore.ForeColor = System.Drawing.Color.Cyan;
            this.lblIntelligenceScore.Location = new System.Drawing.Point(52, 103);
            this.lblIntelligenceScore.Name = "lblIntelligenceScore";
            this.lblIntelligenceScore.Size = new System.Drawing.Size(25, 25);
            this.lblIntelligenceScore.TabIndex = 81;
            this.lblIntelligenceScore.Text = "0";
            this.lblIntelligenceScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSleepScore
            // 
            this.lblSleepScore.AutoSize = true;
            this.lblSleepScore.BackColor = System.Drawing.Color.Transparent;
            this.lblSleepScore.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSleepScore.ForeColor = System.Drawing.Color.White;
            this.lblSleepScore.Location = new System.Drawing.Point(51, 60);
            this.lblSleepScore.Name = "lblSleepScore";
            this.lblSleepScore.Size = new System.Drawing.Size(25, 25);
            this.lblSleepScore.TabIndex = 82;
            this.lblSleepScore.Tag = "";
            this.lblSleepScore.Text = "0";
            this.lblSleepScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbBackBottom
            // 
            this.pbBackBottom.BackColor = System.Drawing.Color.Transparent;
            this.pbBackBottom.Image = global::INF164HWAss1.Properties.Resources.Pic3;
            this.pbBackBottom.Location = new System.Drawing.Point(0, 389);
            this.pbBackBottom.Name = "pbBackBottom";
            this.pbBackBottom.Size = new System.Drawing.Size(1022, 54);
            this.pbBackBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBackBottom.TabIndex = 83;
            this.pbBackBottom.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::INF164HWAss1.Properties.Resources.Star;
            this.pictureBox5.Location = new System.Drawing.Point(115, 280);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 42);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 84;
            this.pictureBox5.TabStop = false;
            // 
            // pbWizzard
            // 
            this.pbWizzard.BackColor = System.Drawing.Color.Transparent;
            this.pbWizzard.Image = global::INF164HWAss1.Properties.Resources.Toaddude;
            this.pbWizzard.Location = new System.Drawing.Point(792, 162);
            this.pbWizzard.Name = "pbWizzard";
            this.pbWizzard.Size = new System.Drawing.Size(55, 56);
            this.pbWizzard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWizzard.TabIndex = 85;
            this.pbWizzard.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::INF164HWAss1.Properties.Resources.memory;
            this.pictureBox6.Location = new System.Drawing.Point(3, 47);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(53, 44);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 86;
            this.pictureBox6.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::INF164HWAss1.Properties.Resources.Background_Moving_Pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1021, 442);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.btnMemory);
            this.Controls.Add(this.btnArcade);
            this.Controls.Add(this.pbWizzard);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pbGIF2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbBackBottom);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblSleepScore);
            this.Controls.Add(this.lblIntelligenceScore);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.btnArcade2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbChickGIF);
            this.Controls.Add(this.lblHappyLevel);
            this.Controls.Add(this.pgbHappinessBar);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbMood);
            this.Controls.Add(this.btnLibrary);
            this.Controls.Add(this.pbBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGIF2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChickGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWizzard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer OpenFadeTimer;
        private System.Windows.Forms.Timer CloseFadeTimer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMemory;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Button btnArcade;
        private System.Windows.Forms.PictureBox pbMood;
        private System.Windows.Forms.Timer ArcadeFadeTimer;
        private System.Windows.Forms.Timer SleepFadeTimer;
        private System.Windows.Forms.Timer LibraryFadeTimer;
        private System.Windows.Forms.ProgressBar pgbHappinessBar;
        private System.Windows.Forms.Timer HappinessBarTimer;
        private System.Windows.Forms.Label lblHappyLevel;
        private System.Windows.Forms.PictureBox pbChickGIF;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.PictureBox pbGIF2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnArcade2;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblIntelligenceScore;
        private System.Windows.Forms.Label lblSleepScore;
        private System.Windows.Forms.PictureBox pbBackBottom;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pbWizzard;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}