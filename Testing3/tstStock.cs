using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {

        string StockId = "1";
        string ItemName = "TennisMatch";
        string Quantity = "150";
        string Price = "12";
        string StockAvailable = "True";
        string DatePurchased = DateTime.Now.Date.ToString();
        //" 07/01/2021";


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
            AStock.StockPrice = TestData;
            Assert.AreEqual(AStock.StockPrice, TestData);
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
            Int32 StockId = 1;
            Found = AStock.Find(StockId);
            if (AStock.StockId != 1)
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
            if (AStock.StockPrice != Convert.ToDecimal("12"))
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
            if (AStock.DatePurchased != Convert.ToDateTime("07/01/2021"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



        /**
         * 
         */

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        //StockId

        [TestMethod]
        public void StockIdMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIdMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockId = "a";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIdMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockId = "aa";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIdMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockId = "aaaaa";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIdMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockId = "aaaaaa";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIdMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockId = "aaa";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void StockIdExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockId = "";
            StockId = StockId.PadRight(500, 'a');
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreNotEqual(Error,"");
        }

        //ItemName

        [TestMethod]
        public void ItemNameMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ItemName = "";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ItemName = "a";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ItemName = "aa";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ItemName = "aaaaa";
            ItemName = ItemName.PadRight(49, 'a');
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ItemName = "";
            ItemName = ItemName.PadRight(50, 'a');
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ItemName = "";
            ItemName = ItemName.PadRight(51, 'a');
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string ItemName = "";
            ItemName = ItemName.PadRight(25, 'a');
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        //Quantity

        [TestMethod]
        public void QuantityMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "a";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockId = "aa";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(9, 'a');
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(10, 'a');
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(5, 'a');
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");

        }

        //Price

        [TestMethod]
        public void PriceLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "a";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "aa";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "aaaaa";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "aaaaaa";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "aaa";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string Price = "";
            Price = Price.PadRight(500, 'a');
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        //StockAvailable

        [TestMethod]
        public void StockAvailableMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAvailableMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockAvailable = "a";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAvailableMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockAvailable = "aa";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAvailableMaxLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockAvailable = "aaaaa";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAvailableMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockAvailable = "aaaaaa";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAvailableMid()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockAvailable = "aaa";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAvailableExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string StockAvailable = "";
            StockAvailable = StockAvailable.PadRight(500, 'a');
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        //DatePurchased 

        [TestMethod]
        public void DatePurchasedExtremeMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DatePurchased = TestDate.ToString();
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedMinLessOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DatePurchased = TestDate.ToString();
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedMin()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DatePurchased = TestDate.ToString();
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedMinPlusOne()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DatePurchased = TestDate.ToString();
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedExtremeMax()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DatePurchased = TestDate.ToString();
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedInvalidData()
        {
            clsStock AStock = new clsStock();
            String Error = "";
            string DatePurchased = "This is not a date!";
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            Assert.AreNotEqual(Error, "");
        }
    }
}
