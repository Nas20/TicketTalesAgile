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
            //create an instance of the stock class
            clsStockCollection AllStock = new clsStockCollection();
            //test to see if it exists
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
            TestStock.Quantity = 90;
            TestStock.StockPrice = 13;
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
            //create an list of the stock collection class 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            //In this case, it needs to be a list property
            List<clsStock> TestList = new List<clsStock>();
            //add item to the list 
            //create the item for the test data
            clsStock TestStock = new clsStock();
            //set its properties 
            TestStock.Active = true;
            TestStock.StockId = 1;
            TestStock.ItemName = "some name";
            TestStock.Quantity = 150;
            TestStock.StockPrice = 12;
            TestStock.StockAvailable = true;
            TestStock.DatePurchased = DateTime.Now.Date;
            //add item to test list 
            TestList.Add(TestStock);
            //assign data to the property
            AllStock.StockList = TestList;
            //test to see if it works and that the values are the same.
            Assert.AreEqual(AllStock.StockList, TestList);
        }
        /*
        [TestMethod]
        public void CountPropertyOK()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Int32 SomeCount = 0;
            AllStock.Count = SomeCount;
            Assert.AreEqual(AllStock.Count, SomeCount);
        }
        */
        [TestMethod]
        public void ThisStockOK()
        {
            //create an instance of the class 
            clsStockCollection AllStock = new clsStockCollection();
            //create some test data to assign to the property
            clsStock TestStock = new clsStock();
            //set the properties 
            TestStock.StockId = 1;
            TestStock.ItemName = "some name";
            TestStock.Quantity = 150;
            TestStock.StockPrice = 12;
            TestStock.StockAvailable = true;
            TestStock.DatePurchased = DateTime.Now.Date;
            //assign the data to the properties 
            AllStock.ThisStock = TestStock;
            //test to see if it works as planned.
            Assert.AreEqual(AllStock.ThisStock, TestStock);
        }
        /*
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //create a list for the class
            List<clsStock> TestList = new List<clsStock>();
            //create some test data for the new class
            clsStock TestStock = new clsStock();
            TestStock.Active = true;
            TestStock.StockId = 10;
            TestStock.ItemName = "some name";
            TestStock.Quantity = 80;
            TestStock.StockPrice = 9;
            TestStock.StockAvailable = true;
            TestStock.DatePurchased = DateTime.Now.Date;
            //add the item to the test list
            //TestStock.Add(TestStock);
            //assign the data to the property
            AllStock.ThisStock = TestStock;
            //test to see if the two values are the same
            Assert.AreEqual(AllStock.Count, TestStock);

        }
        
        [TestMethod]
        public void UpdateMethodOK()
        {
            //create an instance of the stock collection class
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestStock = new clsStock();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestStock.Active = true;
            TestStock.ItemName = "TennisMatch";
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
            TestStock.ItemName = "TennisMatch";
            TestStock.Quantity = 200;
            TestStock.StockPrice = 6;
            //TestStock.StockAvailable = true;
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
        /*
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsStockCollection AllStock = new clsStockCollection();
            Assert.AreEqual(AllStock.Count, 2);
        }
        */
        /*
        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the class
            clsStockCollection AllStock = new clsStockCollection();
            //create the item of test data
            clsStock TestStock = new clsStock();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set the properties
            TestStock.ItemName = "TennisMatch";
            TestStock.Quantity = 150;
            TestStock.StockPrice = 4;
            TestStock.StockAvailable = true;
            TestStock.DatePurchased = DateTime.Now.Date;
            //set ThisOrder to the test data
            AllStock.ThisStock = TestStock;
            //Add the record
            PrimaryKey = AllStock.Add();
            //set the primary key of the test data
            TestStock.StockId = PrimaryKey;
            //find the record
            AllStock.ThisStock.Find(PrimaryKey);
            //delete the record
            AllStock.Delete();
            //now find the record
            Boolean Found = AllStock.ThisStock.Find(PrimaryKey);
            //test to see if the order was not found
            Assert.IsFalse(Found);
        }
        */
        [TestMethod]
        public void ReportByItemNameMethodOK()
        {
            //create an instance of the customer collection class
            clsStockCollection AllStock = new clsStockCollection();
            //create an instance of the filtered data
            clsStockCollection FilteredItemName = new clsStockCollection();
            //apply a blank string(should return all records)
            FilteredItemName.ReportByItemName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllStock.Count, FilteredItemName.Count);

        }

        [TestMethod]
        public void ReportByItemNameNoneFound()
        {
            //create an insatnce of the filtered data
            clsStockCollection FilteredItemName = new clsStockCollection();
            //apply a item name that doesnt exist
            FilteredItemName.ReportByItemName("dodgeball");
            //test to see that there are no reocrds
            Assert.AreEqual(0, FilteredItemName.Count);
        }
        /*
        [TestMethod]
        public void ReportByItemNameDataFound()
        {
            //create an instance of the filtered data
            clsStockCollection FilteredStock = new clsStockCollection();
            //var to store outcome
            Boolean OK = true;
            //apply an item name that doesn't exist
            FilteredStock.ReportByItemName("Dodgeball");
            //check the correct number of records are found
            if (FilteredStock.Count == 2)
            {
                //check the first record is ID 20
                if (FilteredStock.StockList[0].StockId != 20)
                {
                    OK = false;
                }
                //check the second record is ID 23
                if (FilteredStock.StockList[1].StockId != 23)
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
        */
        
    }
}
