using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing2
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void ReportByCustomerNameOK()
        {
        //create an instance of the class we want to create
        clsCustomerCollection AllCustomers = new clsCustomerCollection();
        //create an instance of the filtered data
        clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
        //apply a blank string(should return all records)
         FilteredCustomers.ReportByName("");
         //test to see that the two values are the same
         Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);

        }
        [TestMethod]
        public void ReportByNameDataFound()
        {
            //create an instance of the filtered data
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a name that doesnt exist
            FilteredCustomers.ReportByName("xxxxxx xxxxx");
            //check the correct number of records are found
            if(FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 30/33
                if (FilteredCustomers.CustomerList[0].Id != 30)
                 {
                    OK = false;
                }
                //check that the first record is ID 33
                if (FilteredCustomers.CustomerList[0].Id != 33)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            
        }
        [TestMethod]
        public void ReportByNameNoneFound()
        {
        //create an instance of the filtered data
       clsCustomerCollection FilteredCustomers = new clsCustomerCollection();
            //apply a name that doesnt exist
            FilteredCustomers.ReportByName("xxxxxx xxxxx");
            //test to see that there are no records
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //sets its properties
            TestItem.Active = true;
            TestItem.BillingAddress = "A Addresss LE33BA";
            TestItem.DateOfBirth = DateTime.Now.AddYears(-18);
            TestItem.Email = "A email @ hmail.com";
            TestItem.Id = 1;
            TestItem.Name = "A Name";
            TestItem.Pass = "A Pasword";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set the primary key of the test data
            TestItem.Id = PrimaryKey;
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //delete the record
            AllCustomers.Delete();
            //now find the record
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see of the record was not found
            Assert.IsFalse(Found);
        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.BillingAddress = "A Addresss LE33BA";
            TestItem.DateOfBirth = DateTime.Now.AddYears(-18);
            TestItem.Email = "A email @ hmail.com";
            TestItem.Id = 1;
            TestItem.Name = "A Name";
            TestItem.Pass = "A Pasword";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.Id = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);


        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestItem = new clsCustomer();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.BillingAddress = "A Addresss LE33BA";
            TestItem.DateOfBirth = DateTime.Now.AddYears(-18);
            TestItem.Email = "A email @ hmail.com";
            TestItem.Name = "A Name";
            TestItem.Pass = "A Pasword";
            AllCustomers.ThisCustomer = TestItem;
            PrimaryKey = AllCustomers.Add();
            TestItem.Id = PrimaryKey;

            TestItem.Active = false;
            TestItem.BillingAddress = "Another Addresss LE23BA";
            TestItem.DateOfBirth = DateTime.Now.AddYears(-18);
            TestItem.Email = "Another email @ hmail.com";
            TestItem.Name = "Another Name";
            TestItem.Pass = "Anothe Pasword";
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.BillingAddress = "Some billing address LE33DA";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestItem.Email = "some email @ hmail.com";
            TestItem.Id = 1;
            TestItem.Name = "Some name";
            TestItem.Pass = "Some password";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);


        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.Active = true;
            TestItem.BillingAddress = "Some billing address LE33DA";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestItem.Email = "Some email @ hmail.com";
            TestItem.Id = 1;
            TestItem.Name = "Some name";
            TestItem.Pass = "Some password";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.Active = true;
            TestCustomer.BillingAddress = "Some billing address LE33DA";
            TestCustomer.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestCustomer.Email = "some email @ hmail.com";
            TestCustomer.Id = 1;
            TestCustomer.Name = "Some name";
            TestCustomer.Pass = "Some password";
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);


        }
       
        
       
    }
}
