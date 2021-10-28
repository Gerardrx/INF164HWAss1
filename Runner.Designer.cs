
namespace INF164HWAss1
{
    partial class Runner
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
            this.coin1 = new INF164HWAss1.Coin();
            this.wall5 = new INF164HWAss1.Wall();
            this.player1 = new INF164HWAss1.Player();
            this.ghost1 = new INF164HWAss1.Ghost();
            this.wall4 = new INF164HWAss1.Wall();
            this.wall3 = new INF164HWAss1.Wall();
            this.wall2 = new INF164HWAss1.Wall();
            this.wall1 = new INF164HWAss1.Wall();
            this.wall6 = new INF164HWAss1.Wall();
            this.wall7 = new INF164HWAss1.Wall();
            this.wall8 = new INF164HWAss1.Wall();
            this.wall9 = new INF164HWAss1.Wall();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ghost2 = new INF164HWAss1.Ghost();
            this.ghost3 = new INF164HWAss1.Ghost();
            this.ghost4 = new INF164HWAss1.Ghost();
            this.ghost5 = new INF164HWAss1.Ghost();
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost5)).BeginInit();
            this.SuspendLayout();
            // 
            // coin1
            // 
            this.coin1.Image = global::INF164HWAss1.Properties.Resources.coin;
            this.coin1.Location = new System.Drawing.Point(512, 241);
            this.coin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.coin1.Name = "coin1";
            this.coin1.Size = new System.Drawing.Size(44, 42);
            this.coin1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin1.TabIndex = 7;
            this.coin1.TabStop = false;
            // 
            // wall5
            // 
            this.wall5.BackColor = System.Drawing.Color.Lime;
            this.wall5.Location = new System.Drawing.Point(45, 144);
            this.wall5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wall5.Name = "wall5";
            this.wall5.Size = new System.Drawing.Size(433, 32);
            this.wall5.TabIndex = 6;
            this.wall5.TabStop = false;
            // 
            // player1
            // 
            this.player1.Direction = '\0';
            this.player1.Image = global::INF164HWAss1.Properties.Resources.ChickManWoman;
            this.player1.Location = new System.Drawing.Point(45, 43);
            this.player1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(53, 52);
            this.player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1.TabIndex = 5;
            this.player1.TabStop = false;
            // 
            // ghost1
            // 
            this.ghost1.Heading = 'l';
            this.ghost1.Image = global::INF164HWAss1.Properties.Resources.toot;
            this.ghost1.Location = new System.Drawing.Point(1121, 304);
            this.ghost1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ghost1.MaxX = 900;
            this.ghost1.MaxY = 0;
            this.ghost1.MinX = 50;
            this.ghost1.MinY = 0;
            this.ghost1.Name = "ghost1";
            this.ghost1.Size = new System.Drawing.Size(45, 51);
            this.ghost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost1.TabIndex = 4;
            this.ghost1.TabStop = false;
            // 
            // wall4
            // 
            this.wall4.BackColor = System.Drawing.Color.Lime;
            this.wall4.Location = new System.Drawing.Point(1273, 39);
            this.wall4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wall4.Name = "wall4";
            this.wall4.Size = new System.Drawing.Size(33, 973);
            this.wall4.TabIndex = 3;
            this.wall4.TabStop = false;
            // 
            // wall3
            // 
            this.wall3.BackColor = System.Drawing.Color.Lime;
            this.wall3.Location = new System.Drawing.Point(8, 39);
            this.wall3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wall3.Name = "wall3";
            this.wall3.Size = new System.Drawing.Size(33, 973);
            this.wall3.TabIndex = 2;
            this.wall3.TabStop = false;
            // 
            // wall2
            // 
            this.wall2.BackColor = System.Drawing.Color.Lime;
            this.wall2.Location = new System.Drawing.Point(8, 1007);
            this.wall2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wall2.Name = "wall2";
            this.wall2.Size = new System.Drawing.Size(1299, 32);
            this.wall2.TabIndex = 1;
            this.wall2.TabStop = false;
            // 
            // wall1
            // 
            this.wall1.BackColor = System.Drawing.Color.Lime;
            this.wall1.Location = new System.Drawing.Point(8, 7);
            this.wall1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wall1.Name = "wall1";
            this.wall1.Size = new System.Drawing.Size(1299, 32);
            this.wall1.TabIndex = 0;
            this.wall1.TabStop = false;
            // 
            // wall6
            // 
            this.wall6.BackColor = System.Drawing.Color.Lime;
            this.wall6.Location = new System.Drawing.Point(584, 65);
            this.wall6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wall6.Name = "wall6";
            this.wall6.Size = new System.Drawing.Size(499, 37);
            this.wall6.TabIndex = 8;
            this.wall6.TabStop = false;
            // 
            // wall7
            // 
            this.wall7.BackColor = System.Drawing.Color.Lime;
            this.wall7.Location = new System.Drawing.Point(721, 807);
            this.wall7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wall7.Name = "wall7";
            this.wall7.Size = new System.Drawing.Size(499, 56);
            this.wall7.TabIndex = 9;
            this.wall7.TabStop = false;
            // 
            // wall8
            // 
            this.wall8.BackColor = System.Drawing.Color.Lime;
            this.wall8.Location = new System.Drawing.Point(64, 871);
            this.wall8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wall8.Name = "wall8";
            this.wall8.Size = new System.Drawing.Size(445, 102);
            this.wall8.TabIndex = 10;
            this.wall8.TabStop = false;
            // 
            // wall9
            // 
            this.wall9.BackColor = System.Drawing.Color.Lime;
            this.wall9.Location = new System.Drawing.Point(768, 928);
            this.wall9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wall9.Name = "wall9";
            this.wall9.Size = new System.Drawing.Size(499, 45);
            this.wall9.TabIndex = 11;
            this.wall9.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // ghost2
            // 
            this.ghost2.Heading = 'r';
            this.ghost2.Image = global::INF164HWAss1.Properties.Resources.toot;
            this.ghost2.Location = new System.Drawing.Point(502, 708);
            this.ghost2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ghost2.MaxX = 900;
            this.ghost2.MaxY = 0;
            this.ghost2.MinX = 50;
            this.ghost2.MinY = 0;
            this.ghost2.Name = "ghost2";
            this.ghost2.Size = new System.Drawing.Size(45, 51);
            this.ghost2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost2.TabIndex = 12;
            this.ghost2.TabStop = false;
            // 
            // ghost3
            // 
            this.ghost3.Heading = 'd';
            this.ghost3.Image = global::INF164HWAss1.Properties.Resources.toot;
            this.ghost3.Location = new System.Drawing.Point(640, 928);
            this.ghost3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ghost3.MaxX = 0;
            this.ghost3.MaxY = 750;
            this.ghost3.MinX = 0;
            this.ghost3.MinY = 130;
            this.ghost3.Name = "ghost3";
            this.ghost3.Size = new System.Drawing.Size(45, 51);
            this.ghost3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost3.TabIndex = 13;
            this.ghost3.TabStop = false;
            // 
            // ghost4
            // 
            this.ghost4.Heading = 'r';
            this.ghost4.Image = global::INF164HWAss1.Properties.Resources.toot;
            this.ghost4.Location = new System.Drawing.Point(919, 465);
            this.ghost4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ghost4.MaxX = 900;
            this.ghost4.MaxY = 0;
            this.ghost4.MinX = 50;
            this.ghost4.MinY = 0;
            this.ghost4.Name = "ghost4";
            this.ghost4.Size = new System.Drawing.Size(45, 51);
            this.ghost4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost4.TabIndex = 14;
            this.ghost4.TabStop = false;
            // 
            // ghost5
            // 
            this.ghost5.Heading = 'd';
            this.ghost5.Image = global::INF164HWAss1.Properties.Resources.toot;
            this.ghost5.Location = new System.Drawing.Point(331, 764);
            this.ghost5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ghost5.MaxX = 0;
            this.ghost5.MaxY = 660;
            this.ghost5.MinX = 0;
            this.ghost5.MinY = 200;
            this.ghost5.Name = "ghost5";
            this.ghost5.Size = new System.Drawing.Size(45, 51);
            this.ghost5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ghost5.TabIndex = 15;
            this.ghost5.TabStop = false;
            // 
            // Runner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1319, 1050);
            this.Controls.Add(this.ghost5);
            this.Controls.Add(this.ghost4);
            this.Controls.Add(this.ghost3);
            this.Controls.Add(this.ghost2);
            this.Controls.Add(this.wall9);
            this.Controls.Add(this.wall8);
            this.Controls.Add(this.wall7);
            this.Controls.Add(this.coin1);
            this.Controls.Add(this.wall5);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.ghost1);
            this.Controls.Add(this.wall4);
            this.Controls.Add(this.wall3);
            this.Controls.Add(this.wall2);
            this.Controls.Add(this.wall1);
            this.Controls.Add(this.wall6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Runner";
            this.Text = "Runner";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Runner_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.coin1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghost5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Wall wall1;
        private Wall wall2;
        private Wall wall3;
        private Wall wall4;
        private Ghost ghost1;
        private Player player1;
        private Wall wall5;
        private Coin coin1;
        private Wall wall6;
        private Wall wall7;
        private Wall wall8;
        private Wall wall9;
        private System.Windows.Forms.Timer gameTimer;
        private Ghost ghost2;
        private Ghost ghost3;
        private Ghost ghost4;
        private Ghost ghost5;
    }
}