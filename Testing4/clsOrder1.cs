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
        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }

        }
        public DateTime DateDispatch
        {
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
        //public bool Dispatched { get; internal set; }
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
        public int CustomerId
        {
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

        public string Valid(string cId, string cAddress, string dDispatch, string iName, string iQuantity)
        {
            String Error = "";
            DateTime DateTemp;
            if (cId.Length == 0)
            {
                Error = Error + "The Id may not be blank: ";
            }

            if (cAddress.Length == 0)
            {
                Error = Error + "The Address may not be blank: ";
            }

            if (cAddress.Length > 100)
            {
                Error = Error + "The Address must be less than 100 characters: ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(dDispatch);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past: ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                Error = Error + "The date is an invalid date: ";
            }

            if (iName.Length == 0)
            {
                Error = Error + "The Item Name may not be blank: ";
            }

            if (iName.Length > 50)
            {
                Error = Error + "The Item Name must be less than 50: ";
            }

            try
            {
                if (Convert.ToInt32(iQuantity) == 0)
                {
                    Error = Error + "The Item Quantity must not be blank: ";
                }

                if (Convert.ToInt32(iQuantity) > 100)
                {
                    Error = Error + "The Item Quantity must be less than 100: ";
                }
            }

            catch
            {
                Error = Error + "Please enter a numerical value: ";
            }
            return Error;
        }
    }
}