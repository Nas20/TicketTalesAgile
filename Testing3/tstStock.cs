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
            AStock.StockId = TestData;
            Assert.AreEqual(AStock.StockId, TestData);
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
        /**
        [TestMethod]
        public void FindMethodOK()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Int32 StockId = 1;
            Found = AStock.Find(StockId);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIdFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Id = 1;
            Found = AStock.Find(Id);
            if (AStock.StockId !=1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNameFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockId = 1;
            Found = AStock.Find(StockId);
            if (AStock.ItemName != "TennisMatch")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockId = 1;
            Found = AStock.Find(StockId);
            if (AStock.Quantity != 150)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockId = 1;
            Found = AStock.Find(StockId);
            if (AStock.Price != Convert.ToDecimal("12"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockAvailableFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockId = 1;
            Found = AStock.Find(StockId);
            if (AStock.StockAvailable != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDatePurchasedFound()
        {
            clsStock AStock = new clsStock();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StockId = 1;
            Found = AStock.Find(StockId);
            if (AStock.DatePurchased != Convert.ToDateTime ("07/01/2021")) 
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
    }
    **/
    }
}