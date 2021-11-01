
namespace INF164HWAss1
{
    partial class frmSleep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSleep));
            this.btnBack = new System.Windows.Forms.Button();
            this.OpenFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.tlpIcons = new System.Windows.Forms.TableLayoutPanel();
            this.pbImg1 = new System.Windows.Forms.PictureBox();
            this.pbImg2 = new System.Windows.Forms.PictureBox();
            this.pbImg3 = new System.Windows.Forms.PictureBox();
            this.pbImg4 = new System.Windows.Forms.PictureBox();
            this.pbImg5 = new System.Windows.Forms.PictureBox();
            this.pbImg6 = new System.Windows.Forms.PictureBox();
            this.pbImg7 = new System.Windows.Forms.PictureBox();
            this.pbImg8 = new System.Windows.Forms.PictureBox();
            this.pbImg9 = new System.Windows.Forms.PictureBox();
            this.pbImg10 = new System.Windows.Forms.PictureBox();
            this.pbImg11 = new System.Windows.Forms.PictureBox();
            this.pbImg12 = new System.Windows.Forms.PictureBox();
            this.pbImg13 = new System.Windows.Forms.PictureBox();
            this.pbImg14 = new System.Windows.Forms.PictureBox();
            this.pbImg15 = new System.Windows.Forms.PictureBox();
            this.pbImg16 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblT = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.delayTimer = new System.Windows.Forms.Timer(this.components);
            this.tlpIcons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg16)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnBack.Enabled = false;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(769, 217);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 42);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // tlpIcons
            // 
            this.tlpIcons.BackColor = System.Drawing.Color.SpringGreen;
            this.tlpIcons.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tlpIcons.ColumnCount = 4;
            this.tlpIcons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIcons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIcons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIcons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIcons.Controls.Add(this.pbImg1, 0, 0);
            this.tlpIcons.Controls.Add(this.pbImg2, 1, 0);
            this.tlpIcons.Controls.Add(this.pbImg3, 2, 0);
            this.tlpIcons.Controls.Add(this.pbImg4, 3, 0);
            this.tlpIcons.Controls.Add(this.pbImg5, 0, 1);
            this.tlpIcons.Controls.Add(this.pbImg6, 1, 1);
            this.tlpIcons.Controls.Add(this.pbImg7, 2, 1);
            this.tlpIcons.Controls.Add(this.pbImg8, 3, 1);
            this.tlpIcons.Controls.Add(this.pbImg9, 0, 2);
            this.tlpIcons.Controls.Add(this.pbImg10, 1, 2);
            this.tlpIcons.Controls.Add(this.pbImg11, 2, 2);
            this.tlpIcons.Controls.Add(this.pbImg12, 3, 2);
            this.tlpIcons.Controls.Add(this.pbImg13, 0, 3);
            this.tlpIcons.Controls.Add(this.pbImg14, 1, 3);
            this.tlpIcons.Controls.Add(this.pbImg15, 2, 3);
            this.tlpIcons.Controls.Add(this.pbImg16, 3, 3);
            this.tlpIcons.Location = new System.Drawing.Point(49, 32);
            this.tlpIcons.Name = "tlpIcons";
            this.tlpIcons.RowCount = 4;
            this.tlpIcons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIcons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIcons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIcons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpIcons.Size = new System.Drawing.Size(652, 563);
            this.tlpIcons.TabIndex = 2;
            // 
            // pbImg1
            // 
            this.pbImg1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg1.Location = new System.Drawing.Point(6, 6);
            this.pbImg1.Name = "pbImg1";
            this.pbImg1.Size = new System.Drawing.Size(153, 131);
            this.pbImg1.TabIndex = 0;
            this.pbImg1.TabStop = false;
            this.pbImg1.Click += new System.EventHandler(this.pbImg1_Click);
            // 
            // pbImg2
            // 
            this.pbImg2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg2.Location = new System.Drawing.Point(168, 6);
            this.pbImg2.Name = "pbImg2";
            this.pbImg2.Size = new System.Drawing.Size(153, 131);
            this.pbImg2.TabIndex = 1;
            this.pbImg2.TabStop = false;
            this.pbImg2.Click += new System.EventHandler(this.pbImg2_Click);
            // 
            // pbImg3
            // 
            this.pbImg3.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg3.Location = new System.Drawing.Point(330, 6);
            this.pbImg3.Name = "pbImg3";
            this.pbImg3.Size = new System.Drawing.Size(153, 131);
            this.pbImg3.TabIndex = 2;
            this.pbImg3.TabStop = false;
            this.pbImg3.Click += new System.EventHandler(this.pbImg3_Click);
            // 
            // pbImg4
            // 
            this.pbImg4.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg4.Location = new System.Drawing.Point(492, 6);
            this.pbImg4.Name = "pbImg4";
            this.pbImg4.Size = new System.Drawing.Size(154, 131);
            this.pbImg4.TabIndex = 3;
            this.pbImg4.TabStop = false;
            this.pbImg4.Click += new System.EventHandler(this.pbImg4_Click);
            // 
            // pbImg5
            // 
            this.pbImg5.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg5.Location = new System.Drawing.Point(6, 146);
            this.pbImg5.Name = "pbImg5";
            this.pbImg5.Size = new System.Drawing.Size(153, 131);
            this.pbImg5.TabIndex = 4;
            this.pbImg5.TabStop = false;
            this.pbImg5.Click += new System.EventHandler(this.pbImg5_Click);
            // 
            // pbImg6
            // 
            this.pbImg6.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg6.Location = new System.Drawing.Point(168, 146);
            this.pbImg6.Name = "pbImg6";
            this.pbImg6.Size = new System.Drawing.Size(153, 131);
            this.pbImg6.TabIndex = 5;
            this.pbImg6.TabStop = false;
            this.pbImg6.Click += new System.EventHandler(this.pbImg6_Click);
            // 
            // pbImg7
            // 
            this.pbImg7.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg7.Location = new System.Drawing.Point(330, 146);
            this.pbImg7.Name = "pbImg7";
            this.pbImg7.Size = new System.Drawing.Size(153, 131);
            this.pbImg7.TabIndex = 6;
            this.pbImg7.TabStop = false;
            this.pbImg7.Click += new System.EventHandler(this.pbImg7_Click);
            // 
            // pbImg8
            // 
            this.pbImg8.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg8.Location = new System.Drawing.Point(492, 146);
            this.pbImg8.Name = "pbImg8";
            this.pbImg8.Size = new System.Drawing.Size(154, 131);
            this.pbImg8.TabIndex = 7;
            this.pbImg8.TabStop = false;
            this.pbImg8.Click += new System.EventHandler(this.pbImg8_Click);
            // 
            // pbImg9
            // 
            this.pbImg9.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg9.Location = new System.Drawing.Point(6, 286);
            this.pbImg9.Name = "pbImg9";
            this.pbImg9.Size = new System.Drawing.Size(153, 131);
            this.pbImg9.TabIndex = 8;
            this.pbImg9.TabStop = false;
            this.pbImg9.Click += new System.EventHandler(this.pbImg9_Click);
            // 
            // pbImg10
            // 
            this.pbImg10.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg10.Location = new System.Drawing.Point(168, 286);
            this.pbImg10.Name = "pbImg10";
            this.pbImg10.Size = new System.Drawing.Size(153, 131);
            this.pbImg10.TabIndex = 9;
            this.pbImg10.TabStop = false;
            this.pbImg10.Click += new System.EventHandler(this.pbImg10_Click);
            // 
            // pbImg11
            // 
            this.pbImg11.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg11.Location = new System.Drawing.Point(330, 286);
            this.pbImg11.Name = "pbImg11";
            this.pbImg11.Size = new System.Drawing.Size(153, 131);
            this.pbImg11.TabIndex = 10;
            this.pbImg11.TabStop = false;
            this.pbImg11.Click += new System.EventHandler(this.pbImg11_Click);
            // 
            // pbImg12
            // 
            this.pbImg12.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg12.Location = new System.Drawing.Point(492, 286);
            this.pbImg12.Name = "pbImg12";
            this.pbImg12.Size = new System.Drawing.Size(154, 131);
            this.pbImg12.TabIndex = 11;
            this.pbImg12.TabStop = false;
            this.pbImg12.Click += new System.EventHandler(this.pbImg12_Click);
            // 
            // pbImg13
            // 
            this.pbImg13.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg13.Location = new System.Drawing.Point(6, 426);
            this.pbImg13.Name = "pbImg13";
            this.pbImg13.Size = new System.Drawing.Size(153, 131);
            this.pbImg13.TabIndex = 12;
            this.pbImg13.TabStop = false;
            this.pbImg13.Click += new System.EventHandler(this.pbImg13_Click);
            // 
            // pbImg14
            // 
            this.pbImg14.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg14.Location = new System.Drawing.Point(168, 426);
            this.pbImg14.Name = "pbImg14";
            this.pbImg14.Size = new System.Drawing.Size(153, 131);
            this.pbImg14.TabIndex = 13;
            this.pbImg14.TabStop = false;
            this.pbImg14.Click += new System.EventHandler(this.pbImg14_Click);
            // 
            // pbImg15
            // 
            this.pbImg15.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg15.Location = new System.Drawing.Point(330, 426);
            this.pbImg15.Name = "pbImg15";
            this.pbImg15.Size = new System.Drawing.Size(153, 131);
            this.pbImg15.TabIndex = 14;
            this.pbImg15.TabStop = false;
            this.pbImg15.Click += new System.EventHandler(this.pbImg15_Click);
            // 
            // pbImg16
            // 
            this.pbImg16.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbImg16.Location = new System.Drawing.Point(492, 426);
            this.pbImg16.Name = "pbImg16";
            this.pbImg16.Size = new System.Drawing.Size(154, 131);
            this.pbImg16.TabIndex = 15;
            this.pbImg16.TabStop = false;
            this.pbImg16.Click += new System.EventHandler(this.pbImg16_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(769, 127);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(122, 42);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.BackColor = System.Drawing.Color.Transparent;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.ForeColor = System.Drawing.Color.White;
            this.lblT.Location = new System.Drawing.Point(765, 61);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(63, 24);
            this.lblT.TabIndex = 4;
            this.lblT.Text = "Time:";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTime.Location = new System.Drawing.Point(847, 64);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(49, 24);
            this.lblTime.TabIndex = 5;
            this.lblTime.Text = "0:00";
            // 
            // startTimer
            // 
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // gameTimer
            // 
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // delayTimer
            // 
            this.delayTimer.Interval = 500;
            // 
            // frmSleep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INF164HWAss1.Properties.Resources.Custom_Edited___Pokemon_Route_101;
            this.ClientSize = new System.Drawing.Size(933, 647);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.tlpIcons);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSleep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sleep";
            this.Load += new System.EventHandler(this.frmSleep_Load);
            this.tlpIcons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImg1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer OpenFadeTimer;
        private System.Windows.Forms.Timer CloseFadeTimer;
        private System.Windows.Forms.TableLayoutPanel tlpIcons;
        private System.Windows.Forms.PictureBox pbImg1;
        private System.Windows.Forms.PictureBox pbImg2;
        private System.Windows.Forms.PictureBox pbImg3;
        private System.Windows.Forms.PictureBox pbImg4;
        private System.Windows.Forms.PictureBox pbImg5;
        private System.Windows.Forms.PictureBox pbImg6;
        private System.Windows.Forms.PictureBox pbImg7;
        private System.Windows.Forms.PictureBox pbImg8;
        private System.Windows.Forms.PictureBox pbImg9;
        private System.Windows.Forms.PictureBox pbImg10;
        private System.Windows.Forms.PictureBox pbImg11;
        private System.Windows.Forms.PictureBox pbImg12;
        private System.Windows.Forms.PictureBox pbImg13;
        private System.Windows.Forms.PictureBox pbImg14;
        private System.Windows.Forms.PictureBox pbImg15;
        private System.Windows.Forms.PictureBox pbImg16;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer startTimer;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer delayTimer;
    }
}