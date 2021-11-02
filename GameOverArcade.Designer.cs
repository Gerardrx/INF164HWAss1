
namespace INF164HWAss1
{
    partial class GameOverArcade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverArcade));
            this.lblGameover = new System.Windows.Forms.Label();
            this.lblGameOverCoins = new System.Windows.Forms.Label();
            this.pbGameOverCoins = new System.Windows.Forms.PictureBox();
            this.pbBackground = new System.Windows.Forms.PictureBox();
            this.OpenFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.wall1 = new INF164HWAss1.Wall();
            this.wall4 = new INF164HWAss1.Wall();
            this.wall3 = new INF164HWAss1.Wall();
            this.wall2 = new INF164HWAss1.Wall();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOverCoins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGameover
            // 
            this.lblGameover.AutoSize = true;
            this.lblGameover.BackColor = System.Drawing.Color.Transparent;
            this.lblGameover.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameover.ForeColor = System.Drawing.Color.White;
            this.lblGameover.Location = new System.Drawing.Point(494, 411);
            this.lblGameover.Name = "lblGameover";
            this.lblGameover.Size = new System.Drawing.Size(229, 19);
            this.lblGameover.TabIndex = 110;
            this.lblGameover.Text = "Press Enter to restart";
            // 
            // lblGameOverCoins
            // 
            this.lblGameOverCoins.AutoSize = true;
            this.lblGameOverCoins.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOverCoins.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOverCoins.ForeColor = System.Drawing.Color.Yellow;
            this.lblGameOverCoins.Location = new System.Drawing.Point(619, 340);
            this.lblGameOverCoins.Name = "lblGameOverCoins";
            this.lblGameOverCoins.Size = new System.Drawing.Size(25, 25);
            this.lblGameOverCoins.TabIndex = 114;
            this.lblGameOverCoins.Text = "0";
            this.lblGameOverCoins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbGameOverCoins
            // 
            this.pbGameOverCoins.BackColor = System.Drawing.Color.Transparent;
            this.pbGameOverCoins.Image = global::INF164HWAss1.Properties.Resources.coin;
            this.pbGameOverCoins.Location = new System.Drawing.Point(581, 331);
            this.pbGameOverCoins.Name = "pbGameOverCoins";
            this.pbGameOverCoins.Size = new System.Drawing.Size(39, 39);
            this.pbGameOverCoins.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbGameOverCoins.TabIndex = 113;
            this.pbGameOverCoins.TabStop = false;
            // 
            // pbBackground
            // 
            this.pbBackground.BackColor = System.Drawing.Color.White;
            this.pbBackground.Image = global::INF164HWAss1.Properties.Resources.GameOverWiz1;
            this.pbBackground.Location = new System.Drawing.Point(0, 0);
            this.pbBackground.Name = "pbBackground";
            this.pbBackground.Size = new System.Drawing.Size(1200, 505);
            this.pbBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbBackground.TabIndex = 115;
            this.pbBackground.TabStop = false;
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
            // wall1
            // 
            this.wall1.BackColor = System.Drawing.Color.Maroon;
            this.wall1.Location = new System.Drawing.Point(0, 495);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(1201, 10);
            this.wall1.TabIndex = 116;
            this.wall1.TabStop = false;
            // 
            // wall4
            // 
            this.wall4.BackColor = System.Drawing.Color.Maroon;
            this.wall4.Location = new System.Drawing.Point(-1, 0);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(1201, 10);
            this.wall4.TabIndex = 119;
            this.wall4.TabStop = false;
            // 
            // wall3
            // 
            this.wall3.BackColor = System.Drawing.Color.Maroon;
            this.wall3.Location = new System.Drawing.Point(1191, 2);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(10, 503);
            this.wall3.TabIndex = 118;
            this.wall3.TabStop = false;
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.Color.Maroon;
            this.wall2.Location = new System.Drawing.Point(0, 2);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(10, 503);
            this.wall2.TabIndex = 117;
            this.wall2.TabStop = false;
            // 
            // GameOverArcade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 505);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.wall4);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.lblGameOverCoins);
            this.Controls.Add(this.pbGameOverCoins);
            this.Controls.Add(this.lblGameover);
            this.Controls.Add(this.pbBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameOverArcade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameOverArcade";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameOverArcade_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameOverCoins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameover;
        private System.Windows.Forms.Label lblGameOverCoins;
        private System.Windows.Forms.PictureBox pbGameOverCoins;
        private System.Windows.Forms.PictureBox pbBackground;
        private System.Windows.Forms.Timer OpenFadeTimer;
        private System.Windows.Forms.Timer CloseFadeTimer;
        private Wall wall1;
        private Wall wall2;
        private Wall wall3;
        private Wall wall4;
    }
}