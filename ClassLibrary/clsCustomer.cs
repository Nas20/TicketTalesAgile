using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mId;
        private DateTime mDOB;
        private string mBillingAddress;
        private string mPass;
        private Boolean mActive;
        private string mName;
        private string mEmail;
        

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public DateTime DateOfBirth
        {
            get
            {
                return mDOB;
            }
            set
            {
                mDOB = value;
            }
        }
        public string BillingAddress
        {
            get
            {
                return mBillingAddress;
            }
            set
            {
                mBillingAddress = value;
            }
        }
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }
        public string Pass
        {
            get
            {
                return mPass;
            }
            set
            {
                mPass = value;
            }
        }
        public Int32 Id
        {
            get
            {
                return mId;
            }
            set
            {
                mId = value;
            }
        }

        public bool Find(int customerId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", customerId);
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            if(DB.Count == 1)
            {
                mId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mPass = Convert.ToString(DB.DataTable.Rows[0]["CustomerPass"]);
                mBillingAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerBillingAddress"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsCustomerActive"]);
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}