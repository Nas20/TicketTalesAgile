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
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            PopulateArray(DB);
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

       public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Id", mThisStaff.Id);
            DB.Execute("sproc_tblStaff_Delete");          
        }

        public void ReportByStaffId(string Id)
        {           
               //filters the records based on full or partial name
                //connects to the database
                clsDataConnection DB = new clsDataConnection();
                //send the name parameter to the database
                DB.AddParameter("@Id", Id);
                //execute the stored procedure
                DB.Execute("sproc_tblStaff_FilteredByStaffId");
                PopulateArray(DB);
        }

    
           
           
            

            void PopulateArray(clsDataConnection DB)
            {
                int Index = 0;
                int RecordCount;                
                RecordCount = DB.Count;
                mStaffList = new List<clsStaff>();
                while (Index < RecordCount)
                {
                    clsStaff AStaff = new clsStaff();
                    AStaff.Id = System.Convert.ToInt32(DB.DataTable.Rows[Index]["Id"]);
                    AStaff.DOB = System.Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                    AStaff.Email = System.Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                    AStaff.Name = System.Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                    AStaff.PhoneNumber = System.Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneNumber"]);
                    AStaff.Gender = System.Convert.ToBoolean(DB.DataTable.Rows[Index]["Gender"]);
                    AStaff.Roles = System.Convert.ToString(DB.DataTable.Rows[Index]["Roles"]);
                    mStaffList.Add(AStaff);
                    Index++;
                }
                
                
        }
    }     
    }


      