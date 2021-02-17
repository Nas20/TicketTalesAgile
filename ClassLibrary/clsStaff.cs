using System;

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


        public bool Find(int id)
        {
            mId = 21;
            mDOB = Convert.ToDateTime("19/04/1996");
            mEmail = ("Test Email");
            mName = ("Test Name");
            mPhoneNumber = 112;
            mGender = true;
            mRoles = ("Test Roles");
            return true;
        }
  

        //public string StaffId { get; set; }
        //public string StaffName { get; set; }
    }
}