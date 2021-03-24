using System;
using System.Collections.Generic;
using Testing4;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
        clsOrder mThisOrder = new clsOrder();
        public List<clsOrder> OrderList
        {
            get
            {
                return mOrderList;
            }

            set
            {
                mOrderList = value;
            }
        }
        public int Count
        {
            get
            {
                return mOrderList.Count;
            }

            set
            {
                //worry later
            }
        }
        public void ReportByItemName(string ItemName)
        {
            //filters the record based on a full or partial Item Name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //send the Item Name parameter to the database
            DB.AddParameter("@ItemName", ItemName);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByItemName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count;
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear the private array list
            mOrderList = new List<clsOrder>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank Order
                clsOrder AnOrder = new clsOrder();
                //read in the fields from the current record
                AnOrder.Made = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderMade"]);
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.Address = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                AnOrder.DateDispatch = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateofOrderDispatch"]);
                AnOrder.ItemName = Convert.ToString(DB.DataTable.Rows[Index]["ItemName"]);
                AnOrder.ItemQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemQuantity"]);
                //add the record to the private data member
                mOrderList.Add(AnOrder);
                //point at the next record
                Index++;
            }
        }

        //constructor for the class
        public clsOrderCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_SelectAll");
            //populate the array with the data table
            PopulateArray(DB);
        }

        public int Add()
        {
            //add new record and connect to database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@CustomerAddress", mThisOrder.Address);
            DB.AddParameter("@DateOfOrderDispatch", mThisOrder.DateDispatch);
            DB.AddParameter("@ItemName", mThisOrder.ItemName);
            DB.AddParameter("@ItemQuantity", mThisOrder.ItemQuantity);
            DB.AddParameter("@OrderMade", mThisOrder.Made);
            //execute the query
            return DB.Execute("sproc_tblOrder_Insert");
        }


        public clsOrder ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }
        }

        public void Update()
        {
            //update an existing record based on the values of ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@CustomerAddress", mThisOrder.Address);
            DB.AddParameter("@DateOfOrderDispatch", mThisOrder.DateDispatch);
            DB.AddParameter("@ItemName", mThisOrder.ItemName);
            DB.AddParameter("@ItemQuantity", mThisOrder.ItemQuantity);
            DB.AddParameter("@OrderMade", mThisOrder.Made);
            //execute the query
            DB.Execute("sproc_tblOrder_update");
        }

        public void Delete()
        {
            //deletes the record pointed to by ThisOrder
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@OrderId", mThisOrder.OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_Delete");
        }

       
    }
}