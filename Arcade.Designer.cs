
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
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.OpenFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblWizz = new System.Windows.Forms.Label();
            this.gbStart = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pbSky = new System.Windows.Forms.PictureBox();
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.pbHealthLoss = new System.Windows.Forms.PictureBox();
            this.pbPoof = new System.Windows.Forms.PictureBox();
            this.pbCoin = new System.Windows.Forms.PictureBox();
            this.pbHearts = new System.Windows.Forms.PictureBox();
            this.pbFireBall = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pbClickMe = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblControls = new System.Windows.Forms.Label();
            this.pbKey = new System.Windows.Forms.PictureBox();
            this.wizzard1 = new INF164HWAss1.Wizzard();
            this.gbStart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHealthLoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFireBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClickMe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizzard1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 1;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
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
            this.btnBack.BackColor = System.Drawing.Color.DarkCyan;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(1091, 456);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(98, 33);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCoins
            // 
            this.lblCoins.AutoSize = true;
            this.lblCoins.BackColor = System.Drawing.Color.Transparent;
            this.lblCoins.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoins.ForeColor = System.Drawing.Color.Yellow;
            this.lblCoins.Location = new System.Drawing.Point(48, 17);
            this.lblCoins.Name = "lblCoins";
            this.lblCoins.Size = new System.Drawing.Size(25, 25);
            this.lblCoins.TabIndex = 84;
            this.lblCoins.Text = "0";
            this.lblCoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblHealth.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.White;
            this.lblHealth.Location = new System.Drawing.Point(517, 17);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(129, 19);
            this.lblHealth.TabIndex = 89;
            this.lblHealth.Text = "Heath Bar ->";
            this.lblHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWizz
            // 
            this.lblWizz.AutoSize = true;
            this.lblWizz.BackColor = System.Drawing.Color.Transparent;
            this.lblWizz.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWizz.ForeColor = System.Drawing.Color.White;
            this.lblWizz.Location = new System.Drawing.Point(981, 378);
            this.lblWizz.Name = "lblWizz";
            this.lblWizz.Size = new System.Drawing.Size(139, 19);
            this.lblWizz.TabIndex = 90;
            this.lblWizz.Text = "Crazy Wizzard";
            this.lblWizz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbStart
            // 
            this.gbStart.BackColor = System.Drawing.Color.Black;
            this.gbStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbStart.Controls.Add(this.label6);
            this.gbStart.Controls.Add(this.label5);
            this.gbStart.Controls.Add(this.label4);
            this.gbStart.Controls.Add(this.label3);
            this.gbStart.Controls.Add(this.btnStart);
            this.gbStart.Controls.Add(this.pbSky);
            this.gbStart.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStart.ForeColor = System.Drawing.Color.White;
            this.gbStart.Location = new System.Drawing.Point(113, 125);
            this.gbStart.Name = "gbStart";
            this.gbStart.Size = new System.Drawing.Size(306, 176);
            this.gbStart.TabIndex = 91;
            this.gbStart.TabStop = false;
            this.gbStart.Text = "Arcade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(10, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 15);
            this.label6.TabIndex = 95;
            this.label6.Text = "pop them. Each pop you earn a coin.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(10, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 15);
            this.label5.TabIndex = 94;
            this.label5.Text = "crazy wizzard. Click the pigeons to ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 15);
            this.label4.TabIndex = 93;
            this.label4.Text = "from delivering a message to the ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 15);
            this.label3.TabIndex = 92;
            this.label3.Text = "Help Mametchi stop the evil pigeons ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Teal;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(110, 128);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(88, 31);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pbSky
            // 
            this.pbSky.BackColor = System.Drawing.Color.Transparent;
            this.pbSky.BackgroundImage = global::INF164HWAss1.Properties.Resources.cf4154334c36bc1196b11d729c3a77d4;
            this.pbSky.Image = global::INF164HWAss1.Properties.Resources.cf4154334c36bc1196b11d729c3a77d4;
            this.pbSky.Location = new System.Drawing.Point(-9, 116);
            this.pbSky.Name = "pbSky";
            this.pbSky.Size = new System.Drawing.Size(329, 119);
            this.pbSky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSky.TabIndex = 96;
            this.pbSky.TabStop = false;
            // 
            // MoveTimer
            // 
            this.MoveTimer.Interval = 10;
            // 
            // pbHealthLoss
            // 
            this.pbHealthLoss.BackColor = System.Drawing.Color.Transparent;
            this.pbHealthLoss.Image = global::INF164HWAss1.Properties.Resources.output_onlinegiftools__1_;
            this.pbHealthLoss.Location = new System.Drawing.Point(629, 267);
            this.pbHealthLoss.Name = "pbHealthLoss";
            this.pbHealthLoss.Size = new System.Drawing.Size(160, 145);
            this.pbHealthLoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHealthLoss.TabIndex = 92;
            this.pbHealthLoss.TabStop = false;
            // 
            // pbPoof
            // 
            this.pbPoof.BackColor = System.Drawing.Color.Transparent;
            this.pbPoof.Image = global::INF164HWAss1.Properties.Resources.Poof_Effect;
            this.pbPoof.Location = new System.Drawing.Point(820, 159);
            this.pbPoof.Name = "pbPoof";
            this.pbPoof.Size = new System.Drawing.Size(97, 79);
            this.pbPoof.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPoof.TabIndex = 87;
            this.pbPoof.TabStop = false;
            // 
            // pbCoin
            // 
            this.pbCoin.BackColor = System.Drawing.Color.Transparent;
            this.pbCoin.Image = global::INF164HWAss1.Properties.Resources.coin;
            this.pbCoin.Location = new System.Drawing.Point(10, 8);
            this.pbCoin.Name = "pbCoin";
            this.pbCoin.Size = new System.Drawing.Size(39, 39);
            this.pbCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCoin.TabIndex = 83;
            this.pbCoin.TabStop = false;
            // 
            // pbHearts
            // 
            this.pbHearts.BackColor = System.Drawing.Color.Transparent;
            this.pbHearts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHearts.Image = global::INF164HWAss1.Properties.Resources.heart_3;
            this.pbHearts.Location = new System.Drawing.Point(652, 1);
            this.pbHearts.Margin = new System.Windows.Forms.Padding(2);
            this.pbHearts.Name = "pbHearts";
            this.pbHearts.Size = new System.Drawing.Size(151, 52);
            this.pbHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHearts.TabIndex = 4;
            this.pbHearts.TabStop = false;
            // 
            // pbFireBall
            // 
            this.pbFireBall.BackColor = System.Drawing.Color.Transparent;
            this.pbFireBall.Image = global::INF164HWAss1.Properties.Resources.Fire;
            this.pbFireBall.Location = new System.Drawing.Point(947, 304);
            this.pbFireBall.Name = "pbFireBall";
            this.pbFireBall.Size = new System.Drawing.Size(70, 68);
            this.pbFireBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFireBall.TabIndex = 93;
            this.pbFireBall.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbBackground.Image = global::INF164HWAss1.Properties.Resources.ezgif_3_18f8aee5b97c;
            this.pbBackground.Location = new System.Drawing.Point(0, 52);
            this.pbBackground.Margin = new System.Windows.Forms.Padding(2);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(1200, 504);
            this.pbBackground.TabIndex = 9;
            this.pbBackground.TabStop = false;
            // 
            // pbClickMe
            // 
            this.pbClickMe.BackColor = System.Drawing.Color.Transparent;
            this.pbClickMe.Image = global::INF164HWAss1.Properties.Resources.pidgion;
            this.pbClickMe.Location = new System.Drawing.Point(0, 64);
            this.pbClickMe.Name = "pbClickMe";
            this.pbClickMe.Size = new System.Drawing.Size(97, 79);
            this.pbClickMe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClickMe.TabIndex = 86;
            this.pbClickMe.TabStop = false;
            // 
            // lblControls
            // 
            this.lblControls.AutoSize = true;
            this.lblControls.BackColor = System.Drawing.Color.Transparent;
            this.lblControls.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls.ForeColor = System.Drawing.Color.White;
            this.lblControls.Location = new System.Drawing.Point(517, 136);
            this.lblControls.Name = "lblControls";
            this.lblControls.Size = new System.Drawing.Size(89, 19);
            this.lblControls.TabIndex = 95;
            this.lblControls.Text = "Controls";
            this.lblControls.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbKey
            // 
            this.pbKey.BackColor = System.Drawing.Color.Transparent;
            this.pbKey.Image = global::INF164HWAss1.Properties.Resources.output_onlinepngtools__1_;
            this.pbKey.Location = new System.Drawing.Point(820, 378);
            this.pbKey.Name = "pbKey";
            this.pbKey.Size = new System.Drawing.Size(129, 105);
            this.pbKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKey.TabIndex = 96;
            this.pbKey.TabStop = false;
            // 
            // wizzard1
            // 
            this.wizzard1.BackColor = System.Drawing.Color.Transparent;
            this.wizzard1.Image = global::INF164HWAss1.Properties.Resources.Toaddude;
            this.wizzard1.Location = new System.Drawing.Point(1020, 316);
            this.wizzard1.Name = "wizzard1";
            this.wizzard1.Size = new System.Drawing.Size(61, 62);
            this.wizzard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.wizzard1.TabIndex = 94;
            this.wizzard1.TabStop = false;
            this.wizzard1.YForce = 0;
            // 
            // Arcade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::INF164HWAss1.Properties.Resources.ezgif_3_18f8aee5b97c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 504);
            this.Controls.Add(this.pbKey);
            this.Controls.Add(this.lblControls);
            this.Controls.Add(this.wizzard1);
            this.Controls.Add(this.pbFireBall);
            this.Controls.Add(this.pbHealthLoss);
            this.Controls.Add(this.gbStart);
            this.Controls.Add(this.lblWizz);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.pbPoof);
            this.Controls.Add(this.pbClickMe);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.pbCoin);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pbHearts);
            this.Controls.Add(this.pbBackground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Arcade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arcade";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Arcade_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Arcade_KeyUp);
            this.gbStart.ResumeLayout(false);
            this.gbStart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHealthLoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPoof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFireBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClickMe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizzard1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pbHearts;
        private System.Windows.Forms.Timer OpenFadeTimer;
        private System.Windows.Forms.Timer CloseFadeTimer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox pbCoin;
        private System.Windows.Forms.PictureBox pbPoof;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblWizz;
        private System.Windows.Forms.GroupBox gbStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbSky;
        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.PictureBox pbHealthLoss;
        private System.Windows.Forms.PictureBox pbFireBall;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.PictureBox pbClickMe;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Wizzard wizzard1;
        private System.Windows.Forms.Label lblControls;
        private System.Windows.Forms.PictureBox pbKey;
    }
}