using System;

namespace Testing4
{
    public class clsOrder
    {
        //set the private data members
        private Int32 mOrderId;
        private Int32 mCustomerId;
        private string mAddress;
        private DateTime mDateDispatch;
        private string mItemName;
        private Int32 mItemQuantity;
        private Boolean mMade;

        //public property for order id
        public int OrderId
        {
            get
            {
                //return private data
                return mOrderId;
            }
            set
            {
                //set private data
                mOrderId = value;
            }
        }

        //public property for customer address
        public string Address
        {
            get
            {
                //return private data
                return mAddress;
            }
            set
            {
                //set private data
                mAddress = value;
            }

        }

        //public property for dispatch date
        public DateTime DateDispatch
        {
            get
            {
                //return private data
                return mDateDispatch;
            }
            set
            {
                //set private data
                mDateDispatch = value;
            }
        }

        //public property for item name
        public string ItemName
        {
            get
            {
                //return private data
                return mItemName;
            }
            set
            {
                //set private data
                mItemName = value;
            }
        }

        //public property for item name
        public int ItemQuantity
        {
            get
            {
                //return private data
                return mItemQuantity;
            }
            set
            {
                //set private data
                mItemQuantity = value;
            }
        }
        //public bool Dispatched { get; internal set; }

        //public property for order made
        public bool Made
        {
            get
            {
                //return private data
                return mMade;
            }
            set
            {
                //set private data
                mMade = value;
            }
        }

        //public property for customer id
        public int CustomerId
        {
            get
            {
                //return private data
                return mCustomerId;
            }
            set
            {
                //set private data
                mCustomerId = value;
            }
        }

        //function for the public validation method
        public string Valid(string cId, string cAddress, string dDispatch, string iName, string iQuantity)
        //this function accepts 5 parameters for the validation
        //and returns a string containing a error message
        //if there are no errors found then a blank string is returned
        {
            //create data for error variable and create a test data for time and date
            String Error = "";
            DateTime DateTemp;
            //check to see if parameters are met
            if (cId.Length == 0)
            {
                //return error message if paramters are met
                Error = Error + "The Id may not be blank: ";
            }
            if (cAddress.Length == 0)
            {
                //return error message if paramters are met
                Error = Error + "The Address may not be blank: ";
            }

            if (cAddress.Length > 100)
            {
                //return error message if paramters are met
                Error = Error + "The Address must be less than 100 characters: ";
            }
            
            try
            {
                //set date variable to date value
                DateTemp = Convert.ToDateTime(dDispatch);
                if (DateTemp < DateTime.Now.Date)
                {
                    //return error message if paramters are met
                    Error = Error + "The date cannot be in the past: ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    //return error message if paramters are met
                    Error = Error + "The date cannot be in the future: ";
                }
            }
            catch
            {
                //return error message if everything before fails to be met
                Error = Error + "The date is an invalid date: ";

            }

            if (iName.Length == 0)
            {
                //return error message if paramters are met
                Error = Error + "The Item Name may not be blank: ";
            }

            if (iName.Length > 50)
            {
                //return error message if paramters are met
                Error = Error + "The Item Name must be less than 50: ";
            }

            try
            {
                if (Convert.ToInt32(iQuantity) == 0)
                {
                    //return error message if paramters are met
                    Error = Error + "The Item Quantity must not be blank: ";
                }

                if (Convert.ToInt32(iQuantity) > 100)
                {
                    //return error message if paramters are met
                    Error = Error + "The Item Quantity must be less than 100: ";
                }
            }

            catch
            {
                //return error message if everything before fails to be met
                Error = Error + "Please enter a numerical value: ";
            }
            //return error message variable
            return Error;
        }

        //function for public find method
        public bool Find(int OrderId)
        {
            //create an instance of the database connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the order id for the search
            DB.AddParameter("@OrderId", OrderId);
            //execute the stored procedure
            DB.Execute("sproc_tblOrder_FilterByOrderId");
            //check to see if a record is found
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mCustomerId = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerId"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerAddress"]);
                mDateDispatch = Convert.ToDateTime(DB.DataTable.Rows[0]["DateofOrderDispatch"]);
                mItemName = Convert.ToString(DB.DataTable.Rows[0]["ItemName"]);
                mItemQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ItemQuantity"]);
                mMade = Convert.ToBoolean(DB.DataTable.Rows[0]["OrderMade"]);
                //return that everything worked
                return true;
            }
            //if nothing is found
            else
            {
                //return false which means there's a problem
                return false;
            }
        }
    }
}