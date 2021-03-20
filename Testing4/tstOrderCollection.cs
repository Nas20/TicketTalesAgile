using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing4
{
    [TestClass]
    public class tstOrderCollection
    {
        
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            Assert.IsNotNull(AllOrders);
        }

        [TestMethod]
        public void AddOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            Int32 PrimaryKey = 0;
            TestItem.Address = "some address";
            TestItem.CustomerId = 1;
            TestItem.DateDispatch = DateTime.Now.Date;
            TestItem.ItemName = "some name";
            TestItem.ItemQuantity = 4;
            TestItem.OrderId = 3;
            TestItem.Made = true;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderId = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Address = "some sort of address";
            TestItem.CustomerId = 2;
            TestItem.DateDispatch = DateTime.Now.Date;
            TestItem.Made = true;
            TestItem.ItemName = "some item";
            TestItem.ItemQuantity = 4;
            TestItem.OrderId = 2;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

       

        [TestMethod]
        public void ThisOrderOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            TestOrder.Address = "some address";
            TestOrder.CustomerId = 2;
            TestOrder.DateDispatch = DateTime.Now.Date;
            TestOrder.ItemName = "some Item";
            TestOrder.ItemQuantity = 3;
            TestOrder.Made = true;
            TestOrder.OrderId = 7;
            AllOrders.ThisOrder = TestOrder;
            Assert.AreEqual(AllOrders.ThisOrder, TestOrder);
        }

        [TestMethod]
        public void ListandCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.Address = "some address";
            TestItem.CustomerId = 3;
            TestItem.DateDispatch = DateTime.Now.Date;
            TestItem.ItemName = "Maaz needs Mac 10";
            TestItem.ItemQuantity = 7;
            TestItem.Made = true;
            TestItem.OrderId = 4;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);
        }
    }
}
