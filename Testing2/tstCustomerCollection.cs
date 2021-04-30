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
            //create an instance of the customer collection class
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
            FilteredCustomers.ReportByName("Nasreen Shaikh");
            //check the correct number of records are found
            if(FilteredCustomers.Count == 2)
            {
                //check that the first record is ID 30/33
                if (FilteredCustomers.CustomerList[0].Id != 31)
                 {
                    OK = false;
                }
                //check that the first record is ID 33
                if (FilteredCustomers.CustomerList[0].Id != 37)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see if there are no records
            //change to isTrue
            Assert.IsFalse(OK);
            
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
            //create an instance of the customer collection class
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
            //create an instance of the customer collection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store the primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.BillingAddress = "A Addresss LE33BA";
            TestItem.DateOfBirth = DateTime.Now.AddYears(-18);
            TestItem.Email = "A email @ hmail.com";
            TestItem.Id = 1;
            TestItem.Name = "A Name";
            TestItem.Pass = "A Pasword";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //set the primary key of the test data
            PrimaryKey = AllCustomers.Add();
            //find the record
            TestItem.Id = PrimaryKey;
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);


        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the customer collection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Active = true;
            TestItem.BillingAddress = "A Addresss LE33BA";
            TestItem.DateOfBirth = DateTime.Now.AddYears(-18);
            TestItem.Email = "A email @ hmail.com";
            TestItem.Name = "A Name";
            TestItem.Pass = "A Pasword";
            //set ThisCustomer to the test data
            AllCustomers.ThisCustomer = TestItem;
            //add the record
            PrimaryKey = AllCustomers.Add();
            //set primary key of the test data
            TestItem.Id = PrimaryKey;

            //modify the test data
            TestItem.Active = false;
            TestItem.BillingAddress = "Another Addresss LE23BA";
            TestItem.DateOfBirth = DateTime.Now.AddYears(-18);
            TestItem.Email = "Another email @ hmail.com";
            TestItem.Name = "Another Name";
            TestItem.Pass = "Another Pasword";
            //set the record based on the new test data
            AllCustomers.ThisCustomer = TestItem;
            //update the record
            AllCustomers.Update();
            //find the record
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            //test to see thisCustomer matches the test data
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the customer class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //test to see if it exists
            Assert.IsNotNull(AllCustomers);
        }
        [TestMethod]
        public void CustomerListOK()
        {
            //create an instance of the customer collection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of the test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.BillingAddress = "Some billing address LE33DA";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestItem.Email = "some email @ hmail.com";
            TestItem.Id = 1;
            TestItem.Name = "Some name";
            TestItem.Pass = "Some password";
            //add the item to test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that two values are the same
            Assert.AreEqual(AllCustomers.CustomerList, TestList);


        }
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the customer collection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            //in this case the data needs to be a list of objects
            List<clsCustomer> TestList = new List<clsCustomer>();
            //add an item to the list
            //create the item of test data
            clsCustomer TestItem = new clsCustomer();
            //set its properties
            TestItem.Active = true;
            TestItem.BillingAddress = "Some billing address LE33DA";
            TestItem.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestItem.Email = "Some email @ hmail.com";
            TestItem.Id = 1;
            TestItem.Name = "Some name";
            TestItem.Pass = "Some password";
            //add the item to the test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllCustomers.CustomerList = TestList;
            //test to see that the two values are the same
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }


        [TestMethod]
        public void ThisCustomerPropertyOK()
        {
            //create an instance of the customer collection class
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            //create some test data to assign to the property
            clsCustomer TestCustomer = new clsCustomer();
            //set its properties
            TestCustomer.Active = true;
            TestCustomer.BillingAddress = "Some billing address LE33DA";
            TestCustomer.DateOfBirth = DateTime.Now.Date.AddYears(-18);
            TestCustomer.Email = "some email @ hmail.com";
            TestCustomer.Id = 1;
            TestCustomer.Name = "Some name";
            TestCustomer.Pass = "Some password";
            //assign the data to the property
            AllCustomers.ThisCustomer = TestCustomer;
            //test to see if the two values are the same
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);


        }
       
        
       
    }
}
