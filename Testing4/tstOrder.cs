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
            //create an instance
            clsOrder AnOrder = new clsOrder();

            //check it works
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void OrderIdOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.OrderId = TestData;
            Assert.AreEqual(AnOrder.OrderId, TestData);
        }

        [TestMethod]
        public void CustomerIdOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.CustomerId = TestData;
            Assert.AreEqual(AnOrder.CustomerId, TestData);
        }

        [TestMethod]
        public void CustomerAddressOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "1 Colin Grundy Drive";
            AnOrder.Address = TestData;
            Assert.AreEqual(AnOrder.Address, TestData);
        }

        [TestMethod]
        public void DateOfOrderDispatchOK()
        {
            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DateDispatch = TestData;
            Assert.AreEqual(AnOrder.DateDispatch, TestData);
        }

        [TestMethod]
        public void ItemNameOK()
        {
            clsOrder AnOrder = new clsOrder();
            String TestData = "Wonder Woman 1984";
            AnOrder.ItemName = TestData;
            Assert.AreEqual(AnOrder.ItemName, TestData);
        }
        
        [TestMethod]
        public void ItemQuantityOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 2;
            AnOrder.ItemQuantity = TestData;
            Assert.AreEqual(AnOrder.ItemQuantity, TestData);
        }

        [TestMethod]
        public void OrderMadeOK()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.Made = TestData;
            Assert.AreEqual(AnOrder.Made, TestData);
        }

        [TestMethod]
        public void FindMethodOk()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean FoundTest = false;
            Int32 OrderID = 1;
            FoundTest = AnOrder.Find(OrderID);
            Assert.IsTrue(FoundTest);
        }

        [TestMethod]
        public void TestOrderIdNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.OrderId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void CustomerIdNoFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Order1d = 1;
            Found = AnOrder.Find(Order1d);
            if (AnOrder.CustomerId != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestCustomerAddressFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Address != "5 Colin Grundy Drive")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDateDispatchFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.DateDispatch != Convert.ToDateTime("14/02/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNameFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.ItemName != "Wonder Woman 1984")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemQuantityFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.ItemQuantity != 2)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestMadeFound()
        {
            clsOrder AnOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderId = 1;
            Found = AnOrder.Find(OrderId);
            if (AnOrder.Made != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();

            String Error = "";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CIdLessThanOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CId = "";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CIdMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CId = "1";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CAddressLessThanOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CAddress = "";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CAddressMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CAddress = "1";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CAddressMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CAddress = "11";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CAddressMaxLessThanOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CAddress = "111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CAddressMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CAddress = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CAddressMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string CAddress = "1111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111!";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dDispatchExtremMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DDispatch = TestDate.ToString();
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dDispatchMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DDispatch = TestDate.ToString();
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dDispatchMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DDispatch = TestDate.ToString();
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void dDispatchMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DDispatch = TestDate.ToString();
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dDispatchExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DDispatch = TestDate.ToString();
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dDispatchInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DDispatch = "this is not a date!";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void INameLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string IName = "";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void INameMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string IName = "J";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void INameMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string IName = "JJ";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void INameMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string IName = "";
            IName = IName.PadRight(49, 'a');
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void INameMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string IName = "";
            IName = IName.PadRight(50, 'a');
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void INameMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string IName = "";
            IName = IName.PadRight(51, 'a');
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void INameExtremMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string IName = "";
            IName = IName.PadRight(500, 'a');
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void INameMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string IName = "";
            IName = IName.PadRight(25, 'a');
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IQuantityLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string IQuantity = "";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IQuantityMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string IQuantity = "1";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IQuantityMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string IName = "11";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IQuantityMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string IQuantity = "99";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IQuantityMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string IQuantity = "100";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void IQuantityMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string IQuantity = "101";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void IQuantityInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string IQuantity = "This is not a valid number!";
            Error = AnOrder.Valid(CId, CAddress, DDispatch, IName, IQuantity);
            Assert.AreNotEqual(Error, "");
        }
    
    }
}
