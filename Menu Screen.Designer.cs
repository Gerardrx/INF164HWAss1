
namespace INF164HWAss1
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.CloseFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.OpenFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.btnPlay = new System.Windows.Forms.Button();
            this.InstructionsFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.HomeFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblTimeA = new System.Windows.Forms.Label();
            this.ClockTimer = new System.Windows.Forms.Timer(this.components);
            this.pbPic = new System.Windows.Forms.PictureBox();
            this.pbDogThingGIF = new System.Windows.Forms.PictureBox();
            this.pbExtraPic = new System.Windows.Forms.PictureBox();
            this.pbWelcomeGIF = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pbmanbic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogThingGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtraPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcomeGIF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmanbic)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTitle.Font = new System.Drawing.Font("Unispace", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(4, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(317, 60);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Tamagotchi";
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructions.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInstructions.ForeColor = System.Drawing.Color.White;
            this.btnInstructions.Location = new System.Drawing.Point(96, 167);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(150, 42);
            this.btnInstructions.TabIndex = 2;
            this.btnInstructions.Text = "Instructions";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Aqua;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(96, 236);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 42);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CloseFadeTimer
            // 
            this.CloseFadeTimer.Interval = 10;
            this.CloseFadeTimer.Tick += new System.EventHandler(this.CloseFadeTimer_Tick);
            // 
            // OpenFadeTimer
            // 
            this.OpenFadeTimer.Interval = 10;
            this.OpenFadeTimer.Tick += new System.EventHandler(this.OpenFadeTimer_Tick);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Teal;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(96, 94);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(150, 42);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // InstructionsFadeTimer
            // 
            this.InstructionsFadeTimer.Interval = 10;
            this.InstructionsFadeTimer.Tick += new System.EventHandler(this.InstructionsFadeTimer_Tick);
            // 
            // HomeFadeTimer
            // 
            this.HomeFadeTimer.Interval = 10;
            this.HomeFadeTimer.Tick += new System.EventHandler(this.HomeFadeTimer_Tick);
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lblSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSeconds.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeconds.ForeColor = System.Drawing.Color.White;
            this.lblSeconds.Location = new System.Drawing.Point(1153, 24);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(38, 30);
            this.lblSeconds.TabIndex = 67;
            this.lblSeconds.Text = "00";
            // 
            // lblTimeA
            // 
            this.lblTimeA.AutoSize = true;
            this.lblTimeA.BackColor = System.Drawing.Color.Transparent;
            this.lblTimeA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimeA.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeA.ForeColor = System.Drawing.Color.White;
            this.lblTimeA.Location = new System.Drawing.Point(1056, 9);
            this.lblTimeA.Name = "lblTimeA";
            this.lblTimeA.Size = new System.Drawing.Size(102, 45);
            this.lblTimeA.TabIndex = 66;
            this.lblTimeA.Text = "00:00";
            // 
            // ClockTimer
            // 
            this.ClockTimer.Interval = 10;
            this.ClockTimer.Tick += new System.EventHandler(this.ClockTimer_Tick);
            // 
            // pbPic
            // 
            this.pbPic.BackColor = System.Drawing.Color.Transparent;
            this.pbPic.Image = global::INF164HWAss1.Properties.Resources.Toaddude1;
            this.pbPic.Location = new System.Drawing.Point(497, 388);
            this.pbPic.Name = "pbPic";
            this.pbPic.Size = new System.Drawing.Size(75, 64);
            this.pbPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPic.TabIndex = 70;
            this.pbPic.TabStop = false;
            // 
            // pbDogThingGIF
            // 
            this.pbDogThingGIF.BackColor = System.Drawing.Color.Transparent;
            this.pbDogThingGIF.Image = global::INF164HWAss1.Properties.Resources.DogThing;
            this.pbDogThingGIF.Location = new System.Drawing.Point(1080, 393);
            this.pbDogThingGIF.Name = "pbDogThingGIF";
            this.pbDogThingGIF.Size = new System.Drawing.Size(108, 120);
            this.pbDogThingGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDogThingGIF.TabIndex = 68;
            this.pbDogThingGIF.TabStop = false;
            // 
            // pbExtraPic
            // 
            this.pbExtraPic.BackColor = System.Drawing.Color.Transparent;
            this.pbExtraPic.Image = global::INF164HWAss1.Properties.Resources.MenuExtraPic;
            this.pbExtraPic.Location = new System.Drawing.Point(245, 348);
            this.pbExtraPic.Name = "pbExtraPic";
            this.pbExtraPic.Size = new System.Drawing.Size(162, 144);
            this.pbExtraPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbExtraPic.TabIndex = 5;
            this.pbExtraPic.TabStop = false;
            // 
            // pbWelcomeGIF
            // 
            this.pbWelcomeGIF.BackColor = System.Drawing.Color.Transparent;
            this.pbWelcomeGIF.Image = global::INF164HWAss1.Properties.Resources.WelcomWave;
            this.pbWelcomeGIF.Location = new System.Drawing.Point(747, 81);
            this.pbWelcomeGIF.Name = "pbWelcomeGIF";
            this.pbWelcomeGIF.Size = new System.Drawing.Size(267, 395);
            this.pbWelcomeGIF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWelcomeGIF.TabIndex = 4;
            this.pbWelcomeGIF.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.BackColor = System.Drawing.Color.Transparent;
            this.pbBackground.Image = global::INF164HWAss1.Properties.Resources.ezgif_7_f90bd2a4dbf9;
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(1214, 514);
            this.pbBackground.TabIndex = 69;
            this.pbBackground.TabStop = false;
            // 
            // pbmanbic
            // 
            this.pbmanbic.BackColor = System.Drawing.Color.Transparent;
            this.pbmanbic.Image = global::INF164HWAss1.Properties.Resources.maskdudeIdleRight;
            this.pbmanbic.Location = new System.Drawing.Point(555, 181);
            this.pbmanbic.Name = "pbmanbic";
            this.pbmanbic.Size = new System.Drawing.Size(33, 39);
            this.pbmanbic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbmanbic.TabIndex = 71;
            this.pbmanbic.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INF164HWAss1.Properties.Resources.ezgif_7_f90bd2a4dbf9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1200, 504);
            this.Controls.Add(this.pbmanbic);
            this.Controls.Add(this.pbPic);
            this.Controls.Add(this.pbDogThingGIF);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.lblTimeA);
            this.Controls.Add(this.pbExtraPic);
            this.Controls.Add(this.pbWelcomeGIF);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInstructions);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pbBackground);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pbPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDogThingGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbExtraPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWelcomeGIF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbmanbic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer CloseFadeTimer;
        private System.Windows.Forms.Timer OpenFadeTimer;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Timer InstructionsFadeTimer;
        private System.Windows.Forms.Timer HomeFadeTimer;
        private System.Windows.Forms.PictureBox pbWelcomeGIF;
        private System.Windows.Forms.PictureBox pbExtraPic;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblTimeA;
        private System.Windows.Forms.Timer ClockTimer;
        private System.Windows.Forms.PictureBox pbDogThingGIF;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbPic;
        private System.Windows.Forms.PictureBox pbmanbic;
    }
}

