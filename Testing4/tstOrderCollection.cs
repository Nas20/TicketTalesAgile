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
            //create an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create some test data for the class
            clsOrder TestItem = new clsOrder();
            //create var to store the property
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.Address = "some address";
            TestItem.CustomerId = 1;
            TestItem.DateDispatch = DateTime.Now.Date;
            TestItem.ItemName = "some name";
            TestItem.ItemQuantity = 4;
            TestItem.OrderId = 3;
            TestItem.Made = true;
            //set the test data properties to the ThisOrder
            AllOrders.ThisOrder = TestItem;
            //add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //check to see if both are the same
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

        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.Address = "some address";
            TestItem.CustomerId = 2;
            TestItem.DateDispatch = DateTime.Now.Date;
            TestItem.ItemName = "Zack Snyder's cut";
            TestItem.ItemQuantity = 2;
            TestItem.Made = true;
            TestItem.OrderId = 5;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //Add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //modify test data
            TestItem.Address = "2 Jefferson Avenue";
            TestItem.CustomerId = 2;
            TestItem.DateDispatch = DateTime.Now.Date;
            TestItem.ItemName = "Zack Snyder's cut";
            TestItem.ItemQuantity = 2;
            TestItem.Made = true;
            //set the record based on the new test data
            AllOrders.ThisOrder = TestItem;
            //update the record
            AllOrders.Update();
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see if they are both equal
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create the item of test data
            clsOrder TestItem = new clsOrder();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestItem.Address = "some address";
            TestItem.CustomerId = 2;
            TestItem.DateDispatch = DateTime.Now.Date;
            TestItem.ItemName = "Zack Snyder's cut";
            TestItem.ItemQuantity = 2;
            TestItem.Made = true;
            TestItem.OrderId = 5;
            //set ThisOrder to the test data
            AllOrders.ThisOrder = TestItem;
            //Add the record
            PrimaryKey = AllOrders.Add();
            //set the primary key of the test data
            TestItem.OrderId = PrimaryKey;
            //find the record
            AllOrders.ThisOrder.Find(PrimaryKey);
            //delete the record
            AllOrders.Delete();
            //now find the record
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            //test to see if the order was not found
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByItemNameMethodOK()
        {
            //create an instance of the class with unfiltered results
            clsOrderCollection AllOrders = new clsOrderCollection();
            //create an instance of the filtered data
            clsOrderCollection FilteredItemName = new clsOrderCollection();
            //apply a blank string (should return all records)
            FilteredItemName.ReportByItemName("");
            //test to see the values are the same
            Assert.AreEqual(AllOrders.Count, FilteredItemName.Count);
        }

        [TestMethod]
        public void ReportByItemNameNotFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredItemName = new clsOrderCollection();
            //apply an item name that doesn't exist
            FilteredItemName.ReportByItemName("Lol");
            //test to see they are equal
            Assert.AreEqual(0, FilteredItemName.Count);
        }

        [TestMethod]
        public void ReportByItemNameFound()
        {
            //create an instance of the filtered data
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            //var to store outcome
            Boolean OK = true;
            //apply an item name that doesn't exist
            FilteredOrders.ReportByItemName("Falcon");
            if (FilteredOrders.Count == 2)
            {
                //check the first record is ID 41
                if (FilteredOrders.OrderList[0].OrderId != 41)
                {
                    OK = false;
                }
                //check the second record is ID 42
                if (FilteredOrders.OrderList[1].OrderId != 42)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            //test to see that there are no records
            Assert.IsTrue(OK);
        }
    }
}
