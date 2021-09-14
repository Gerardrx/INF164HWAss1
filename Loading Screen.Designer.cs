
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
            this.pbLoadingScreen = new System.Windows.Forms.PictureBox();
            this.LoadingTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLoadingScreen
            // 
            this.pbLoadingScreen.Image = global::INF164HWAss1.Properties.Resources.Loading_Screen;
            this.pbLoadingScreen.Location = new System.Drawing.Point(-1, 0);
            this.pbLoadingScreen.Name = "pbLoadingScreen";
            this.pbLoadingScreen.Size = new System.Drawing.Size(336, 359);
            this.pbLoadingScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLoadingScreen.TabIndex = 0;
            this.pbLoadingScreen.TabStop = false;
            // 
            // LoadingTimer
            // 
            this.LoadingTimer.Interval = 1000;
            this.LoadingTimer.Tick += new System.EventHandler(this.LoadingTimer_Tick);
            // 
            // frmLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 357);
            this.Controls.Add(this.pbLoadingScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pbLoadingScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLoadingScreen;
        private System.Windows.Forms.Timer LoadingTimer;
    }
}