using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {

        string CName = "A Name";
        string CBillingAddress = "A Address LE567B";
        string CPass = "Hnahsn34";
        string CEmail = "name @ hotmail.com";
        string CDOB = DateTime.Now.Date.ToString();

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CName = "";
            Error= ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CName = "N";
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CName = "Nn";
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CName = "";
            CName = CName.PadRight(49, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CName = "";
            CName = CName.PadRight(50, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CName = "";
            CName = CName.PadRight(25, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CName = "";
            CName = CName.PadRight(51, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CName = "";
            CName = CName.PadRight(500, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreNotEqual(Error, "");
        }
       
        [TestMethod]
        public void CustomerDateOfBirthExtremeMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string CDOB = TestDate.ToString();
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthMinLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string CDOB = TestDate.ToString();
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string CDOB = TestDate.ToString();
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthMinPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string CDOB = TestDate.ToString();
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthExtremeMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string CDOB = TestDate.ToString();
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthInvalidData()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CDOB = "This is not a date!";
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CEmail = "";
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CEmail = "N";
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CEmail = "Nn";
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CEmail = "";
            CEmail = CEmail.PadRight(49, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CEmail = "";
            CEmail = CEmail.PadRight(50, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CEmail = "";
            CEmail = CEmail.PadRight(25, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CEmail = "";
            CEmail = CEmail.PadRight(51, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreNotEqual(Error, "");
        }
       
         [TestMethod]
        public void CustomerPassLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CPass = "";
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPassMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CPass = "N";
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CPass = "Nn";
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPassMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CPass = "";
            CPass = CPass.PadRight(59, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPassMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CPass = "";
            CPass = CPass.PadRight(60, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPassMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CPass = "";
            CPass = CPass.PadRight(30, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPassMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CPass = "";
            CPass = CPass.PadRight(61, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreNotEqual(Error, "");
        }
       
        [TestMethod]
        public void CustomerBllingAddressMin()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CBillingAddress = "N";
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerBillingAddressPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CBillingAddress = "Nn";
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerBillingAddressMaxLessOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CBillingAddress = "";
            CBillingAddress = CBillingAddress.PadRight(99, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerBillingAddressMax()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CBillingAddress = "";
            CBillingAddress = CBillingAddress.PadRight(100, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerBillingAddressMid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CBillingAddress = "";
            CBillingAddress = CBillingAddress.PadRight(50, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            string CBillingAddress = "";
            CBillingAddress = CBillingAddress.PadRight(101, 'n');
            Error = ACustomer.Valid(CDOB, CName, CEmail, CBillingAddress, CPass);
            Assert.AreNotEqual(Error, "");
        }
     

     
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
        public void DOBOK()
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
            Int32 Id = 3;
            Found = ACustomer.Find(Id);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestCustomerIDNoFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Id = 3;
            Found = ACustomer.Find(Id);
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
            Int32 Id = 3;
            Found = ACustomer.Find(Id);
            if (ACustomer.DateOfBirth != Convert.ToDateTime("1999/01/11"))
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
            Int32 Id = 3;
            Found = ACustomer.Find(Id);
            if (ACustomer.Pass != ("Mm66ike99                                                   "))
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
            Int32 Id = 3;
            Found = ACustomer.Find(Id);
            if (ACustomer.Email != ("mike34@gmail.com"))
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
            Int32 Id = 3;
            Found = ACustomer.Find(Id);
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
            Int32 Id = 3;
            Found = ACustomer.Find(Id);
            if (ACustomer.Name != ("Mike Hall"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerBillingAddressFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Id = 3;
            Found = ACustomer.Find(Id);
            if (ACustomer.BillingAddress != ("22 Skyrise Lane LE26DA"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}


