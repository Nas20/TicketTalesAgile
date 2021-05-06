using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testing3
{
    [TestClass]
    public class tstStock
    {
        //good test data
        //create some test data to pass to the method
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
            //creates an instance of the class stock
            clsStock AStock = new clsStock();
            //test to see if it exists 
            Assert.IsNotNull(AStock);
        }

        [TestMethod]
        public void StockIdOK()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //create some test daya to use with this method
            int TestData = 1;
            //invoke method
            AStock.StockId = TestData;
            //test to see if results are true
            Assert.AreEqual(AStock.StockId, TestData);
        }

        [TestMethod]
        public void ItemNameOK()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //create some test data to use with this method
            string TestData = "Movie";
            //invoke method
            AStock.ItemName = TestData;
            //test to see if results are true
            Assert.AreEqual(AStock.ItemName, TestData);
        }

        [TestMethod]
        public void QuantityOK()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //create some test data to use with this method 
            int TestData = 20;
            //invoke method
            AStock.Quantity = TestData;
            //test to see if results are true
            Assert.AreEqual(AStock.Quantity, TestData);
        }

        [TestMethod]
        public void PriceOK()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //decimal value to store result of the validation
            decimal TestData = 9;
            //invoke method
            AStock.StockPrice = TestData;
            //test to see if results are true
            Assert.AreEqual(AStock.StockPrice, TestData);
        }

        [TestMethod]
        public void StockAvailableOK()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //boolean value to store the result of the validation
            Boolean TestData = true;
            //invoke method
            AStock.StockAvailable = TestData;
            //test to see if results are true
            Assert.AreEqual(AStock.StockAvailable, TestData);
        }

        [TestMethod]
        public void DatePurchasedOK()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //invoke method
            DateTime TestData = DateTime.Now.Date;
            AStock.DatePurchased = TestData;
            //test to see if it correct
            Assert.AreEqual(AStock.DatePurchased, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //boolean value to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StockId = 1;
            //invoke method
            Found = AStock.Find(StockId);
            //test to see if results are true 
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStockIdFound()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //boolean value to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //invoke method 
            Int32 StockId = 1;
            Found = AStock.Find(StockId);
            if (AStock.StockId != 1)
            {
                OK = false;
            }
            //test to see if results are true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestItemNameFound()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //boolean value to store results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //invoke method
            Int32 StockId = 1;
            Found = AStock.Find(StockId);
            if (AStock.ItemName != "TennisMatch")
            {
                OK = false;
            }
            //test to see if results are true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestQuantityFound()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //boolean value to store results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //invoke method
            Int32 StockId = 1;
            Found = AStock.Find(StockId);
            if (AStock.Quantity != 150)
            {
                OK = false;
            }
            //test to see if results are true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestPriceFound()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //boolean value to store results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //invoke method
            Int32 StockId = 1;
            Found = AStock.Find(StockId);
            if (AStock.StockPrice != Convert.ToDecimal("12"))
            {
                OK = false;
            }
            //test to see if results are true
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStockAvailableFound()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //boolean value to store the result of the validation 
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //invoke method
            Int32 StockId = 1;
            Found = AStock.Find(StockId);
            if (AStock.StockAvailable != true)
            {
                OK = false;
            }
            //test to see if results are true 
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDatePurchasedFound()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //boolean value to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Boolean OK = true;
            //invoke method 
            Int32 StockId = 1;
            Found = AStock.Find(StockId);
            if (AStock.DatePurchased != Convert.ToDateTime("07/01/2021"))
            {
                OK = false;
            }
            //test to see if results are true
            Assert.IsTrue(OK);
        }



        /**
         * 
         */

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works
            Assert.AreEqual(Error, "");
        }

        //StockId

        [TestMethod]
        public void StockIdMinLessOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message 
            String Error = "";
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIdMin()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message 
            String Error = "";
            string StockId = "a";
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIdMinPlusOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message 
            String Error = "";
            string StockId = "aa";
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIdMaxLessOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message 
            String Error = "";
            string StockId = "aaaaa";
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIdMax()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            string StockId = "aaaaaa";
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockIdMid()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            string StockId = "aaa";
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreEqual(Error, "");
        }
        
        [TestMethod]
        public void StockIdExtremeMax()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            string StockId = "";
            StockId = StockId.PadRight(500, 'a');
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if works
            Assert.AreNotEqual(Error,"");
        }

        //ItemName

        [TestMethod]
        public void ItemNameMinLessOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the erorr message 
            String Error = "";
            string ItemName = "";
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMin()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message 
            String Error = "";
            string ItemName = "a";
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMinPlusOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message 
            String Error = "";
            string ItemName = "aa";
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxLessOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message 
            String Error = "";
            string ItemName = "aaaaa";
            ItemName = ItemName.PadRight(49, 'a');
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMax()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            string ItemName = "";
            ItemName = ItemName.PadRight(50, 'a');
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to seee if it works 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMaxPlusOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message 
            String Error = "";
            string ItemName = "";
            ItemName = ItemName.PadRight(51, 'a');
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNameMid()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            string ItemName = "";
            ItemName = ItemName.PadRight(25, 'a');
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreEqual(Error, "");
        }

        //Quantity

        [TestMethod]
        public void QuantityMinLessOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //strimg variable to store the error message
            String Error = "";
            string Quantity = "";
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMin()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            string Quantity = "a";
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMinPlusOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            string StockId = "aa";
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMaxLessOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(9, 'a');
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMax()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(10, 'a');
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void QuantityMid()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message 
            String Error = "";
            string Quantity = "";
            Quantity = Quantity.PadRight(5, 'a');
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreEqual(Error, "");

        }

        //Price

        [TestMethod]
        public void PriceLessOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMin()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message 
            String Error = "";
            string Price = "a";
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMinPlusOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message 
            String Error = "";
            string Price = "aa";
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMaxLessOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            string Price = "aaaaa";
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMax()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error messsage
            //string price shows the max
            String Error = "";
            string Price = "aaaaaa";
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceMid()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message 
            String Error = "";
            string Price = "aaa";
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PriceExtremeMax()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            string Price = "";
            Price = Price.PadRight(500, 'a');
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreNotEqual(Error, "");
        }

        //StockAvailable

        [TestMethod]
        public void StockAvailableMinLessOne()
        {
            //create an insatnce of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message 
            String Error = "";
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAvailableMin()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            string StockAvailable = "a";
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works 
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAvailableMinPlusOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            string StockAvailable = "aa";
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it works
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAvailableMaxLessOne()
        {
            //create an insatnce of the class stock
            clsStock AStock = new clsStock();
            //string varibale to store the error message 
            String Error = "";
            string StockAvailable = "aaaaa";
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAvailableMax()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            string StockAvailable = "aaaaaa";
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAvailableMid()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //strng variable to store the error message
            String Error = "";
            string StockAvailable = "aaa";
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StockAvailableExtremeMax()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //this should pass
            string StockAvailable = "";
            StockAvailable = StockAvailable.PadRight(500, 'a');
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it is correct
            Assert.AreEqual(Error, "");
        }

        //DatePurchased 

        [TestMethod]
        public void DatePurchasedExtremeMin()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //this should pass
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DatePurchased = TestDate.ToString();
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedMinLessOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store the error message
            String Error = "";
            //this should pass
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            //invoke method 
            string DatePurchased = TestDate.ToString();
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedMin()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string varibale to store the error message
            String Error = "";
            //this should pass
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            //invoke method
            string DatePurchased = TestDate.ToString();
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedMinPlusOne()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DatePurchased = TestDate.ToString();
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedExtremeMax()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DatePurchased = TestDate.ToString();
            //invoke method
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DatePurchasedInvalidData()
        {
            //create an instance of the class stock
            clsStock AStock = new clsStock();
            //string variable to store error message
            String Error = "";
            //create test data to pass to the method
            //this should fail if anything but the date is added
            string DatePurchased = "This is not a date!";
            //invoke method 
            Error = AStock.Valid(StockId, ItemName, Quantity, Price, StockAvailable, DatePurchased);
            //test to see if it is correct
            Assert.AreNotEqual(Error, "");
        }
    }
}
