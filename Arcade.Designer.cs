
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
            this.lblCoins = new System.Windows.Forms.Label();
            this.lblWizz = new System.Windows.Forms.Label();
            this.MoveTimer = new System.Windows.Forms.Timer(this.components);
            this.pbHealthLoss = new System.Windows.Forms.PictureBox();
            this.pbCoin = new System.Windows.Forms.PictureBox();
            this.pbHearts = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.pbKeys1 = new System.Windows.Forms.PictureBox();
            this.SpawnTimer = new System.Windows.Forms.Timer(this.components);
            this.FireballTimer = new System.Windows.Forms.Timer(this.components);
            this.lblControls1 = new System.Windows.Forms.Label();
            this.pbKeys2 = new System.Windows.Forms.PictureBox();
            this.lblControls2 = new System.Windows.Forms.Label();
            this.pgbBufferTime = new System.Windows.Forms.ProgressBar();
            this.PoofTimer = new System.Windows.Forms.Timer(this.components);
            this.pbPressStart = new System.Windows.Forms.PictureBox();
            this.lblStartPress = new System.Windows.Forms.Label();
            this.wizzard1 = new INF164HWAss1.Wizzard();
            this.wall2 = new INF164HWAss1.Wall();
            this.wall1 = new INF164HWAss1.Wall();
            this.lblEcape = new System.Windows.Forms.Label();
            this.WizzardTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbHealthLoss)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHearts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKeys1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKeys2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPressStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizzard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).BeginInit();
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
            // lblWizz
            // 
            this.lblWizz.AutoSize = true;
            this.lblWizz.BackColor = System.Drawing.Color.Transparent;
            this.lblWizz.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWizz.ForeColor = System.Drawing.Color.White;
            this.lblWizz.Location = new System.Drawing.Point(1003, 398);
            this.lblWizz.Name = "lblWizz";
            this.lblWizz.Size = new System.Drawing.Size(111, 15);
            this.lblWizz.TabIndex = 90;
            this.lblWizz.Text = "Crazy Wizzard";
            this.lblWizz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWizz.Visible = false;
            // 
            // MoveTimer
            // 
            this.MoveTimer.Interval = 10;
            // 
            // pbHealthLoss
            // 
            this.pbHealthLoss.BackColor = System.Drawing.Color.Transparent;
            this.pbHealthLoss.Image = global::INF164HWAss1.Properties.Resources.output_onlinegiftools__1_;
            this.pbHealthLoss.Location = new System.Drawing.Point(1110, 252);
            this.pbHealthLoss.Name = "pbHealthLoss";
            this.pbHealthLoss.Size = new System.Drawing.Size(90, 91);
            this.pbHealthLoss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHealthLoss.TabIndex = 92;
            this.pbHealthLoss.TabStop = false;
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
            this.pbHearts.Location = new System.Drawing.Point(11, 433);
            this.pbHearts.Margin = new System.Windows.Forms.Padding(2);
            this.pbHearts.Name = "pbHearts";
            this.pbHearts.Size = new System.Drawing.Size(175, 68);
            this.pbHearts.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbHearts.TabIndex = 4;
            this.pbHearts.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbBackground.Image = global::INF164HWAss1.Properties.Resources.ezgif_3_18f8aee5b97c;
            this.pbBackground.Location = new System.Drawing.Point(0, 1);
            this.pbBackground.Margin = new System.Windows.Forms.Padding(2);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(1200, 504);
            this.pbBackground.TabIndex = 9;
            this.pbBackground.TabStop = false;
            // 
            // pbKeys1
            // 
            this.pbKeys1.BackColor = System.Drawing.Color.Transparent;
            this.pbKeys1.Image = global::INF164HWAss1.Properties.Resources.output_onlinepngtools__1_;
            this.pbKeys1.Location = new System.Drawing.Point(1028, 102);
            this.pbKeys1.Name = "pbKeys1";
            this.pbKeys1.Size = new System.Drawing.Size(147, 118);
            this.pbKeys1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKeys1.TabIndex = 96;
            this.pbKeys1.TabStop = false;
            this.pbKeys1.Visible = false;
            // 
            // SpawnTimer
            // 
            this.SpawnTimer.Interval = 5000;
            this.SpawnTimer.Tick += new System.EventHandler(this.SpawnTimer_Tick);
            // 
            // FireballTimer
            // 
            this.FireballTimer.Interval = 10;
            this.FireballTimer.Tick += new System.EventHandler(this.FireballTimer_Tick);
            // 
            // lblControls1
            // 
            this.lblControls1.AutoSize = true;
            this.lblControls1.BackColor = System.Drawing.Color.Transparent;
            this.lblControls1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblControls1.Font = new System.Drawing.Font("Unispace", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls1.ForeColor = System.Drawing.Color.White;
            this.lblControls1.Location = new System.Drawing.Point(1024, 223);
            this.lblControls1.Name = "lblControls1";
            this.lblControls1.Size = new System.Drawing.Size(152, 48);
            this.lblControls1.TabIndex = 99;
            this.lblControls1.Text = "Arrows or W/S\r\n to move wizzard\r\n\r\n";
            this.lblControls1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblControls1.Visible = false;
            // 
            // pbKeys2
            // 
            this.pbKeys2.BackColor = System.Drawing.Color.Transparent;
            this.pbKeys2.Image = global::INF164HWAss1.Properties.Resources.Space_bar;
            this.pbKeys2.Location = new System.Drawing.Point(812, 400);
            this.pbKeys2.Name = "pbKeys2";
            this.pbKeys2.Size = new System.Drawing.Size(128, 31);
            this.pbKeys2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKeys2.TabIndex = 100;
            this.pbKeys2.TabStop = false;
            this.pbKeys2.Visible = false;
            // 
            // lblControls2
            // 
            this.lblControls2.AutoSize = true;
            this.lblControls2.BackColor = System.Drawing.Color.Transparent;
            this.lblControls2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblControls2.Font = new System.Drawing.Font("Unispace", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControls2.ForeColor = System.Drawing.Color.White;
            this.lblControls2.Location = new System.Drawing.Point(800, 441);
            this.lblControls2.Name = "lblControls2";
            this.lblControls2.Size = new System.Drawing.Size(152, 48);
            this.lblControls2.TabIndex = 101;
            this.lblControls2.Text = "Space or Left to\r\n shoot fireball\r\n\r\n";
            this.lblControls2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblControls2.Visible = false;
            // 
            // pgbBufferTime
            // 
            this.pgbBufferTime.BackColor = System.Drawing.Color.Black;
            this.pgbBufferTime.ForeColor = System.Drawing.Color.White;
            this.pgbBufferTime.Location = new System.Drawing.Point(942, 0);
            this.pgbBufferTime.Name = "pgbBufferTime";
            this.pgbBufferTime.Size = new System.Drawing.Size(258, 10);
            this.pgbBufferTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbBufferTime.TabIndex = 102;
            // 
            // PoofTimer
            // 
            this.PoofTimer.Interval = 1000;
            this.PoofTimer.Tick += new System.EventHandler(this.PoofTimer_Tick);
            // 
            // pbPressStart
            // 
            this.pbPressStart.BackColor = System.Drawing.Color.Transparent;
            this.pbPressStart.Image = global::INF164HWAss1.Properties.Resources.Press_Startgif;
            this.pbPressStart.Location = new System.Drawing.Point(326, 45);
            this.pbPressStart.Name = "pbPressStart";
            this.pbPressStart.Size = new System.Drawing.Size(536, 384);
            this.pbPressStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPressStart.TabIndex = 103;
            this.pbPressStart.TabStop = false;
            // 
            // lblStartPress
            // 
            this.lblStartPress.AutoSize = true;
            this.lblStartPress.BackColor = System.Drawing.Color.Transparent;
            this.lblStartPress.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblStartPress.Font = new System.Drawing.Font("Unispace", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartPress.ForeColor = System.Drawing.Color.White;
            this.lblStartPress.Location = new System.Drawing.Point(526, 100);
            this.lblStartPress.Name = "lblStartPress";
            this.lblStartPress.Size = new System.Drawing.Size(142, 23);
            this.lblStartPress.TabIndex = 105;
            this.lblStartPress.Text = "Press space";
            this.lblStartPress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // wizzard1
            // 
            this.wizzard1.BackColor = System.Drawing.Color.Transparent;
            this.wizzard1.Image = global::INF164HWAss1.Properties.Resources.Toaddude;
            this.wizzard1.Location = new System.Drawing.Point(1023, 322);
            this.wizzard1.Name = "wizzard1";
            this.wizzard1.Size = new System.Drawing.Size(61, 62);
            this.wizzard1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.wizzard1.TabIndex = 94;
            this.wizzard1.TabStop = false;
            this.wizzard1.YForce = 0;
            // 
            // wall2
            // 
            this.wall2.Location = new System.Drawing.Point(947, 385);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(208, 10);
            this.wall2.TabIndex = 98;
            this.wall2.TabStop = false;
            // 
            // wall1
            // 
            this.wall1.Location = new System.Drawing.Point(947, 45);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(208, 10);
            this.wall1.TabIndex = 97;
            this.wall1.TabStop = false;
            // 
            // lblEcape
            // 
            this.lblEcape.AutoSize = true;
            this.lblEcape.BackColor = System.Drawing.Color.Transparent;
            this.lblEcape.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblEcape.Font = new System.Drawing.Font("Unispace", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEcape.ForeColor = System.Drawing.Color.White;
            this.lblEcape.Location = new System.Drawing.Point(1003, 483);
            this.lblEcape.Name = "lblEcape";
            this.lblEcape.Size = new System.Drawing.Size(188, 18);
            this.lblEcape.TabIndex = 106;
            this.lblEcape.Text = "Press escape to exit";
            this.lblEcape.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WizzardTimer
            // 
            this.WizzardTimer.Interval = 10;
            this.WizzardTimer.Tick += new System.EventHandler(this.WizzardTimer_Tick);
            // 
            // Arcade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::INF164HWAss1.Properties.Resources.ezgif_3_18f8aee5b97c;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 504);
            this.Controls.Add(this.wizzard1);
            this.Controls.Add(this.lblWizz);
            this.Controls.Add(this.lblEcape);
            this.Controls.Add(this.lblStartPress);
            this.Controls.Add(this.pbPressStart);
            this.Controls.Add(this.pgbBufferTime);
            this.Controls.Add(this.lblControls2);
            this.Controls.Add(this.pbKeys2);
            this.Controls.Add(this.lblControls1);
            this.Controls.Add(this.pbKeys1);
            this.Controls.Add(this.pbHealthLoss);
            this.Controls.Add(this.lblCoins);
            this.Controls.Add(this.pbCoin);
            this.Controls.Add(this.pbHearts);
            this.Controls.Add(this.pbBackground);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.wall1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Arcade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arcade";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Arcade_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Arcade_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbHealthLoss)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHearts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKeys1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKeys2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPressStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizzard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pbHearts;
        private System.Windows.Forms.Timer OpenFadeTimer;
        private System.Windows.Forms.Timer CloseFadeTimer;
        private System.Windows.Forms.Label lblCoins;
        private System.Windows.Forms.PictureBox pbCoin;
        private System.Windows.Forms.Label lblWizz;
        private System.Windows.Forms.Timer MoveTimer;
        private System.Windows.Forms.PictureBox pbHealthLoss;
        private System.Windows.Forms.PictureBox pbBackground;
        private Wizzard wizzard1;
        private System.Windows.Forms.PictureBox pbKeys1;
        private Wall wall1;
        private Wall wall2;
        private System.Windows.Forms.Timer SpawnTimer;
        private System.Windows.Forms.Timer FireballTimer;
        private System.Windows.Forms.Label lblControls1;
        private System.Windows.Forms.PictureBox pbKeys2;
        private System.Windows.Forms.Label lblControls2;
        private System.Windows.Forms.ProgressBar pgbBufferTime;
        private System.Windows.Forms.Timer PoofTimer;
        private System.Windows.Forms.PictureBox pbPressStart;
        private System.Windows.Forms.Label lblStartPress;
        private System.Windows.Forms.Label lblEcape;
        private System.Windows.Forms.Timer WizzardTimer;
    }
}