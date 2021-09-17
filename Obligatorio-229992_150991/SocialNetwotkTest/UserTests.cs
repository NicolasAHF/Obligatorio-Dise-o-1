using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;

namespace SocialNetwotkTest
{
    [TestClass]
    public class UserTests
    {
       
        User validUser;
        DateTime validBirthday = new DateTime(1999, 12, 22);

        [TestInitialize]
        public void Setup()
        {
            validUser = new User("User1", "Nicolas", "Hernandez", validBirthday);
        }

        [TestCleanup]
        public void Cleanup()
        {
            validUser = null;
        }

        [TestMethod]
        public void CreateUserWithValidUsername()
        {
            string validUsername = "User1";
            Assert.AreEqual(validUser.Username, validUsername);
        }
        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateUserWithUsernameShorterThanTheMinimumValidLength()
        {
            User invalidUser = new User("User", "Nicolas", "Hernandez", validBirthday);
        }
        
        [TestMethod] 
        public void CreateUserWithValidName()
        {
            string validName = "Nicolas";
            Assert.AreEqual(validUser.Name, validName);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateUserWithEmptyName()
        {
            User invalidUser = new User("User1", "", "Hernandez", validBirthday);
        }

        [TestMethod]
        public void CreateUserWithValidLastname()
        {
            string validLastName = "Hernandez";
            Assert.AreEqual(validUser.Lastname, validLastName);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateUserWithEmptyLastname()
        {
            User invalidUser = new User("User1", "Nicolas", "", validBirthday);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NameWithOnlyLetters()
        {
            User invalidUser = new User("User1", "123", "Hernandez", validBirthday);

        }
        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void LastnameWithOnlyLetters()
        {
            User invalidUser = new User("User1", "Nicolas", "3123", validBirthday);
        }

        [TestMethod]
        public void CreateUserWithValidBirthday()
        {
            DateTime compareBirthday = new DateTime(1999, 12, 22);
            bool result = compareBirthday.Equals(validUser.DateOfBirth);
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BirthdayAfter1940()
        {
            DateTime invalidBirthday = new DateTime(1940, 12, 22);
            User validUser = new User("User1", "Nicolas", "Hernandez", invalidBirthday);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BirthdayBeforeNow()
        {
            DateTime invalidBirthday = new DateTime(2100, 12, 22);
            User validUser = new User("User1", "Nicolas", "Hernandez", invalidBirthday);
        }

        [TestMethod]
        public void CreateUserWithValidDirection()
        {
            Direction validDirection = new Direction();
            validDirection.City = "Montevideo";
            validDirection.Counrty = "Uruguay";
            validDirection.Street = "Francisco luis 608";
            validUser.Direction = validDirection;
            Assert.AreEqual(validDirection, validUser.Direction);
        }
    }
}
