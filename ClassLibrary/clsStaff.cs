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
            clsStaff DB = new clsStaff();
            DB.AddParameter("@Id", StaffId);
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            if(DB.Count == 1)
            {
                mId = Convert.ToInt32(DB.DataTable.Rows[0]["21"]);
                mDOB = Convert.ToDateTime(DB.DataTable.Rows[0]["19/04/1996"]();
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Test Email"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Test Name"]);
                mPhoneNumber = Convert.ToInt32(DB.DataTable.Rows[0]["112"]);
                mGender = Convert.ToBoolean(DB.DataTable.Rows[0]["Gender"]);
                mRoles = Convert.ToString(DB.DataTable.Rows[0]["Test Roles"]);
                return true;       
            }

            else
            {
                return false;
            }
        }
  

        //public string StaffId { get; set; }
        //public string StaffName { get; set; }
    }
}