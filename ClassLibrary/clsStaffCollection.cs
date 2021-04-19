using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection 
    {
        //private data member for the list
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff();

        //public property for the staff list
        public List<clsStaff> StaffList
        {
            get
            {
                //return the private data
                return mStaffList;
            }
            set
            {
                //set the private data
                mStaffList = value;
            }
        }
        public int Count
        {
            get
            {
                //return the private data
                return mStaffList.Count;
            }
            set
            {

            }
        }

        //constructor for the class
        public clsStaffCollection()
        {
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
        }
          

        public clsStaff ThisStaff
        {
            get

            {
                //return the private data
                return mThisStaff;
            }
            set
            {
                //set the private data
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
            //adds a new record to the database based on the value of ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PhoneNumber", mThisStaff.PhoneNumber);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Roles", mThisStaff.Roles);
            DB.AddParameter("@DOB", mThisStaff.DOB);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            //execute the query returning the primary key value
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            //adds a new record to the database based on the value of ThisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@PhoneNumber", mThisStaff.PhoneNumber);
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Roles", mThisStaff.Roles);
            DB.AddParameter("@DOB", mThisStaff.DOB);
            DB.AddParameter("@Gender", mThisStaff.Gender);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Update");
        }

       public void Delete()
        {
            //deletes the record pointed by thisStaff
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@Id", mThisStaff.Id);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_Delete");          
        }

        public void ReportByStaffName(string Name)
        {           
                //filters the records based on staff Id
                //connects to the database
                clsDataConnection DB = new clsDataConnection();
                //send the name parameter to the database
                DB.AddParameter("@Name", Name);
                //execute the stored procedure
                DB.Execute("sproc_tblStaff_FilteredByStaffName");
                //populate the array list with the data table
                PopulateArray(DB);
        }
       
            void PopulateArray(clsDataConnection DB)
            {

                //populates the array list based on the data table in the parameter DB
                //var for the index
                int Index = 0;
                //var to store the record count
                int RecordCount;
                //get the count of the record
                RecordCount = DB.Count;
                //clear the private array list
                mStaffList = new List<clsStaff>();
                //while there are records to process
                while (Index < RecordCount)
                {
                    //create a blank staff record
                    clsStaff AStaff = new clsStaff();
                    AStaff.Id = System.Convert.ToInt32(DB.DataTable.Rows[Index]["Id"]);
                    AStaff.DOB = System.Convert.ToDateTime(DB.DataTable.Rows[Index]["DOB"]);
                    AStaff.Email = System.Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                    AStaff.Name = System.Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                    AStaff.PhoneNumber = System.Convert.ToInt32(DB.DataTable.Rows[Index]["PhoneNumber"]);
                    AStaff.Gender = System.Convert.ToBoolean(DB.DataTable.Rows[Index]["Gender"]);
                    AStaff.Roles = System.Convert.ToString(DB.DataTable.Rows[Index]["Roles"]);
                    //add the record to the private data member
                    //point at the next record
                    mStaffList.Add(AStaff);
                    Index++;
                }
                
                
        }
    }     
    }


      