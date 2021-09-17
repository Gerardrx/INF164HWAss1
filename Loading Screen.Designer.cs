
namespace INF164HWAss1
{
    partial class frmLoading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoading));
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            this.pgbLoading = new System.Windows.Forms.ProgressBar();
            this.pbLoadingScreen = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Interval = 50;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // pgbLoading
            // 
            this.pgbLoading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pgbLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pgbLoading.Location = new System.Drawing.Point(47, 342);
            this.pgbLoading.Maximum = 75;
            this.pgbLoading.Name = "pgbLoading";
            this.pgbLoading.Size = new System.Drawing.Size(264, 23);
            this.pgbLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgbLoading.TabIndex = 1;
            // 
            // pbLoadingScreen
            // 
            this.pbLoadingScreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbLoadingScreen.BackColor = System.Drawing.Color.Transparent;
            this.pbLoadingScreen.Image = global::INF164HWAss1.Properties.Resources.Disco;
            this.pbLoadingScreen.Location = new System.Drawing.Point(101, 105);
            this.pbLoadingScreen.Name = "pbLoadingScreen";
            this.pbLoadingScreen.Size = new System.Drawing.Size(149, 164);
            this.pbLoadingScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoadingScreen.TabIndex = 0;
            this.pbLoadingScreen.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::INF164HWAss1.Properties.Resources.Loading;
            this.pictureBox1.Location = new System.Drawing.Point(-13, -16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(349, 377);
            this.Controls.Add(this.pgbLoading);
            this.Controls.Add(this.pbLoadingScreen);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer LoadingTimer;
        private System.Windows.Forms.ProgressBar pgbLoading;
        private System.Windows.Forms.PictureBox pbLoadingScreen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}