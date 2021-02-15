using System;
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
            AnOrder.Id = TestData;
            Assert.AreEqual(AnOrder.Id, TestData);
        }

        [TestMethod]
        public void CustomerIdOK()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 1;
            AnOrder.Id = TestData;
            Assert.AreEqual(AnOrder.Id, TestData);
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
    }
}
