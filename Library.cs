using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace INF164HWAss1
{
    public partial class Library : Form
    {
        public int bookCount;

        private string title;
        private string author;
        private string date;
        private string genre;
        private int cost;

        public Library()
        {
            InitializeComponent();

            OpenFadeTimer.Start();
            Opacity = 0;
            ReadDataFromFile(bookList);
            dgvBookCollection.DataSource = bookList;
            bookCount = dgvBookCollection.Rows.Count;
        }

        

        //Create binding list
        BindingList<BookClass> bookList = new BindingList<BookClass>();

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            //Close form and show home form
            bookCount = dgvBookCollection.Rows.Count;
            WriteDataToFile(bookList);
            CloseFadeTimer.Start();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBookCollection.Rows.Count > 0)
            {
                int selectedindex = dgvBookCollection.CurrentRow.Index;

                BookClass objectToedit = bookList[selectedindex];
                EditForm editform = new EditForm();
                editform.editobject = objectToedit;
                editform.ShowDialog();

                objectToedit = editform.editobject;

                bookList[selectedindex] = objectToedit;
            }
        }

        private void btnAddToCollection_Click(object sender, EventArgs e)
        {
            title = txtTitle.Text;
            author = txtAuthor.Text;
            date = dateTimePicker.Text;
            genre = cmbxGenre.Text;
            cost = (int)nudCost.Value;

            if (checkempty())
            {
                BookClass myobject = new BookClass(title, author, date, genre, cost);
                bookList.Add(myobject);

                dgvBookCollection.DataSource = bookList;

                txtTitle.Clear();
                txtAuthor.Clear();
                dateTimePicker.ResetText();
                cmbxGenre.ResetText();
                nudCost.Value = 0;
            }
        }

        private bool checkempty()
        {
            bool flag = true;
            string temp = "";
            if (title.Length < 2)
            {
                temp += "Title needs to be longer than 2 characters\n";
                flag = false;
            }
            if (author.Length < 2)
            {
                temp += "Author needs to be longer than 2 characters\n";
                flag = false;
            }
            if (cmbxGenre.SelectedIndex == -1)
            {
                temp += "Please select genre\n";
                flag = false;
            }
            if (!flag)
            {
                MessageBox.Show(temp);
            } 
            return flag;
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
            if (dgvBookCollection.Rows.Count > 0)
            {
                int selectedindex = dgvBookCollection.CurrentRow.Index;
                string selectedTitle = bookList[selectedindex].Title;

                dgvBookCollection.Rows.RemoveAt(selectedindex);
                MessageBox.Show(selectedTitle + " has been refunded and removed!");
            }
        }


        public void WriteDataToFile(BindingList<BookClass> myList)
        {
            FileStream outFile = new FileStream("booklist.ser", FileMode.Create, FileAccess.Write);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(outFile, myList);
            outFile.Close();

        }

        public void ReadDataFromFile(BindingList<BookClass> myList)
        {
            try
            {
                FileStream inFile = new FileStream( "booklist.ser", FileMode.Open, FileAccess.Read);
                BinaryFormatter bFormatter = new BinaryFormatter();
                myList.Clear();
                var tempList = (BindingList<BookClass>)bFormatter.Deserialize(inFile);
                foreach (BookClass myObject in tempList)
                {
                    myList.Add(myObject);
                }
                inFile.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("The data file could not be found");
            }
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
            }
            Opacity -= 0.03;
        }
    }
}
