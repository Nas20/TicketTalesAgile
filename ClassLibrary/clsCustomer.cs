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

        public string Valid(string cDOB, string cName, string cEmail, string cBillingAddress, string cPass)
        {
            String Error = "";
            DateTime DateTemp;

            if (cName.Length == 0)
            {
                Error = Error + "The name may not be blank : ";
            }
            if (cName.Length > 50)
            {
                Error = Error + "The name must be less than 50 characters : ";
            }
           
            if (cEmail.Length == 0)
            {
                Error = Error + "The email may not be blank : ";
            }
            if (cEmail.Length > 50)
            {
                Error = Error + "The email must be less than 50 characters : ";
            }


            if (cPass.Length == 0)
            {
                Error = Error + "The password may not be blank : ";
            }
            if (cPass.Length > 60)
            {
                Error = Error + "The password must be less than 60 characters : ";
            }


            if (cBillingAddress.Length == 0)
            {
                Error = Error + "The billing address may not be blank : ";
            }
            if (cBillingAddress.Length > 100)
            {
                Error = Error + "The billing address must be less than 100 characters : ";
            }
            try
            {
                DateTemp = Convert.ToDateTime(cDOB);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }

            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            return Error;
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