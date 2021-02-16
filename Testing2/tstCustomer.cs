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
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Int32 CustomerId = 3;
            Found = ACustomer.Find(CustomerId);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestCustomerIDNoFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 3;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.Id != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerDOBFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 3;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.DateOfBirth != Convert.ToDateTime("16/09/2001"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerPassFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 3;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.Pass != ("Test Password"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 3;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.Email != ("Test Email @ email.com"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerActiveFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 3;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.Active != (true))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 3;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.Name != ("Test Name"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        public void TestCustomerBillingAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerId = 3;
            Found = ACustomer.Find(CustomerId);
            if (ACustomer.BillingAddress != ("Test Street"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}


