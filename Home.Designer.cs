﻿
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.ArcadeFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.SleepFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.LibraryFadeTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.btnBack.Location = new System.Drawing.Point(12, 632);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 42);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSleep
            // 
            this.btnSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSleep.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSleep.Location = new System.Drawing.Point(183, 466);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(122, 42);
            this.btnSleep.TabIndex = 1;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = true;
            // 
            // btnLibrary
            // 
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.Location = new System.Drawing.Point(399, 466);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(122, 42);
            this.btnLibrary.TabIndex = 2;
            this.btnLibrary.Text = "library";
            this.btnLibrary.UseVisualStyleBackColor = true;
            // 
            // btnArcade
            // 
            this.btnArcade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArcade.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArcade.Location = new System.Drawing.Point(606, 466);
            this.btnArcade.Name = "btnArcade";
            this.btnArcade.Size = new System.Drawing.Size(122, 42);
            this.btnArcade.TabIndex = 3;
            this.btnArcade.Text = "Arcade";
            this.btnArcade.UseVisualStyleBackColor = true;
            this.btnArcade.Click += new System.EventHandler(this.btnArcade_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::INF164HWAss1.Properties.Resources.Nutral_face;
            this.pictureBox1.Location = new System.Drawing.Point(229, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(474, 353);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(353, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(246, 65);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Mametchi";
            // 
            // ArcadeFadeTimer
            // 
            this.ArcadeFadeTimer.Interval = 10;
            this.ArcadeFadeTimer.Tick += new System.EventHandler(this.ArcadeFadeTimer_Tick);
            // 
            // SleepFadeTimer
            // 
            this.SleepFadeTimer.Interval = 10;
            // 
            // LibraryFadeTimer
            // 
            this.LibraryFadeTimer.Interval = 10;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(979, 686);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnArcade);
            this.Controls.Add(this.btnLibrary);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Timer ArcadeFadeTimer;
        private System.Windows.Forms.Timer SleepFadeTimer;
        private System.Windows.Forms.Timer LibraryFadeTimer;
    }
}