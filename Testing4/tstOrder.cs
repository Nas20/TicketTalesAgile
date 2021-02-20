using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing4
{
    [TestClass]
    public class TstOrder
    {
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
    
    }
}
