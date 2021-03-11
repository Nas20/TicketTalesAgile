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
        public Decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = Convert.ToDecimal(value);
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

        public Boolean Find(int StockId)
        {
            //create an instance of data connection
            //add the parameter for the stock id to match
            //execute the stored procedure
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@StockId", StockId);
            DB.Execute("sproc_tblStock_FilterByStockId");
            if (DB.Count == 1)
            {
                //Set the private data members to the test data value
                mStockId = Convert.ToInt32(DB.DataTable.Rows[0]["StockId"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["Quantity"]);
                mPrice = Convert.ToDecimal(DB.DataTable.Rows[0]["StockPrice"]);
                mStockAvailable = Convert.ToBoolean(DB.DataTable.Rows[0]["StockAvailable"]);
                mDatePurchased = Convert.ToDateTime(DB.DataTable.Rows[0]["DatePurchased"]);
                //always return true
                return true;
            }
            else
            {
                return false;
            }

        }

        /**
         * 
         * WK21
         */

        public string Valid(string StockId, string ItemName, string Quantity, string Price, string StockAvailable, string DatePurchased)
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