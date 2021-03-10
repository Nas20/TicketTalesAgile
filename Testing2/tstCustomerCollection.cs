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
