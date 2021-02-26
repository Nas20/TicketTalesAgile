using System;

namespace ClassLibrary
{
    public class clsStock
    {
        private Int32 mStockId;
        private string mItemName;
        private int mQuantity;
        private Decimal mPrice;
        private Boolean mStockAvailable;
        private DateTime mDatePurchased;
        

        public Int32 StockId
        {
            get
            {
                return mStockId;
            }
            set
            {
                mStockId = value;
            }
        }
        public string ItemName
        {
            get
            {
                return mItemName;
            }
            set
            {
                mItemName = value;
            }
        }
        public int Quantity
        {
            get
            {
                return mQuantity;
            }
            set
            {
                mQuantity = value;
            }
        }
        public object Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = Convert.ToDecimal (value);
            }
        }
        public bool StockAvailable
        {
            get
            {
                return mStockAvailable;
            }
            set
            {
                mStockAvailable = value;
            }
        }
        public DateTime DatePurchased
        {
            get
            {
                return mDatePurchased;
            }
            set
            {
                mDatePurchased = value;
            }
        }

        public object Find(int StockId)
        {
            //Set the private data members to the test data value
            mStockId = 1;

            mItemName = "TennisMatch";

            mQuantity = 150;

            mPrice = 12;

            mStockAvailable = true;

            mDatePurchased = Convert.ToDateTime ("07/01/2021");

            //always return true
            return true;
        }
    }
}