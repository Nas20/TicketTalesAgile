using System;

namespace ClassLibrary
{
    public class clsStock
    {
        //set the private data members
        private Int32 mStockId;
        private string mItemName;
        private int mQuantity;
        private Decimal mStockPrice;
        private Boolean mStockAvailable;
        private DateTime mDatePurchased;
        private Boolean mActive;

        //public property for stock Id
        public Int32 StockId
        {
            get
            {
                //return private data
                return mStockId;
            }
            set
            {
                //set private data
                mStockId = value;
            }
        }
        //public property for stock Item Name
        public string ItemName
        {
            get
            {
                //return private data
                return mItemName;
            }
            set
            {
                //set private data
                mItemName = value;
            }
        }

        public string Valid(string stockId, string itemName, string quantity, string stockprice, string datePurchased)
        {
            throw new NotImplementedException();
        }
        //public property for stock Quantity
        public int Quantity
        {
            get
            {
                //return private data
                return mQuantity;
            }
            set
            {
                //set private data
                mQuantity = value;
            }
        }

        //public property for stock StockPrice
        public Decimal StockPrice
        {
            get
            {
                //return private data
                return mStockPrice;
            }
            set
            {
                //set private data
                mStockPrice = Convert.ToDecimal(value);
            }
        }

        //public property for stock StockAvailable
        public bool StockAvailable
        {
            get
            {
                //return private data
                return mStockAvailable;
            }
            set
            {
                //set private data
                mStockAvailable = value;
            }
        }

        //public property for stock DatePurchased
        public DateTime DatePurchased
        {
            get
            {
                //return private data
                return mDatePurchased;
            }
            set
            {
                //set private data
                mDatePurchased = value;
            }
        }

        public bool Active
        {
            get
            {
                //return private data
                return mActive;
            }
            set
            {
                //set private data 
                mActive = value;
            }
        }

        public Boolean Find(int StockId)
        {
            //create an instance of data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the stock id to match
            DB.AddParameter("@StockId", StockId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByStockId");
            if (DB.Count == 1)
            {
                //Set the private data members to the test data value
                mStockId = Convert.ToInt32(DB.DataTable.Rows[0]["StockId"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mStockPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["StockPrice"]);
                mStockAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["StockAvailable"]);
                mDatePurchased = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePurchased"]);
                //always return true
                return true;
            }
            //if no record is found
            else
            {
                //returns false which indicates there is a problem. 
                return false;
            }

        }

        public string Valid(string StockId, string ItemName, string Quantity, string StockPrice, string StockAvailable, string DatePurchased)
        {
            String Error = "";
            DateTime DateTemp;

            if (StockId.Length == 0)
            {
                Error = Error + "The Stock Id may not be blank :";
            }
            if (StockId.Length > 6)
            {
                Error = Error + "The Stock Id must be less that 6 Characters :";
            }

            if (ItemName.Length == 0)
            {
                Error = Error + "The Item Name must not be blank : ";
            }
            if (ItemName.Length > 50)
            {
                Error = Error + "The Item Name must be less than 50 Characters : ";
            }

            if (Quantity.Length == 0)
            {
                Error = Error + "The Quantity must not be blank : ";
            }
            if (Quantity.Length > 10)
            {
                Error = Error + "The Quantity must be less than 10 Characters : ";
            }

            if (StockPrice.Length == 0)
            {
                Error = Error + "The Price must not be blank : ";
            }
            if (StockPrice.Length > 10)
            {
                Error = Error + "The Price must be less than 10 Characters : ";
            }

            if (StockAvailable.Length == 0)
            {
                Error = Error + "The Stock Available must not be blank : ";
            }
            if (StockAvailable.Length > 500)
            {
                Error = Error + "The Stock Available must be less than 500 Characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(DatePurchased);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past :";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date";
            }
            return Error;
        }
    }
}