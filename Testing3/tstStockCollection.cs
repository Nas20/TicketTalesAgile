using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Testing3
{
    [TestClass]
    public class tstStockCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.IsNotNull(AllStock);
        }
        /*
        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data for the class
            clsStock TestStock = new clsStock();
            //create var to store the property
            Int32 PrimaryKey = 0;
            //set the properties
            TestStock.StockId = 1;
            TestStock.ItemName = "some name";
            TestStock.Quantity = 150;
            TestStock.StockPrice = 12;
            TestStock.StockAvailable = true;
            TestStock.DatePurchased = DateTime.Now.Date;
            //set the test data properties to the ThisOrder
            AllStock.ThisStock = TestStock;
            //add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestStock.StockId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //check to see if both are the same
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }
        */
        [TestMethod]
        public void StockListOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestStock = new clsStock();
            TestStock.Active = true;
            TestStock.StockId = 1;
            TestStock.ItemName = "some name";
            TestStock.Quantity = 150;
            TestStock.StockPrice = 12;
            TestStock.StockAvailable = true;
            TestStock.DatePurchased = DateTime.Now.Date;
            TestList.Add(TestStock);
            AllStock.StockList = TestList;
            Assert.AreEqual(AllStock.StockList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Int32 SomeCount = 0;
            AllStock.Count = SomeCount;
            Assert.AreEqual(AllStock.Count, SomeCount);
        }

        [TestMethod]
        public void ThisStockOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            clsStock TestStock = new clsStock();
            TestStock.StockId = 1;
            TestStock.ItemName = "some name";
            TestStock.Quantity = 150;
            TestStock.StockPrice = 12;
            TestStock.StockAvailable = true;
            TestStock.DatePurchased = DateTime.Now.Date;
            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }
        /*
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            List<clsStock> TestList = new List<clsStock>();
            clsStock TestStock = new clsStock();
            TestStock.Active = true;
            TestStock.StockId = 1;
            TestStock.ItemName = "some name";
            TestStock.Quantity = 150;
            TestStock.StockPrice = 12;
            TestStock.StockAvailable = true;
            TestStock.DatePurchased = DateTime.Now.Date;
            //TestStock.Add(TestStock);
            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.Count, TestStock);

        }
        /*
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the customer collection class
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestStock = new clsStock();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestStock.Active = true;
            TestStock.ItemName = "A name";
            TestStock.Quantity = 150;
            TestStock.StockPrice =4;
            //TestStock.StockAvailable = ;
            TestStock.DatePurchased = DateTime.Now.Date;
            //set ThisCustomer to the test data
            AllStock.ThisStock = TestStock;
            //add the record
            PrimaryKey = AllStock.Add();
            //set primary key of the test data
            TestStock.StockId = PrimaryKey;

            //modify the test data
            TestStock.Active = false;
            TestStock.ItemName = "Rubgy";
            TestStock.Quantity = 150;
            TestStock.StockPrice = 4;
            //TestStock.StockAvailable = ;
            TestStock.DatePurchased = DateTime.Now.Date;
            //set the record based on the new test data
            AllStock.ThisStock = TestStock;
            //update the record
            AllStock.Update();
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //test to see thisCustomer matches the test data
            Assert.AreEqual(AllStock.ThisStock, TestStock);

        }
        /**
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.AreEqual(AllStock.Count, 2);
        }
        */
    }
}
