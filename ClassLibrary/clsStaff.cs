using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }

        //set the private data members 
        private string mEmail;
        private DateTime mDOB;
        private string mName;
        private string mRoles;
        private bool mGender;
        private int mPhoneNumber;
        private Int32 mId;


        //public property
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

        

        //public property
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

       

        //public property
        public string Roles
        {
            get
            {
                //return private data
                return mRoles;
            }
            set
            {
                //set private data 
                mRoles = value;
            }
        }


 

        //public property
        public DateTime DOB
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

    

        //public property
        public bool Gender
        {
            get
            {
                //return private data
                return mGender;
            }
            set
            {
                //set private data 
                mGender = value;
            }
        }


        //public property
        public int PhoneNumber
        {
            get
            {
                //return private data
                return mPhoneNumber;
            }
            set
            {
                //set private data 
                mPhoneNumber = value;
            }
        }

        

        //public property
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


        public bool Find(int Id)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the id to search for
            DB.AddParameter("@Id", Id);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterById");
            //if one record is found(should be either 1 or 0)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mId = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneNumber"]);
                mGender = Convert.ToBoolean(DB.DataTable.Rows[0]["Gender"]);
                mRoles = Convert.ToString(DB.DataTable.Rows[0]["Roles"]);
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

        //public string StaffId { get; set; }
        //public string StaffName { get; set; }


        //function for the public validation method
        public string Valid(string Name, string Email, string DOB, string Roles, string PhoneNumber)
        {
            //this function accepts 5 parameters for the validation
            //returns a string containing a error message
            //no errors found then a blank string is returned

            //create a string variable to store the error
            String Error = "";

            //if the roles field is blank
            if (Roles.Length == 0)
            {
                //display invaled role message
                Error = Error + "Invalid Role : ";
            }
            //if roles is more than 50 characters
            if (Roles.Length > 50)
            {
                //display the message - The Roles field should be less than 50 characters 
                Error = Error + "The Roles field should be less than 50 characters : ";
            }
            //if email field is blank
            if (Email.Length == 0)
            {
                //record error
                Error = Error + "The email field must not be blank : ";
            }
            //if email field is more than 50 characters
            if (Email.Length > 50)
            {
                //record error
                Error = Error + "The email field  must be less than 50 characters : ";
            }
            //if name field is blank
            if (Name.Length == 0)
            {
                //record error
                Error = Error + "The name field  must not be blank : ";
            }
            //if name field is more than 50 characters
            if (Name.Length > 50)
            {
                //record error
                Error = Error + "The name field  must be less than 50 characters : ";
            }
            //if phone number field is blank
            if (PhoneNumber.Length == 0)
            {
                //record error
                Error = Error + "The phone number field  must not be blank : ";
            }
            //if phone number field is more than 50 characters
            if (PhoneNumber.Length > 50)
            {
                //record error
                Error = Error + "The phone number field  must be less than 50 characters : ";
            }
            //record error
            return Error;
        }

    }      
}