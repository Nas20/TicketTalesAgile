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
            string TestData = "shivani vital";
            AStaff.Name = TestData;
            Assert.AreEqual(AStaff.Name, TestData);
        }

        [TestMethod]
        public void EmailOK()
        {
            clsStaff AStaff = new clsStaff();
            string TestData = "shivani@gmail.com";
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
        public void  DOBOK()
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

    }

}

