
namespace INF164HWAss1
{
    partial class frmInstructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstructions));
            this.btnBack = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.rtbInstructions = new System.Windows.Forms.RichTextBox();
            this.OpenFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.pbInstructions = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TypeTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(486, 752);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(183, 65);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(177, 14);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(312, 63);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "Instructions";
            // 
            // rtbInstructions
            // 
            this.rtbInstructions.BackColor = System.Drawing.Color.Black;
            this.rtbInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInstructions.ForeColor = System.Drawing.Color.White;
            this.rtbInstructions.Location = new System.Drawing.Point(18, 92);
            this.rtbInstructions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbInstructions.Name = "rtbInstructions";
            this.rtbInstructions.ReadOnly = true;
            this.rtbInstructions.Size = new System.Drawing.Size(632, 706);
            this.rtbInstructions.TabIndex = 3;
            this.rtbInstructions.Text = "";
            this.rtbInstructions.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtbInstructions_KeyPress);
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
            // pbInstructions
            // 
            this.pbInstructions.BackColor = System.Drawing.Color.Transparent;
            this.pbInstructions.Image = global::INF164HWAss1.Properties.Resources.Instructions;
            this.pbInstructions.Location = new System.Drawing.Point(502, 14);
            this.pbInstructions.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbInstructions.Name = "pbInstructions";
            this.pbInstructions.Size = new System.Drawing.Size(96, 82);
            this.pbInstructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInstructions.TabIndex = 4;
            this.pbInstructions.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::INF164HWAss1.Properties.Resources.Instructions;
            this.pictureBox1.Location = new System.Drawing.Point(72, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // TypeTimer
            // 
            this.TypeTimer.Interval = 75;
            this.TypeTimer.Tick += new System.EventHandler(this.TypeTimer_Tick);
            // 
            // frmInstructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(670, 818);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.rtbInstructions);
            this.Controls.Add(this.pbInstructions);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInstructions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instructions";
            this.Load += new System.EventHandler(this.frmInstructions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbInstructions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.RichTextBox rtbInstructions;
        private System.Windows.Forms.Timer OpenFadeTimer;
        private System.Windows.Forms.Timer CloseFadeTimer;
        private System.Windows.Forms.PictureBox pbInstructions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer TypeTimer;
    }
}