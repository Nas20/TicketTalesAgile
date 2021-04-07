using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    
    [TestClass]
    public class TstOrder
    {
        //good test data
        string CId = "3";
        string CAddress = "3 Bobby Avenue";
        string IName = "Some Movie";
        string IQuantity = "12";
        string DDispatch = DateTime.Now.Date.ToString();
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();

            //check it works
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIdOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            int TestData = 1;
            //set the test data to the class
            AnOrder.OrderId = TestData;
            //check to see they are equal
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void CustomerIdOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            int TestData = 1;
            //set the test data to the class
            AnOrder.CustomerId = TestData;
            //check to see they are equal
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerAddressOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String TestData = "1 Colin Grundy Drive";
            //set the test data to the class
            AnOrder.Address = TestData;
            //check to see they are equal
            Assert.AreEqual(AnOrder.Address, TestData);
        }

        [TestMethod]
        public void DateOfOrderDispatchOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            DateTime TestData = DateTime.Now.Date;
            //set the test data to the class
            AnOrder.DateDispatch = TestData;
            //check to see they are equal
            Assert.AreEqual(AnOrder.DateDispatch, TestData);
        }

        [TestMethod]
        public void ItemNameOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String TestData = "Wonder Woman 1984";
            //set the test data to the class
            AnOrder.ItemName = TestData;
            //check to see they are equal
            Assert.AreEqual(AnOrder.ItemName, TestData);
        }
        
        [TestMethod]
        public void ItemQuantityOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            int TestData = 2;
            //set the test data to the class
            AnOrder.ItemQuantity = TestData;
            //check to see they are equal
            Assert.AreEqual(AnOrder.ItemQuantity, TestData);
        }

        [TestMethod]
        public void OrderMadeOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean TestData = true;
            //set the test data to the class
            AnOrder.Made = TestData;
            //check to see they are equal
            Assert.AreEqual(AnOrder.Made, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean FoundTest = false;
            Int32 OrderID = 1;
            //set the test data to the class and try to find it
            FoundTest = AnOrder.Find(OrderID);
            //check to see if its been found
            Assert.IsTrue(FoundTest);
        }

        [TestMethod]
        public void TestOrderIdNoFound()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            //set the test data to the class and try to find it
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }
            //check to see if its true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIdNoFound()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean Found = false;
            Boolean OK = true;
            Int32 Order1d = 1;
            //set the test data to the class and try to find it
            Found = AnOrder.Find(Order1d);
            if (AnOrder.CustomerId != 1)
            {
                OK = false;
            }
            //check to see if its true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            //set the test data to the class and try to find it
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Address != "5 Colin Grundy Drive")
            {
                OK = false;
            }
            //check to see if its true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateDispatchFound()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            //set the test data to the class and try to find it
            Found = AnOrder.Find(OrderId);
            if (AnOrder.DateDispatch != Convert.ToDateTime("14/02/2021"))
            {
                OK = false;
            }
            //check to see if its true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNameFound()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            //set the test data to the class and try to find it
            Found = AnOrder.Find(OrderId);
            if (AnOrder.ItemName != "Wonder Woman 1984")
            {
                OK = false;
            }
            //check to see if its true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemQuantityFound()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            //set the test data to the class and try to find it
            Found = AnOrder.Find(OrderId);
            if (AnOrder.ItemQuantity != 2)
            {
                OK = false;
            }
            //check to see if its true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMadeFound()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            //set the test data to the class and try to find it
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Made != true)
            {
                OK = false;
            }
            //check to see if its true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CIdLessThanOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string CId = "";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are not equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CIdMin()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string CId = "1";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CAddressLessThanOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string CAddress = "";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are not equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CAddressMin()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string CAddress = "1";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CAddressMinPlusOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string CAddress = "11";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CAddressMaxLessThanOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string CAddress = "111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CAddressMax()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string CAddress = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CAddressMaxPlusOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string CAddress = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111!";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are not equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dDispatchExtremMin()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DDispatch = TestDate.ToString();
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are not equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dDispatchMinLessOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DDispatch = TestDate.ToString();
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are not equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dDispatchMin()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DDispatch = TestDate.ToString();
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void dDispatchMinPlusOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DDispatch = TestDate.ToString();
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are not equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dDispatchMax()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DDispatch = TestDate.ToString();
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void dDispatchExtremeMax()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DDispatch = TestDate.ToString();
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are not equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dDispatchInvalidData()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string CId = "3";
            string CAddress = "3 Bobby Avenue";
            string IName = "Some Movie";
            string IQuantity = "12";
            string DDispatch = "this is not a date!";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are not equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void INameLessOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string IName = "";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are not equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void INameMin()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string IName = "J";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void INameMinPlusOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string IName = "JJ";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void INameMaxLessOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string IName = "";
            IName = IName.PadRight(49, 'a');
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void INameMax()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string IName = "";
            IName = IName.PadRight(50, 'a');
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void INameMaxPlusOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string IName = "";
            IName = IName.PadRight(51, 'a');
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are not equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void INameExtremMax()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string IName = "";
            IName = IName.PadRight(500, 'a');
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are not equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void INameMid()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string IName = "";
            IName = IName.PadRight(25, 'a');
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IQuantityLessOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string IQuantity = "";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IQuantityMin()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string IQuantity = "1";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IQuantityMinPlusOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string IName = "11";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IQuantityMaxLessOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string IQuantity = "99";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IQuantityMax()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string IQuantity = "100";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are both equal
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IQuantityMaxPlusOne()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string IQuantity = "101";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are not equal
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IQuantityInvalidData()
        {
            //create an instance of the class
            clsOrder AnOrder = new clsOrder();
            //create some test data
            String Error = "";
            string IQuantity = "This is not a valid number!";
            //set the test data to the method
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            //check to see they are not equal
            Assert.AreNotEqual(Error, "");
        }
    
    }
}
