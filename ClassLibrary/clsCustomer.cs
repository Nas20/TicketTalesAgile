using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        private Int32 mId;
        private DateTime mDateOfBirth;
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
                return mDateOfBirth;
            }
            set
            {
                mDateOfBirth = value;
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
            mId = 3;
            mDateOfBirth = Convert.ToDateTime("16/09/2001");
            mBillingAddress = "Test Street";
            mPass = "Test Password";
            mName = "Test Name";
            mEmail = "Test Email @ email.com";
            mActive = true;
            return true;
        }
    }
}