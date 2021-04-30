using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing2
{
    [TestClass]
    public class tstCustomer
    {
        //good test data
        //create some test data to pass to the method
        string CName = "A Name";
        string CBillingAddress = "A Address LE567B";
        string CPass = "Hnahsn34";
        string CEmail = "name @ hotmail.com";
        string CDOB = DateTime.Now.Date.AddYears(-18).ToString();

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //invoke the method
            //this should pass
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

       

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //create test data to pass to the method
            //this should fail
            string CName = "";
            //invoke method
            Error= ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMin()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CName = "N";
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CName = "Nn";
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CName = "";
            CName = CName.PadRight(49, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMax()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CName = "";
            CName = CName.PadRight(50, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMid()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            string Error = "";
            //string variable to store error message
            string CName = "";
            //this should pass
            CName = CName.PadRight(25, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should fail
            string CName = "";
            CName = CName.PadRight(51, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should fail
            string CName = "";
            CName = CName.PadRight(500, 'n');
            //invoke method 
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
       
        [TestMethod]
        public void CustomerDateOfBirthExtremeMin()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //convert date to a string variable
            string CDOB = TestDate.ToString();
            //invoke the method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthMinLessOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 17 years
            TestDate = TestDate.AddYears(-17);
            //convert date to a string variable
            string CDOB = TestDate.ToString();
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthMid()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 68 years
            TestDate = TestDate.AddYears(-68);
            //convert date to a string variable
            string CDOB = TestDate.ToString();
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthMin()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 18 years
            TestDate = TestDate.AddYears(-18);
            //convert date to a string variable
            string CDOB = TestDate.ToString();
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthMinPlusOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 19 years
            TestDate = TestDate.AddYears(-19);
            //convert date to a string variable
            string CDOB = TestDate.ToString();
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthMaxPlusOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 101 years
            TestDate = TestDate.AddYears(-101);
            //convert date to a string variable
            string CDOB = TestDate.ToString();
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthMax()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert date to a string variable
            string CDOB = TestDate.ToString();
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerDateOfBirthMaxLessOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store error message
            string Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 99 years
            TestDate = TestDate.AddYears(-99);
            //convert date to a string variable
            string CDOB = TestDate.ToString();
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthExtremeMax()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store error message
            string Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            //set to todays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the data is less 1000 years
            TestDate = TestDate.AddYears(-1000);
            //convert date to a string variable
            string CDOB = TestDate.ToString();
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerDateOfBirthInvalidData()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            // string variable to store error message
            string Error = "";
            //set the date of birth to a non date value
            string CDOB = "This is not a date!";
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMinLessOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should fail
            string CEmail = "";
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMin()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CEmail = "N";
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerEmailMinPlusOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CEmail = "Nn"; 
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxLessOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CEmail = "";
            CEmail = CEmail.PadRight(49, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMax()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CEmail = "";
            CEmail = CEmail.PadRight(50, 'n');
            //invoke the method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMid()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CEmail = "";
            CEmail = CEmail.PadRight(25, 'n');
            //invoke the method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailMaxPlusOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should fail
            string CEmail = "";
            CEmail = CEmail.PadRight(51, 'n');
            //invoke the method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
       
         [TestMethod]
        public void CustomerPassMinLessOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //create test data to pass to the method
            //this should fail
            string CPass = "";
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPassMin()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CPass = "N";
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerPassMinPlusOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CPass = "Nn";
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPassMaxLessOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CPass = "";
            CPass = CPass.PadRight(59, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPassMax()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CPass = "";
            CPass = CPass.PadRight(60, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPassMid()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CPass = "";
            CPass = CPass.PadRight(30, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPassMaxPlusOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should fail
            string CPass = "";
            CPass = CPass.PadRight(61, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
       
        [TestMethod]
        public void CustomerBillingAddressMin()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CBillingAddress = "N";
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerBillingAddressMinPlusOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CBillingAddress = "Nn";
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerBillingAddressMinLessOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //create test data to pass to the method
            //this should fail
            string CBillingAddress = "";
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerBillingAddressMaxLessOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CBillingAddress = "";
            CBillingAddress = CBillingAddress.PadRight(99, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerBillingAddressMax()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CBillingAddress = "";
            CBillingAddress = CBillingAddress.PadRight(100, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerBillingAddressMid()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should pass
            string CBillingAddress = "";
            CBillingAddress = CBillingAddress.PadRight(50, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressMaxPlusOne()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should fail
            string CBillingAddress = "";
            CBillingAddress = CBillingAddress.PadRight(101, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerEmailExtremeMax()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should fail
            string CEmail = "";
            CEmail = CEmail.PadRight(500, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerPassExtremeMax()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should fail
            string CPass = "";
            CPass = CPass.PadRight(500, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void CustomerAddressExtremeMax()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //string variable to store error message
            string Error = "";
            //this should fail
            string CBillingAddress = "";
            CBillingAddress = CBillingAddress.PadRight(500, 'n');
            //invoke method
            Error = ACustomer.Valid(CName, CDOB, CEmail, CBillingAddress, CPass);
            //test to see if result is correct
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //test to see if it exists
            Assert.IsNotNull(ACustomer);
        }
        [TestMethod]
        public void IsCustomerActiveOK()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            ACustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Active, TestData);
        }
        [TestMethod]
        public void DOBOK()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            ACustomer.DateOfBirth = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.DateOfBirth, TestData);

        }
        [TestMethod]
        public void BillingAddressOK()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            ACustomer.BillingAddress = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.BillingAddress, TestData);
        }
        [TestMethod]
        public void EmailOK()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "nasreen.shaikh@hotmail.com";
            //assign the data to the property
            ACustomer.Email = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Email, TestData);
        }
        [TestMethod]
        public void NameOK()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "nasreen shaikh";
            //assign the data to the property
            ACustomer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Name, TestData);
        }
        [TestMethod]
        public void PassOK()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "n21345gh";
            //assign the data to the property
            ACustomer.Pass = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Pass, TestData);
        }
        [TestMethod]
        public void IdOK()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            ACustomer.Id = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(ACustomer.Id, TestData);

        }
        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //boolean value to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 Id = 3;
            //invoke the method
            Found = ACustomer.Find(Id);
            //test to see if results are true
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestCustomerIDNoFound()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //boolean value to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //invoke the method
            Int32 Id = 3;
            Found = ACustomer.Find(Id);
            if (ACustomer.Id != 3)
            {
                OK = false;
            }
            //test to see if results are true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerDOBFound()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //boolean value to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //invoke the method
            Int32 Id = 3;
            Found = ACustomer.Find(Id);
            if (ACustomer.DateOfBirth != Convert.ToDateTime("1999/01/11"))
            {
                OK = false;
            }
            //test to see if results are true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerPassFound()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //boolean value to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //invoke the method
            Int32 Id = 3;
            Found = ACustomer.Find(Id);
            if (ACustomer.Pass != ("Mm66ike99                                                   "))
            {
                OK = false;
            }
            //test to see if results are true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerEmailFound()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //boolean value to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //invoke the method
            Int32 Id = 3;
            Found = ACustomer.Find(Id);
            if (ACustomer.Email != ("mike34@gmail.com"))
            {
                OK = false;
            }
            //test to see if results are true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerActiveFound()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //boolean value to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //invoke the method
            Int32 Id = 3;
            Found = ACustomer.Find(Id);
            if (ACustomer.Active != (true))
            {
                OK = false;
            }
            //test to see if results are true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerNameFound()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //boolean value to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //invoke the method
            Int32 Id = 3;
            Found = ACustomer.Find(Id);
            if (ACustomer.Name != ("Mike Hall"))
            {
                OK = false;
            }
            //test to see if results are true
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCustomerBillingAddressFound()
        {
            //create an instance of the class customer
            clsCustomer ACustomer = new clsCustomer();
            //boolean value to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //invoke the method
            Int32 Id = 3;
            Found = ACustomer.Find(Id);
            if (ACustomer.BillingAddress != ("22 Skyrise Lane LE26DA"))
            {
                OK = false;
            }
            //test to see if results are true
            Assert.IsTrue(OK);
        }

    }
}


