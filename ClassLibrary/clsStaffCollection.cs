using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                return mStaffList.Count;
            }
            set
            {

            }
        }
        public clsStaffCollection()
        {

            int Index = 2;
            int RecordCount = 2;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)

            {
                clsStaff AStaff = new clsStaff();
                AStaff.Id = System.Convert.ToInt32(DB.DataTable.Rows[0]["Id"]);
                AStaff.DOB = System.Convert.ToDateTime(DB.DataTable.Rows[0]["DOB"]);
                AStaff.Email = System.Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                AStaff.Name = System.Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                AStaff.PhoneNumber = System.Convert.ToInt32(DB.DataTable.Rows[0]["PhoneNumber"]);
                AStaff.Gender = System.Convert.ToBoolean(DB.DataTable.Rows[0]["Gender"]);
                AStaff.Roles = System.Convert.ToString(DB.DataTable.Rows[0]["Roles"]);
                mStaffList.Add(AStaff);
                Index++;
            }

            clsStaff TestItem = new clsStaff();

            TestItem.Id = 2;
            TestItem.Name = "Oskar Karcz";
            TestItem.Email = "oskar@gmail.com";
            TestItem.PhoneNumber = 112;
            TestItem.Roles = "Admin";
            TestItem.Gender = true;
            //TestItem.DOB = DateTime.Now.Date;
            mStaffList.Add(TestItem);
            TestItem = new clsStaff();



        }



        public clsStaff ThisStaff
        {
            get

            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }

        // public int Add()
        // {
        // mThisStaff.Id = 2;
        // return mThisStaff.Id;
        // }
        //}


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PhoneNumber", mThisStaff.PhoneNumber);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Roles", mThisStaff.Roles);
            DB.AddParameter("@DOB", mThisStaff.DOB);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@PhoneNumber", mThisStaff.PhoneNumber);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Roles", mThisStaff.Roles);
            DB.AddParameter("@DOB", mThisStaff.DOB);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            DB.Execute("sproc_tblStaff_Update");
        }

       
    }     
    }


      