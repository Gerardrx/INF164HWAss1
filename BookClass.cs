using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace INF164HWAss1
{
    [Serializable]
    public class BookClass
    {
        string mTitle;
        string mAuthor;
        string mDate;
        string mGenre;
        int mCost;

        public BookClass(string Title, string Author, string Date, string Genre, int Cost)
        {
            mTitle = Title;
            mAuthor = Author;
            mDate = Date;
            mGenre = Genre;
            mCost = Cost;

        }

        public string Title { get => mTitle; set => mTitle = value; }
        public string Author { get => mAuthor; set => mAuthor = value; }
        public string Date { get => mDate; set => mDate = value; }
        public string Genre { get => mGenre; set => mGenre = value; }
        public int Cost { get => mCost; set => mCost = value; }
    }
}
