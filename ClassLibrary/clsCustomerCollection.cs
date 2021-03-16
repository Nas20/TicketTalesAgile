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
        public clsCustomerCollection()
        {

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCustomer_SelectAll");
            RecordCount = DB.Count;

            while (Index < RecordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["IsCustomerActive"]);
                ACustomer.BillingAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerBillingAddress"]);
                ACustomer.DateOfBirth = Convert.ToDateTime(DB.DataTable.Rows[Index]["CustomerDOB"]);
                ACustomer.Email = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.Id = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerId"]);
                ACustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                ACustomer.Pass = Convert.ToString(DB.DataTable.Rows[Index]["CustomerPass"]);
                mCustomerList.Add(ACustomer);
                Index++;

            }
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


