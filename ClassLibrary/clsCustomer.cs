using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        //set the private data members 
        private Int32 mId;
        private DateTime mDOB;
        private string mBillingAddress;
        private string mPass;
        private Boolean mActive;
        private string mName;
        private string mEmail;
        
        //public property for customer active
        public bool Active
        {
            get
            {
                //return private data
                return mActive;
            }
            set
            {
                //set private data 
                mActive = value;
            }
        }
        //function for the public validation method
        public string Valid(string cName, string cDOB, string cEmail, 
            string cBillingAddress, string cPass)
            //this function accepts 5 parameters for the validation
            //returns a string containing a error message
            //no errors found then a blank string is returned
        {
            //create a string variable to store the error
            String Error = "";
            //create a datetime varaible to stre the temp date
            DateTime DateTemp;

            //if name is blank
            if (cName.Length == 0)
            {
                //record error
                Error = Error + "The name must not be blank : ";
            }
            //if name is more than 50 characters
            if (cName.Length > 50)
            {
                //record error
                Error = Error + "The name must be less than 50 characters : ";
            }
           //if email is blank
            if (cEmail.Length == 0)
            {
                //record error
                Error = Error + "The email must not be blank : ";
            }
            //if email is more than 50 characters
            if (cEmail.Length > 50)
            {
                //record error
                Error = Error + "The email must be less than 50 characters : ";
            }

            //if password is blank
            if (cPass.Length == 0)
            {
                //record error
                Error = Error + "The password must not be blank : ";
            }
            //if password is more than 60 characters
            if (cPass.Length > 60)
            {
                //record error
                Error = Error + "The password must be less than 60 characters : ";
            }

            //if billing address is blank
            if (cBillingAddress.Length == 0)
            {
                //record error
                Error = Error + "The billing address must not be blank : ";
            }
            //if password is more than 100 characters
            if (cBillingAddress.Length > 100)
            {
                //record error
                Error = Error + "The billing address must be less than 100 characters : ";
            }
            try
            {
                //copy the dateofbirth value to the dateTemp variable
                DateTemp = Convert.ToDateTime(cDOB);
                if (DateTemp < DateTime.Now.Date.AddYears(-100))
                {
                    //record the error
                    Error = Error + "Don't qualify, too old : ";
                }
                //check to see if the date is greater than 18 years
                if (DateTemp > DateTime.Now.Date.AddYears(-18))
                {
                    //record the error
                    Error = Error + "Don't qualify, too young : ";
                }

            }
            catch
            {
                //record the error
                Error = Error + "The date was not a valid date : ";
            }
            //return error messafe
            return Error;
        }
        //public property for customer date of birth
        public DateTime DateOfBirth
        {
            get
            {
                //return private data
                return mDOB;
            }
            set
            {
                //set private data 
                mDOB = value;
            }
        }
        //public property for customer billing address
        public string BillingAddress
        {
            get
            {
                //return private data
                return mBillingAddress;
            }
            set
            {
                //set private data
                mBillingAddress = value;
            }
        }
        //public property for customer email
        public string Email
        {
            get
            {
                //return private data
                return mEmail;
            }
            set
            {
                //set private data
                mEmail = value;
            }
        }
        //public property for customer name
        public string Name
        {
            get
            {
                //return private data
                return mName;
            }
            set
            {
                //set private data
                mName = value;
            }
        }
        //public property for customer password
        public string Pass
        {
            get
            {
                //return private data
                return mPass;
            }
            set
            {
                //set private data
                mPass = value;
            }
        }
        //public property for customer Id
        public Int32 Id
        {
            get
            {
                //return private data
                return mId;
            }
            set
            {
                //set private data
                mId = value;
            }
        }

        public bool Find(int customerId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the id to search for
            DB.AddParameter("@CustomerId", customerId);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerId");
            //if one record is found(should be either 1 or 0)
            if(DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["CustomerDOB"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mPass = Convert.ToString(DB.DataTable.Rows[0]["CustomerPass"]);
                mBillingAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerBillingAddress"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["IsCustomerActive"]);
                //return that everything worked
                return true;
            }
            //if no record is found
            else
            {
                //return false which indicates a problem
                return false;
            }
            
        }
    }
}