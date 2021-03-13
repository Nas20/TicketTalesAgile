using System;
using System.Collections.Generic;
using Testing4;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        List<clsOrder> mOrderList = new List<clsOrder>();
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
        public clsOrder ThisOrder { get; set; }
    }
}