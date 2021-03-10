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
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.IsNotNull(AllStaff);
        }

        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();

            TestItem.Id = 2;
            TestItem.Name = "Oskar Karcz";
            TestItem.Email = "oskar@gmail.com";
            TestItem.PhoneNumber = 112;
            TestItem.Roles = "Admin";
            TestItem.Gender = true;
            TestItem.DOB = Convert.ToDateTime("19/04/1996");
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }

     
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.Id = 2;
            TestItem.Name = "Oskar Karcz";
            TestItem.Email = "oskar@gmail.com";
            TestItem.PhoneNumber = 112;
            TestItem.Roles = "Admin";
            TestItem.Gender = true;
            TestItem.DOB = Convert.ToDateTime("19/04/1996");
            TestList.Add(TestItem);
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.StaffList, TestList);

        }
        

        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            TestItem.Id = 2;
            TestItem.Name = "Oskar Karcz";
            TestItem.Email = "oskar@gmail.com";
            TestItem.PhoneNumber = 112;
            TestItem.Roles = "Admin";
            TestItem.Gender = false;
            TestItem.DOB = Convert.ToDateTime("19/04/1996");
            AllStaff.StaffList = TestList;
            Assert.AreEqual(AllStaff.ThisStaff, TestList);

        }

/*
        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Assert.AreEqual(AllStaff.Count, 2);
        }
        
        */

        [TestMethod]
        public void CountPropertyOK()
        {
            clsStaffCollection AllStaff = new clsStaffCollection();
            Int32 SomeCount = 2;
            AllStaff.Count = SomeCount;
            Assert.AreNotEqual(AllStaff.Count, SomeCount);
        }
    }
    }

