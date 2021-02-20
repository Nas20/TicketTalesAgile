using System;

namespace Testing4
{
    public class clsOrder
    {
        private Int32 mOrderId;
        private Int32 mCustomerId;
        private string mAddress;
        private DateTime mDateDispatch;
        private string mItemName;
        private Int32 mItemQuantity;
        private Boolean mMade;
        public int OrderId
        {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }
        }
        public string Address {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }

        }
        public DateTime DateDispatch {
            get
            {
                return mDateDispatch;
            }
            set
            {
                mDateDispatch = value;
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
        public int ItemQuantity
        {
            get
            {
                return mItemQuantity;
            }
            set
            {
                mItemQuantity = value;
            }
        }
        public bool Dispatched { get; internal set; }
        public bool Made
        {
            get
            {
                return mMade;
            }
            set
            {
                mMade = value;
            }
        }
        public int CustomerId {
            get
            {
                return mCustomerId;
            }
            set
            {
                mCustomerId = value;
            }
        }

        public bool Find(int OrderId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", OrderId);
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            if (DB.Count == 1)
            { 
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mDateDispatch = Convert.ToDateTime(DB.DataTable.Rows[0]["DateofOrderDispatch"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mItemQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ItemQuantity"]);
                mMade = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderMade"]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}