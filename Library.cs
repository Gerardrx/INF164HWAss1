using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();

            //OpenFadeTimer.Start();
            Opacity = 0;
        }

        //Create binding list
        BindingList<BookClass> bookList = new BindingList<BookClass>();

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            //Close form and show home form
            CloseFadeTimer.Start();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int selectedindex = dgvBookCollection.CurrentRow.Index;

            BookClass objectToedit = bookList[selectedindex];
            EditForm editform = new EditForm();
            editform.editobject = objectToedit;
            editform.ShowDialog();

            objectToedit = editform.editobject;

            bookList[selectedindex] = objectToedit;
        }

        private void btnAddToCollection_Click(object sender, EventArgs e)
        {
            string Title = txtTitle.Text;
            string Author = txtAuthor.Text;
            string Date = dateTimePicker.Text;
            string Genre = cmbxGenre.Text;
            string Cost = txtCost.Text;

            BookClass myobject = new BookClass(Title, Author, Date, Genre, Cost);
            bookList.Add(myobject);

            dgvBookCollection.DataSource = bookList;
        }

        private void btnBooksPerGenre_Click(object sender, EventArgs e)
        {
            int rCount = 0;
            int fCount = 0;
            int mCount = 0;
            int hCount = 0;
            int bCount = 0;

            for (int i = 0; i < bookList.Count; i++)
            {
                string theGenre = bookList[i].Genre;

                if (theGenre == "Romance")
                {
                    rCount++;
                }
                else if (theGenre == "Fantasy/ Science Fiction")
                {
                    fCount++;
                }
                else if (theGenre == "Mystery")
                {
                    mCount++;
                }
                else if (theGenre == "Horror")
                {
                    hCount++;
                }
                else if (theGenre == "Biography/ Autobiography")
                {
                    bCount++;
                }
            }

            MessageBox.Show("There are " + rCount + " Romance books." + "\n" +
                "There are " + fCount + " Fantasy/ Science Fiction books." + "\n" +
                "There are " + mCount + " Mystery books." + "\n" +
                "There are " + hCount + " Horror books." + "\n" +
                "There are " + bCount + " Biography/ Autobiography books.");
        }

        private void btnRefund_Click(object sender, EventArgs e)
        {
            int selectedindex = dgvBookCollection.CurrentRow.Index;

            string selectedTitle = bookList[selectedindex].Title;

            dgvBookCollection.Rows.RemoveAt(selectedindex);

            bookList.RemoveAt(selectedindex);

            MessageBox.Show(selectedTitle + " has been refunded and removed!");
        }

        private void OpenFadeTimer_Tick_1(object sender, EventArgs e)
        {
            //Fade in the form
            if (Opacity == 1)
            {
                OpenFadeTimer.Stop();
                btnBack.Enabled = true;
            }
            Opacity += 0.03;
        }

        private void CloseFadeTimer_Tick_1(object sender, EventArgs e)
        {
            //Fade out the form
            if (Opacity == 0)
            {
                CloseFadeTimer.Stop();
                this.Dispose();

                //open new menu form
                frmHome h = new frmHome();
                h.Visible = true;
            }
            Opacity -= 0.03;
        }
    }
}
