using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tstStaff.cs
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaff AStaff = new clsStaff();
            Assert.IsNotNull(AStaff);
        }
 
        [TestMethod]
        public void IdOK()
        {
            clsStaff AStaff = new clsStaff();
            int TestData = 1;
            AStaff.Id = TestData;
            Assert.AreEqual(AStaff.Id, TestData);
        }

        [TestMethod]
        public void PhoneNumberOK()
        {
            clsStaff AStaff = new clsStaff();
            int TestData = 112;
            AStaff.PhoneNumber = TestData;
            Assert.AreEqual(AStaff.PhoneNumber, TestData);
        }

        [TestMethod]
        public void NameOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "Oskar Karcz";
            AStaff.Name = TestData;
            Assert.AreEqual(AStaff.Name, TestData);
        }

        [TestMethod]
        public void EmailOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "oskar@gmail.com";
            AStaff.Email = TestData;
            Assert.AreEqual(AStaff.Email, TestData);
        }

        [TestMethod]
        public void RolesOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "Seller";
            AStaff.Roles = TestData;
            Assert.AreEqual(AStaff.Roles, TestData);
        }

        [TestMethod]
        public void DOBOK()
        {
            clsStaff AStaff = new clsStaff();
            DateTime TestData = DateTime.Now.Date;
            AStaff.DOB = TestData;
            Assert.AreEqual(AStaff.DOB, TestData);
        }

        [TestMethod]
        public void GenderOK()
        {
            clsStaff AStaff = new clsStaff();
            Boolean TestData = true;
            AStaff.Gender = TestData;
            Assert.AreEqual(AStaff.Gender, TestData);
        }
    
        [TestMethod]
        public void FindMethodOK()
       {
           clsStaff AStaff = new clsStaff();
           Boolean Found = false;
           int Id = 1;
           Found = AStaff.Find(Id);
           Assert.IsTrue(Found);
       }   

        [TestMethod]
        public void TestStaffNoFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Id = 21;
            Found = AStaff.Find(Id);
            if(AStaff.Id != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffNameFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 2;
            Found = AStaff.Find(StaffId);
            if (AStaff.Name != ("Test Name"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffEmailFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 2;
            Found = AStaff.Find(StaffId);
            if (AStaff.Email != ("Test Email"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffPhoneNumberFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 2;
            Found = AStaff.Find(StaffId);
            if (AStaff.PhoneNumber != 112)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffGenderFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 2;
            Found = AStaff.Find(StaffId);
            if (AStaff.Gender != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffDOBFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 2;         
            Found = AStaff.Find(StaffId);
            if(AStaff.DOB != Convert.ToDateTime("19/04/1996"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffRolesFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 2;         
            Found = AStaff.Find(StaffId);
            if (AStaff.Roles != ("Test Roles"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}

