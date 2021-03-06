﻿using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public bool Active { get; set; }

        private string mEmail;
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

        private string mName;
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

        private string mRoles;
        public string Roles
        {
            get
            {
                return mRoles;
            }
            set
            {
                mRoles = value;
            }
        }


        private DateTime mDOB;
        public DateTime DOB
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

        private bool mGender;
        public bool Gender
        {
            get
            {
                return mGender;
            }
            set
            {
                mGender = value;
            }
        }

        private int mPhoneNumber;
        public int PhoneNumber
        {
            get
            {
                return mPhoneNumber;
            }
            set
            {
                mPhoneNumber = value;
            }
        }

        //private member variable
        private Int32 mId;
        //public property
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


        public bool Find(int Id)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", Id);
            DB.Execute("sproc_tblStaff_FilterById");
            if (DB.Count == 1)
            {
                mId = Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["PhoneNumber"]);
                mGender = Convert.ToBoolean(DB.DataTable.Rows[0]["Gender"]);
                mRoles = Convert.ToString(DB.DataTable.Rows[0]["Roles"]);
                return true;
            }
            else
            {
                return false;
            }
        }
        //public string StaffId { get; set; }
        //public string StaffName { get; set; }

        public string Valid(string Name, string Email, string DOB, string Roles, string PhoneNumber)
        {
            String Error = "";
            if (Roles.Length == 0)
            {
                Error = Error + "Invalid Role : ";
            }
            if (Roles.Length > 50)
            {
                Error = Error + "The Roles field should be less than 15 characters : ";
            }

            if (Email.Length == 0)
            {
                Error = Error + "The email field must not be blank : ";
            }
            if (Email.Length > 50)
            {
                Error = Error + "The email field  must be less than 50 characters : ";
            }

            if (Name.Length == 0)
            {
                Error = Error + "The name field  must not be blank : ";
            }
            if (Name.Length > 50)
            {
                Error = Error + "The name field  must be less than 50 characters : ";
            }
            if (PhoneNumber.Length == 0)
            {
                Error = Error + "The phone number field  must not be blank : ";
            }
            if (PhoneNumber.Length > 50)
            {
                Error = Error + "The phone number field  must be less than 50 characters : ";
            }
            return Error;
        }

    }      
}