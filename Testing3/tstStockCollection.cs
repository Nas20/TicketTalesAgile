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
            TestStock.Price = 12;
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
            TestStock.Price = 12;
            TestStock.StockAvailable = true;
            TestStock.DatePurchased = DateTime.Now.Date;
            AllStock.ThisStock = TestStock;
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }

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
            TestStock.Price = 12;
            TestStock.StockAvailable = true;
            TestStock.DatePurchased = DateTime.Now.Date;
            TestStock.Add(TestStock);
            AllStock.ThisStock = TestStock;
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
