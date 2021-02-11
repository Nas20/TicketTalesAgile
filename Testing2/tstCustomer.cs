using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void IsCustomerActiveOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.Active = TestData;
            Assert.AreEqual(ACustomer.Active, TestData);
        }
        [TestMethod]
        public void DateOfBirthOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateOfBirth = TestData;
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);

        }
        [TestMethod]
        public void BillingAddressOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "21b";
            ACustomer.BillingAddress = TestData;
            Assert.AreEqual(ACustomer.BillingAddress, TestData);
        }
        [TestMethod]
        public void EmailOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "nasreen.shaikh@hotmail.com";
            ACustomer.Email = TestData;
            Assert.AreEqual(ACustomer.Email, TestData);
        }
        [TestMethod]
        public void NameOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "nasreen shaikh";
            ACustomer.Name = TestData;
            Assert.AreEqual(ACustomer.Name, TestData);
        }
        [TestMethod]
        public void PassOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "n21345gh";
            ACustomer.Pass = TestData;
            Assert.AreEqual(ACustomer.Pass, TestData);
        }
        [TestMethod]
        public void IdOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            int TestData = 1;
            ACustomer.Id = TestData;
            Assert.AreEqual(ACustomer.Id, TestData);
        }
    }
}
