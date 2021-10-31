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
    public class Save
    {
        private int mCoins;
        private int mBrain;
        private int mBook;

        public Save()
        {
            mCoins = 0;
            mBrain = 0;
            mBook = 0;
        }

        public Save(int coins, int brain, int book)
        {
            this.mCoins = coins;
            this.mBrain = brain;
            this.mBook = book;
        }

        public int Coins 
        { 
            get => mCoins; 
            set => mCoins = value;
        }
        public int Brain 
        { 
            get => mBrain; 
            set => mBrain = value; 
        }
        public int Book 
        { 
            get => mBook; 
            set => mBook = value;
        }
    }
}
