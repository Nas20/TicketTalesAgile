using System.Collections.Generic;
using System;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();
        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }

        public void ReportByName(string CustomerName)
        {
            //filters the records based on full or partial name
            //connects to the database
            clsDataConnection DB = new clsDataConnection();
            //send the name parameter to the database
            DB.AddParameter("@CustomerName", CustomerName);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByName");
            //populate the array list with the data table
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount = 0;
            //get the count of the record
            RecordCount = DB.Count;
            //clear the private array list
            mCustomerList = new List<clsCustomer>();
            //while there are records to process
            while (Index < RecordCount)
            {
                //create a blank customer
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsCustomerActive"]);
                ACustomer.BillingAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerBillingAddress"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDOB"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.Id = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.Pass = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPass"]);
                //add the record to the private data member
                mCustomerList.Add(ACustomer);
                //point at the next record
                Index++;

            }
        }
    

    

        //constructor for the class
        public clsCustomerCollection()
        {

           //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_SelectAll");
            //populate the array list with the data table
            PopulateArray(DB);
           

            
        }

        public void Delete()
        {
            //deletes the record pointed by thisCustomer
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@CustomerId", mThisCustomer.Id);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_Delete");
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerName", mThisCustomer.Name);
            DB.AddParameter("@CustomerEmail", mThisCustomer.Email);
            DB.AddParameter("@CustomerPass", mThisCustomer.Pass);
            DB.AddParameter("@CustomerBillingAddress", mThisCustomer.BillingAddress);
            DB.AddParameter("@CustomerDateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@CustomerActive", mThisCustomer.Active);

            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public clsCustomer ThisCustomer
        {
            get
            {
                return mThisCustomer;
            }


            set
            {
                mThisCustomer = value;
            }



        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerId", mThisCustomer.Id);
            DB.AddParameter("@CustomerName", mThisCustomer.Name);
            DB.AddParameter("@CustomerEmail", mThisCustomer.Email);
            DB.AddParameter("@CustomerPass", mThisCustomer.Pass);
            DB.AddParameter("@CustomerBillingAddress", mThisCustomer.BillingAddress);
            DB.AddParameter("@CustomerDateOfBirth", mThisCustomer.DateOfBirth);
            DB.AddParameter("@CustomerActive", mThisCustomer.Active);

            DB.Execute("sproc_tblCustomer_Update");
        }
    }

}


