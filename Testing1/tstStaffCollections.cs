using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;


namespace Testing1
{
    [TestClass]

    public class tstStaffCollection
    {
        public List<clsStaff> TestList { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the Staff Collection Class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //test to see if it exists
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            //create an instance of the Staff Collection Class
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set properties
            TestItem.Id = 2;
            TestItem.Name = "Oskar Karcz";
            TestItem.Email = "oskar@gmail.com";
            TestItem.PhoneNumber = 112;
            TestItem.Roles = "Admin";
            TestItem.Gender = true;
            TestItem.DOB = Convert.ToDateTime("19/04/1996");
            //add the item to test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see thisStaff matches the test data
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }

     
        [TestMethod]
        public void ListAndCountOK()
        {
            //create an instance of the Staff Collection Class
            clsStaffCollection AllStaff = new clsStaffCollection();
            // create some test data to assign to the property
            List<clsStaff> TestList = new List<clsStaff>();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set properties
            TestItem.Id = 2;
            TestItem.Name = "Oskar Karcz";
            TestItem.Email = "oskar@gmail.com";
            TestItem.PhoneNumber = 112;
            TestItem.Roles = "Admin";
            TestItem.Gender = true;
            TestItem.DOB = Convert.ToDateTime("19/04/1996");
            //add the item to test list
            TestList.Add(TestItem);
            //assign the data to the property
            AllStaff.StaffList = TestList;
            //test to see thisStaff matches the test data
            Assert.AreEqual(AllStaff.StaffList, TestList);
        }
        
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            //create an instance of the Staff Collection Class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of the test data
            clsStaff TestItem = new clsStaff();
            //set properties
            TestItem.Id = 2;
            TestItem.Name = "Oskar Karcz";
            TestItem.Email = "oskar@gmail.com";
            TestItem.PhoneNumber = 112;
            TestItem.Roles = "Admin";
            TestItem.Gender = false;
            TestItem.DOB = Convert.ToDateTime("19/04/1996");
            //assign the data to the property
            AllStaff.ThisStaff = TestItem;
            //test to see thisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);
        }

        /*
                [TestMethod]
                public void TwoRecordsPresent()
                {
                //create an instance of the Staff Collection Class
                    clsStaffCollection AllStaff = new clsStaffCollection();
                    Assert.AreEqual(AllStaff.Count, 2);
                }

                */

        [TestMethod]
        public void CountPropertyOK()
        {
            //create an instance of the Staff Collection Class
            clsStaffCollection AllStaff = new clsStaffCollection();
            Int32 SomeCount = 2;
            AllStaff.Count = SomeCount;
            Assert.AreNotEqual(AllStaff.Count, SomeCount);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            //create an instance of the Staff Collection Class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //create the item of test data
            clsStaff TestItem = new clsStaff();
            //var to store primary key
            Int32 PrimaryKey = 0;
            //set its properties
            TestItem.Id = 2;
            TestItem.Name = "Oskar Karcz";
            TestItem.Email = "oskar@gmail.com";
            TestItem.PhoneNumber = 112;
            TestItem.Roles = "Admin";
            TestItem.Gender = false;
            TestItem.DOB = Convert.ToDateTime("19/04/1996");
            AllStaff.ThisStaff = TestItem;
            //add the record
            PrimaryKey = AllStaff.Add();
            //set primary key of the test data
            TestItem.Id = PrimaryKey;
            //assign the data to the property
            AllStaff.ThisStaff.Find(PrimaryKey);
            //test to see thisStaff matches the test data
            Assert.AreEqual(AllStaff.ThisStaff, TestItem);    
        }

       /* public void UpdateMethodOK()
        {
        //create an instance of the Staff Collection Class
        clsStaffCollection AllStaff = new clsStaffCollection();
        clsStaff TestItem = new clsStaff();
        Int32 PrimaryKey = 0;
         //TestItem.Id = 2;
         TestItem.Name = "A name";
         TestItem.Email = "an email";
         TestItem.PhoneNumber = 112;
         TestItem.Roles = "some role";
        //TestItem.Gender = false;
        //TestItem.DOB = Convert.ToDateTime("19/04/1996");
        //assign the data to the property
         AllStaff.ThisStaff = TestItem;
         PrimaryKey = AllStaff.Add();
         TestItem.Id = PrimaryKey;

        //modified data
         TestItem.Id = 4;
         TestItem.Name = " Another Name";
         TestItem.PhoneNumber = 114;
         TestItem.Roles = "Another Role";
         //TestItem.Gender = true;
         //TestItem.DOB = Convert.ToDateTime("20/05/1999");
         //assign the data to the property
         AllStaff.ThisStaff = TestItem;
         AllStaff.Update();
         AllStaff.ThisStaff.Find(PrimaryKey);
        Assert.AreEqual(AllStaff.ThisStaff, TestItem);       
        }

    */

        [TestMethod]
        public void DeleteMethodOK()
        {
            //create an instance of the Staff Collection Class
            clsStaffCollection AllStaff = new clsStaffCollection();
            //Create item to test data
            clsStaff TestItem = new clsStaff();
            //Var to store the primary key
            Int32 PrimaryKey = 0;
            //Set properties
            TestItem.Id = 2;
            TestItem.Name = "Oskar Karcz";
            TestItem.Email = "oskar@gmail.com";
            TestItem.PhoneNumber = 112;
            TestItem.Roles = "Admin";
            TestItem.Gender = false;
            TestItem.DOB = Convert.ToDateTime("19/04/1996");
            //set ThisStaff to the test data
            AllStaff.ThisStaff = TestItem;
            //Add record
            PrimaryKey = AllStaff.Add();
            //Set primary key of the test data
            TestItem.Id = PrimaryKey;
            //Find record
            AllStaff.ThisStaff.Find(PrimaryKey);
            //Delete the record
            AllStaff.Delete();
            //Find record
            Boolean Found = AllStaff.ThisStaff.Find(PrimaryKey);
            //Test to check record not found
            Assert.IsFalse(Found);
        }
          
        [TestMethod]
        public void ReportByStaffIdMethodOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //FilteredStaffId.ReportByStaffId("");
            //Assert.AreEqual(AllStaff.Count, FilteredStaffId.Count);
        }

        [TestMethod]
        public void ReportByStaffIdNoneFound()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            //FilteredStaffId.ReportByStaffId("5");
            //Assert.AreEqual(0, FilteredStaffId.Count);
        }

        //public void ReportByStaffIdDataFound()
        //{
           //clsStaffCollection FilteredStaffId = new clsStaffCollection();
           // Boolean OK = true;
           // FilteredStaffId.ReportByStaffId("x");
           // if (FilteredStaffId.Count == 2)
            //{
               // if (FilteredStaffId.StaffList[0].Id != 1)
                //{
                   // OK = false;
               // }
                //if (FilteredStaffId.StaffList[0].Id != 2)
                //{
                 //   OK = false;
               // }
              //  else
              //  {
                //    OK = false;
               // }
               // Assert.IsTrue(OK);
           // }
        }
    }