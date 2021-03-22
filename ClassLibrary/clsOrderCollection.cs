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

        public clsOrderCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();
                AnOrder.Address = Convert.ToString(DB.DataTable.Rows[Index]["CustomerAddress"]);
                AnOrder.CustomerId = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                AnOrder.DateDispatch = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateofOrderDispatch"]);
                AnOrder.ItemName = Convert.ToString(DB.DataTable.Rows[Index]["ItemName"]);
                AnOrder.ItemQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemQuantity"]);
                AnOrder.Made = Convert.ToBoolean(DB.DataTable.Rows[Index]["OrderMade"]);
                AnOrder.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
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
            DB.AddParameter("@CustomerId", mThisOrder.CustomerId);
            DB.AddParameter("@CustomerAddress", mThisOrder.Address);
            DB.AddParameter("@DateOfOrderDispatch", mThisOrder.DateDispatch);
            DB.AddParameter("@ItemName", mThisOrder.ItemName);
            DB.AddParameter("@ItemQuantity", mThisOrder.ItemQuantity);
            DB.AddParameter("@OrderMade", mThisOrder.Made);
            //execute the query
            DB.Execute("sproc_tblOrder_update");
        }
    }
}