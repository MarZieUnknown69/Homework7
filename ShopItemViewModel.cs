using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_7.ViewModels
{
    public class ShopItemViewModel
    {
        string Name;
        string Description;
        double Price;
        int QuantityAvailable;

        public ShopItemViewModel()
        {

        }
        public ShopItemViewModel(string N, string D, double P, int QA)
        {
            Name = N;
            Description = D;
            Price = P;
            QuantityAvailable = QA;
        }

        string mName
        {
            get { return mName; }
            set { mName = value; }
        }

        string mDescription
        {
            get { return mName; }
            set { mDescription = value; }
        }

        double mPrice
        {
            get { return mPrice; }
            set { mPrice = value; }
        }

        int mQuantityAvailable
        {
            get { return mQuantityAvailable; }
            set { mQuantityAvailable = value; }
        }
    }
}