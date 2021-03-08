using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace tstStaff.cs
{
    [TestClass]
    public class tstStaff
    {
        string Name = "Shivani";
        string Roles = "Admin";
        string Email = "@gmail.com";
        string DOB = DateTime.Now.Date.ToString();
        string PhoneNumber = "114";


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
            int TestData = 2;
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
            string TestData = "Admin";
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
            int Id = 2;
            Found = AStaff.Find(Id);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestStaffNoFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Id = 2;
            Found = AStaff.Find(Id);
            if (AStaff.Id != 2)
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
            Int32 Id = 2;
            Found = AStaff.Find(Id);
            if (AStaff.Name != ("Oskar Karcz"))
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
            Int32 Id = 2;
            Found = AStaff.Find(Id);
            if (AStaff.Email != ("oskar@gmail.com"))
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
            Int32 Id = 2;
            Found = AStaff.Find(Id);
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
            Int32 Id = 2;
            Found = AStaff.Find(Id);
            if (AStaff.Gender != false)
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestStaffDOBFound()
        {
            clsStaff AStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 Id = 2;
            Found = AStaff.Find(Id);
            if (AStaff.DOB != Convert.ToDateTime("19/04/1996"))
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
            Int32 Id = 2;
            Found = AStaff.Find(Id);
            if (AStaff.Roles != ("Admin"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RolesinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Roles = "";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        public void RolesMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Roles = "a";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RolesMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Roles = "aa";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RolesMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Roles = "aaaaa";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RolesMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Roles = "aaaaaa";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RolesMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Roles = "aaaaa";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RolesMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Roles = "aaa";
            Roles = Roles.PadRight(101, 'a');
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void RolesExtremeMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Roles = "";
            Roles = Roles.PadRight(500, 'a');
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
           Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {          
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Name = "";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMin()
        {
            clsStaff AStaff = new clsStaff();    
            String Error = "";           
            string Name = "a";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Name = "aa";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);         
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(49, 'a');
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(50, 'a');
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Name = "";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void NameMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(25, 'a');
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Email = "a";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Email = "aa";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(49, 'a');
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(49, 'a');
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(25, 'a');
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
    
        [TestMethod]
        public void PhoneNumberMinLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMin()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "a";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMinPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "aa";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxLessOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(49, 'a');
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMax()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(50, 'a');
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMaxPlusOne()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "";
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneNumberMid()
        {
            clsStaff AStaff = new clsStaff();
            String Error = "";
            string PhoneNumber = "";
            PhoneNumber = PhoneNumber.PadRight(25, 'a');
            Error = AStaff.Valid(Name, DOB, Roles, Email, PhoneNumber);
            Assert.AreEqual(Error, "");
        }
    }
}


  
