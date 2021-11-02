
namespace INF164HWAss1
{
    partial class Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Library));
            this.btnAddToCollection = new System.Windows.Forms.Button();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.cmbxGenre = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBooksPerGenre = new System.Windows.Forms.Button();
            this.btnRefund = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgvBookCollection = new System.Windows.Forms.DataGridView();
            this.OpenFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseFadeTimer = new System.Windows.Forms.Timer(this.components);
            this.pbBook = new System.Windows.Forms.PictureBox();
            this.lblHeading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddToCollection
            // 
            this.btnAddToCollection.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddToCollection.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCollection.ForeColor = System.Drawing.Color.Black;
            this.btnAddToCollection.Location = new System.Drawing.Point(152, 288);
            this.btnAddToCollection.Name = "btnAddToCollection";
            this.btnAddToCollection.Size = new System.Drawing.Size(332, 27);
            this.btnAddToCollection.TabIndex = 10;
            this.btnAddToCollection.Text = "Add to collection ";
            this.btnAddToCollection.UseVisualStyleBackColor = false;
            this.btnAddToCollection.Click += new System.EventHandler(this.btnAddToCollection_Click);
            // 
            // nudCost
            // 
            this.nudCost.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCost.Location = new System.Drawing.Point(309, 235);
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(61, 23);
            this.nudCost.TabIndex = 11;
            // 
            // cmbxGenre
            // 
            this.cmbxGenre.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxGenre.FormattingEnabled = true;
            this.cmbxGenre.Items.AddRange(new object[] {
            "Romance",
            "Fantasy/ Science Fiction ",
            "Mystery",
            "Horror",
            "Biography/ Autobiography"});
            this.cmbxGenre.Location = new System.Drawing.Point(309, 198);
            this.cmbxGenre.Name = "cmbxGenre";
            this.cmbxGenre.Size = new System.Drawing.Size(175, 23);
            this.cmbxGenre.TabIndex = 9;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarMonthBackground = System.Drawing.Color.DeepSkyBlue;
            this.dateTimePicker.CalendarTitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.dateTimePicker.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(309, 159);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(175, 23);
            this.dateTimePicker.TabIndex = 8;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(309, 120);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(175, 23);
            this.txtAuthor.TabIndex = 6;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(309, 77);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(175, 23);
            this.txtTitle.TabIndex = 5;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.BackColor = System.Drawing.Color.Transparent;
            this.lblCost.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.Black;
            this.lblCost.Location = new System.Drawing.Point(157, 239);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(79, 15);
            this.lblCost.TabIndex = 4;
            this.lblCost.Text = "Book Cost";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.BackColor = System.Drawing.Color.Transparent;
            this.lblGenre.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.Color.Black;
            this.lblGenre.Location = new System.Drawing.Point(157, 201);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(47, 15);
            this.lblGenre.TabIndex = 3;
            this.lblGenre.Text = "Genre";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(157, 165);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(119, 15);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Published Date";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.Black;
            this.lblAuthor.Location = new System.Drawing.Point(157, 123);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(55, 15);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Author";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(157, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(47, 15);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // btnBooksPerGenre
            // 
            this.btnBooksPerGenre.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBooksPerGenre.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooksPerGenre.ForeColor = System.Drawing.Color.Black;
            this.btnBooksPerGenre.Location = new System.Drawing.Point(560, 240);
            this.btnBooksPerGenre.Name = "btnBooksPerGenre";
            this.btnBooksPerGenre.Size = new System.Drawing.Size(257, 25);
            this.btnBooksPerGenre.TabIndex = 4;
            this.btnBooksPerGenre.Text = "Number of Books Per Genre";
            this.btnBooksPerGenre.UseVisualStyleBackColor = false;
            this.btnBooksPerGenre.Click += new System.EventHandler(this.btnBooksPerGenre_Click);
            // 
            // btnRefund
            // 
            this.btnRefund.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRefund.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefund.ForeColor = System.Drawing.Color.Black;
            this.btnRefund.Location = new System.Drawing.Point(560, 186);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(257, 25);
            this.btnRefund.TabIndex = 3;
            this.btnRefund.Text = "Refund Book Entry";
            this.btnRefund.UseVisualStyleBackColor = false;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(560, 129);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(257, 25);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Return to Home ";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Location = new System.Drawing.Point(560, 75);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(257, 25);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit Book Entry";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgvBookCollection
            // 
            this.dgvBookCollection.AllowUserToAddRows = false;
            this.dgvBookCollection.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookCollection.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvBookCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookCollection.GridColor = System.Drawing.Color.Black;
            this.dgvBookCollection.Location = new System.Drawing.Point(152, 333);
            this.dgvBookCollection.Name = "dgvBookCollection";
            this.dgvBookCollection.RowHeadersWidth = 62;
            this.dgvBookCollection.RowTemplate.Height = 28;
            this.dgvBookCollection.Size = new System.Drawing.Size(703, 210);
            this.dgvBookCollection.TabIndex = 0;
            // 
            // OpenFadeTimer
            // 
            this.OpenFadeTimer.Interval = 10;
            this.OpenFadeTimer.Tick += new System.EventHandler(this.OpenFadeTimer_Tick_1);
            // 
            // CloseFadeTimer
            // 
            this.CloseFadeTimer.Interval = 10;
            this.CloseFadeTimer.Tick += new System.EventHandler(this.CloseFadeTimer_Tick_1);
            // 
            // pbBook
            // 
            this.pbBook.BackColor = System.Drawing.Color.Transparent;
            this.pbBook.Image = global::INF164HWAss1.Properties.Resources.Book;
            this.pbBook.Location = new System.Drawing.Point(-1, 0);
            this.pbBook.Name = "pbBook";
            this.pbBook.Size = new System.Drawing.Size(1008, 672);
            this.pbBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBook.TabIndex = 2;
            this.pbBook.TabStop = false;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Unispace", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.Location = new System.Drawing.Point(149, 36);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(161, 18);
            this.lblHeading.TabIndex = 12;
            this.lblHeading.Text = "Purchase New Book";
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = global::INF164HWAss1.Properties.Resources.Pic3;
            this.ClientSize = new System.Drawing.Size(1006, 669);
            this.Controls.Add(this.btnRefund);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBooksPerGenre);
            this.Controls.Add(this.dgvBookCollection);
            this.Controls.Add(this.btnAddToCollection);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.nudCost);
            this.Controls.Add(this.cmbxGenre);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.pbBook);
            this.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library";
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvBookCollection;
        private System.Windows.Forms.Button btnBooksPerGenre;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cmbxGenre;
        private System.Windows.Forms.Button btnAddToCollection;
        private System.Windows.Forms.Timer OpenFadeTimer;
        private System.Windows.Forms.Timer CloseFadeTimer;
        private System.Windows.Forms.NumericUpDown nudCost;
        private System.Windows.Forms.PictureBox pbBook;
        private System.Windows.Forms.Label lblHeading;
    }
}