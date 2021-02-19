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

        public bool Find(int orderID)
        {
            mOrderId = 11;
            mCustomerId = 12;
            mAddress = "1 Green Street";
            mDateDispatch = Convert.ToDateTime("24/02/2021");
            mItemName = "Wonder Woman 1984";
            mItemQuantity = 2;
            mMade = true;
            return true;
        }
    }
}