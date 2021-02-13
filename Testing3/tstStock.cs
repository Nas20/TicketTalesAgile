using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock AStock = new clsStock();
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void StockIdOK()
        {
            clsStock AStock = new clsStock();
            int TestData = 1;
            AStock.Id = TestData;
            Assert.AreEqual(AStock.Id, TestData);
        }

        [TestMethod]
        public void ItemNameOK()
        {
            clsStock AStock = new clsStock();
            string TestData = "Movie";
            AStock.ItemName = TestData;
            Assert.AreEqual(AStock.ItemName, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            clsStock AStock = new clsStock();
            int TestData = 20;
            AStock.Quantity = TestData;
            Assert.AreEqual(AStock.Quantity, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            clsStock AStock = new clsStock();
            decimal TestData = 9;
            AStock.Price = TestData;
            Assert.AreEqual(AStock.Price, TestData);
        }

        [TestMethod]
        public void StockAvailableOK()
        {
            clsStock AStock = new clsStock();
            Boolean TestData = true;
            AStock.StockAvailable = TestData;
            Assert.AreEqual(AStock.StockAvailable, TestData);
        }

        [TestMethod]
        public void DatePurchasedOK()
        {
            clsStock AStock = new clsStock();
            DateTime TestData = DateTime.Now.Date;
            AStock.DatePurchased = TestData;
            Assert.AreEqual(AStock.DatePurchased, TestData);
        }
    }
}
