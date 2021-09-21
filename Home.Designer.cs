
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
            this.btnSleep = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.btnArcade = new System.Windows.Forms.Button();
            this.ArcadeFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.SleepFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.LibraryFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.pgbHappinessBar = new System.Windows.Forms.ProgressBar();
            this.HappinessBarTimer = new System.Windows.Forms.Timer(this.components);
            this.lblHappyLevel = new System.Windows.Forms.Label();
            this.pbMood = new System.Windows.Forms.PictureBox();
            this.pbChickGIF = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pbGIF2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pgbSleep = new System.Windows.Forms.ProgressBar();
            this.pgbLibrary = new System.Windows.Forms.ProgressBar();
            this.pgbArcade = new System.Windows.Forms.ProgressBar();
            this.SleepBarTimer = new System.Windows.Forms.Timer(this.components);
            this.ArcadeBarTimer = new System.Windows.Forms.Timer(this.components);
            this.LibraryBarTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbMood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChickGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGIF2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
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
            this.btnBack.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(848, 526);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 42);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.BackColor = System.Drawing.Color.Teal;
            this.btnSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSleep.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSleep.Location = new System.Drawing.Point(570, 77);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(217, 42);
            this.btnSleep.TabIndex = 1;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = false;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.Location = new System.Drawing.Point(570, 217);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(217, 42);
            this.btnLibrary.TabIndex = 2;
            this.btnLibrary.Text = "library";
            this.btnLibrary.UseVisualStyleBackColor = false;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // btnArcade
            // 
            this.btnArcade.BackColor = System.Drawing.Color.Aqua;
            this.btnArcade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArcade.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArcade.Location = new System.Drawing.Point(570, 351);
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
            this.pgbHappinessBar.Location = new System.Drawing.Point(44, 462);
            this.pgbHappinessBar.Name = "pgbHappinessBar";
            this.pgbHappinessBar.Size = new System.Drawing.Size(474, 31);
            this.pgbHappinessBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbHappinessBar.TabIndex = 6;
            // 
            // HappinessBarTimer
            // 
            this.HappinessBarTimer.Interval = 10;
            this.HappinessBarTimer.Tick += new System.EventHandler(this.HappinessBarTimer_Tick);
            // 
            // lblHappyLevel
            // 
            this.lblHappyLevel.AutoSize = true;
            this.lblHappyLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblHappyLevel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHappyLevel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHappyLevel.ForeColor = System.Drawing.Color.Black;
            this.lblHappyLevel.Location = new System.Drawing.Point(197, 429);
            this.lblHappyLevel.Name = "lblHappyLevel";
            this.lblHappyLevel.Size = new System.Drawing.Size(174, 30);
            this.lblHappyLevel.TabIndex = 7;
            this.lblHappyLevel.Text = "Happiness Meter";
            // 
            // pbMood
            // 
            this.pbMood.BackColor = System.Drawing.Color.Transparent;
            this.pbMood.Image = global::INF164HWAss1.Properties.Resources.Nutral_face;
            this.pbMood.Location = new System.Drawing.Point(44, 77);
            this.pbMood.Name = "pbMood";
            this.pbMood.Size = new System.Drawing.Size(474, 353);
            this.pbMood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMood.TabIndex = 4;
            this.pbMood.TabStop = false;
            // 
            // pbChickGIF
            // 
            this.pbChickGIF.BackColor = System.Drawing.Color.Transparent;
            this.pbChickGIF.Image = global::INF164HWAss1.Properties.Resources.Chick;
            this.pbChickGIF.Location = new System.Drawing.Point(873, -1);
            this.pbChickGIF.Name = "pbChickGIF";
            this.pbChickGIF.Size = new System.Drawing.Size(108, 120);
            this.pbChickGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbChickGIF.TabIndex = 69;
            this.pbChickGIF.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(162, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(246, 65);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Mametchi";
            // 
            // pbGIF2
            // 
            this.pbGIF2.BackColor = System.Drawing.Color.Transparent;
            this.pbGIF2.Image = global::INF164HWAss1.Properties.Resources.GIfBoigif;
            this.pbGIF2.Location = new System.Drawing.Point(378, 93);
            this.pbGIF2.Name = "pbGIF2";
            this.pbGIF2.Size = new System.Drawing.Size(83, 82);
            this.pbGIF2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGIF2.TabIndex = 70;
            this.pbGIF2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::INF164HWAss1.Properties.Resources.PlantBoi;
            this.pictureBox1.Location = new System.Drawing.Point(95, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::INF164HWAss1.Properties.Resources.PenguMan;
            this.pictureBox2.Location = new System.Drawing.Point(368, 359);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::INF164HWAss1.Properties.Resources.DogThing1;
            this.pictureBox5.Location = new System.Drawing.Point(146, 361);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(53, 65);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 75;
            this.pictureBox5.TabStop = false;
            // 
            // pgbSleep
            // 
            this.pgbSleep.Location = new System.Drawing.Point(570, 125);
            this.pgbSleep.Name = "pgbSleep";
            this.pgbSleep.Size = new System.Drawing.Size(217, 31);
            this.pgbSleep.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbSleep.TabIndex = 76;
            // 
            // pgbLibrary
            // 
            this.pgbLibrary.Location = new System.Drawing.Point(570, 265);
            this.pgbLibrary.Name = "pgbLibrary";
            this.pgbLibrary.Size = new System.Drawing.Size(217, 31);
            this.pgbLibrary.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbLibrary.TabIndex = 77;
            // 
            // pgbArcade
            // 
            this.pgbArcade.Location = new System.Drawing.Point(570, 399);
            this.pgbArcade.Name = "pgbArcade";
            this.pgbArcade.Size = new System.Drawing.Size(217, 31);
            this.pgbArcade.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbArcade.TabIndex = 78;
            // 
            // SleepBarTimer
            // 
            this.SleepBarTimer.Interval = 10;
            this.SleepBarTimer.Tick += new System.EventHandler(this.SleepBarTimer_Tick);
            // 
            // ArcadeBarTimer
            // 
            this.ArcadeBarTimer.Interval = 10;
            this.ArcadeBarTimer.Tick += new System.EventHandler(this.ArcadeBarTimer_Tick);
            // 
            // LibraryBarTimer
            // 
            this.LibraryBarTimer.Interval = 10;
            this.LibraryBarTimer.Tick += new System.EventHandler(this.LibraryBarTimer_Tick);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = global::INF164HWAss1.Properties.Resources.XgKCKen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 580);
            this.Controls.Add(this.pgbArcade);
            this.Controls.Add(this.pgbLibrary);
            this.Controls.Add(this.pgbSleep);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbGIF2);
            this.Controls.Add(this.pbChickGIF);
            this.Controls.Add(this.lblHappyLevel);
            this.Controls.Add(this.pgbHappinessBar);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pbMood);
            this.Controls.Add(this.btnArcade);
            this.Controls.Add(this.btnLibrary);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pbMood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbChickGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGIF2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer OpenFadeTimer;
        private System.Windows.Forms.Timer CloseFadeTimer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSleep;
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
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ProgressBar pgbSleep;
        private System.Windows.Forms.ProgressBar pgbLibrary;
        private System.Windows.Forms.ProgressBar pgbArcade;
        private System.Windows.Forms.Timer SleepBarTimer;
        private System.Windows.Forms.Timer ArcadeBarTimer;
        private System.Windows.Forms.Timer LibraryBarTimer;
    }
}