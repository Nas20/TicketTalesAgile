using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStockCollection
    {
        //Private data member for the stock
        List<clsStock> mStockList = new List<clsStock>();
        //Private data member for stock list
        clsStock mThisStock = new clsStock();
        public List<clsStock> StockList
        {
            get
            {
                //return for the private data
                return mStockList;
            }
            set
            {
                //set the private data 
                mStockList = value;
            }
        }

        public clsStock ThisStock
        {
            get
            {
                //return the private data
                return mThisStock;
            }
            set
            {
                //set the private data
                mThisStock = value;
            }

        }
        //public property for the count 
        public int Count
        {
            get
            {
                //return the private data
                return mStockList.Count;
            }

            set
            {
                //We will worry about this later;
            }
        }

        public int Add()
        {
            //adds a new record to the database based on the value of ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ItemName", mThisStock.ItemName);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@StockPrice", mThisStock.StockPrice);
            DB.AddParameter("@DatePurchased", mThisStock.DatePurchased);
            DB.AddParameter("@StockAvailable", mThisStock.StockAvailable);
            DB.AddParameter("@StockActive", mThisStock.Active);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStock_Insert");

        }

        public void Update()
        {
            //adds a new record to the database based on the value of ThisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters
            DB.AddParameter("@StockId", mThisStock.StockId);
            DB.AddParameter("@ItemName", mThisStock.ItemName);
            DB.AddParameter("@Quantity", mThisStock.Quantity);
            DB.AddParameter("@StockPrice", mThisStock.StockPrice);
            DB.AddParameter("@StockAvailable", mThisStock.StockAvailable);
            DB.AddParameter("@StockActive", mThisStock.Active);

            //execute the stored procedure
            DB.Execute("sproc_tblStock_Update");
        }

        public void Delete()
        {
            //deletes the record pointed by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@StockId", mThisStock.StockId);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_Delete");
        }

        public clsStockCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStock_SelectAll");
            //Populate the array list with the data table
            PopulateArray(DB);
        }

        public void ReportByItemName(string ItemName)
        {
            //Filters the record based on a full or partial ItemName.
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //send the name parameter to the database
            DB.AddParameter("@ItemName", ItemName);
            //execute the stored procedure
            DB.Execute("sproc_tblStock_FilterByItemName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of the record
            RecordCount = DB.Count;
            //clear the private array list
            mStockList = new List<clsStock>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsStock AStock = new clsStock();
                //AStock.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsActive"]);
                AStock.StockId = Convert.ToInt32(DB.DataTable.Rows[Index]["StockId"]);
                AStock.ItemName = Convert.ToString(DB.DataTable.Rows[Index]["ItemName"]);
                AStock.Quantity = Convert.ToInt32(DB.DataTable.Rows[Index]["Quantity"]);
                AStock.DatePurchased = Convert.ToDateTime(DB.DataTable.Rows[Index]["DatePurchased"]);
                AStock.StockPrice = Convert.ToDecimal(DB.DataTable.Rows[Index]["StockPrice"]);
                //add the record to the private data member
                mStockList.Add(AStock);
                //point at the next record
                Index++;

            }
        }
    }
}
