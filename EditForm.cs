using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace INF164HWAss1
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }
        public BookClass editobject;

        private void EditForm_Load(object sender, EventArgs e)
        {
            txtTitle.Text = editobject.Title;
            txtAuthor.Text = editobject.Author;
            dateTimePicker.Text = editobject.Date;
            cmbxGenre.Text = editobject.Genre;
            nudEditCost.Value = editobject.Cost;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editobject.Title = txtTitle.Text;
            editobject.Author = txtAuthor.Text;
            editobject.Date = dateTimePicker.Text;
            editobject.Genre = cmbxGenre.Text;
            editobject.Cost = (int) nudEditCost.Value;

            this.Close();
        }
    }
}
