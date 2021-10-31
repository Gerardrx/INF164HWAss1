
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBookCollection = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBooksPerGenre = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbxGenre = new System.Windows.Forms.ComboBox();
            this.btnAddToCollection = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddToCollection);
            this.groupBox1.Controls.Add(this.cmbxGenre);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.txtCost);
            this.groupBox1.Controls.Add(this.txtAuthor);
            this.groupBox1.Controls.Add(this.txtTitle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(31, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 313);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Purchase New Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Published Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Genre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Book Cost";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBooksPerGenre);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnHome);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dgvBookCollection);
            this.groupBox2.Location = new System.Drawing.Point(35, 358);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(857, 481);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Collection";
            // 
            // dgvBookCollection
            // 
            this.dgvBookCollection.AllowUserToAddRows = false;
            this.dgvBookCollection.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.dgvBookCollection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookCollection.GridColor = System.Drawing.Color.Cyan;
            this.dgvBookCollection.Location = new System.Drawing.Point(11, 31);
            this.dgvBookCollection.Name = "dgvBookCollection";
            this.dgvBookCollection.RowHeadersWidth = 62;
            this.dgvBookCollection.RowTemplate.Height = 28;
            this.dgvBookCollection.Size = new System.Drawing.Size(829, 280);
            this.dgvBookCollection.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(75, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit Book Entry";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHome.Location = new System.Drawing.Point(75, 421);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(289, 33);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Return to Home ";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button3.Location = new System.Drawing.Point(477, 334);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(289, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Refund Book Entry";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnBooksPerGenre
            // 
            this.btnBooksPerGenre.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBooksPerGenre.Location = new System.Drawing.Point(477, 421);
            this.btnBooksPerGenre.Name = "btnBooksPerGenre";
            this.btnBooksPerGenre.Size = new System.Drawing.Size(289, 33);
            this.btnBooksPerGenre.TabIndex = 4;
            this.btnBooksPerGenre.Text = "Number of Books Per Genre";
            this.btnBooksPerGenre.UseVisualStyleBackColor = false;
            this.btnBooksPerGenre.Click += new System.EventHandler(this.btnBooksPerGenre_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(444, 42);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(380, 26);
            this.txtTitle.TabIndex = 5;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(444, 86);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(380, 26);
            this.txtAuthor.TabIndex = 6;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(444, 221);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(380, 26);
            this.txtCost.TabIndex = 7;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(444, 129);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(380, 26);
            this.dateTimePicker.TabIndex = 8;
            // 
            // cmbxGenre
            // 
            this.cmbxGenre.FormattingEnabled = true;
            this.cmbxGenre.Items.AddRange(new object[] {
            "Romance",
            "Fantasy/ Science Fiction ",
            "Mystery",
            "Horror",
            "Biography/ Autobiography"});
            this.cmbxGenre.Location = new System.Drawing.Point(444, 176);
            this.cmbxGenre.Name = "cmbxGenre";
            this.cmbxGenre.Size = new System.Drawing.Size(380, 28);
            this.cmbxGenre.TabIndex = 9;
            // 
            // btnAddToCollection
            // 
            this.btnAddToCollection.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddToCollection.Location = new System.Drawing.Point(444, 263);
            this.btnAddToCollection.Name = "btnAddToCollection";
            this.btnAddToCollection.Size = new System.Drawing.Size(379, 36);
            this.btnAddToCollection.TabIndex = 10;
            this.btnAddToCollection.Text = "Add to collection ";
            this.btnAddToCollection.UseVisualStyleBackColor = false;
            this.btnAddToCollection.Click += new System.EventHandler(this.btnAddToCollection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(941, 877);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Library";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookCollection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBookCollection;
        private System.Windows.Forms.Button btnBooksPerGenre;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ComboBox cmbxGenre;
        private System.Windows.Forms.Button btnAddToCollection;
    }
}