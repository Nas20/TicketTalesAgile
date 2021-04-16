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
    }
}
