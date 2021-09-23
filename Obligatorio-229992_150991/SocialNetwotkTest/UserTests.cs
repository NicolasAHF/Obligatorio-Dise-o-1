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
        Direction validDirection = new Direction();
        string validPassword;


        [TestInitialize]
        public void Setup()
        {
            validDirection.City = "Montevideo";
            validDirection.Counrty = "Uruguay";
            validDirection.Street = "Francisco luis 608";
            validPassword = "P@ssword10";
            validUser = new User("User1", "Nicolas", "Hernandez", validBirthday, validDirection, validPassword);
            
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
            User invalidUser = new User("User", "Nicolas", "Hernandez", validBirthday, validDirection, validPassword);
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
            User invalidUser = new User("User1", "", "Hernandez", validBirthday, validDirection, validPassword);
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
            User invalidUser = new User("User1", "Nicolas", "", validBirthday, validDirection, validPassword);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NameWithOnlyLetters()
        {
            User invalidUser = new User("User1", "123", "Hernandez", validBirthday, validDirection, validPassword);

        }
        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void LastnameWithOnlyLetters()
        {
            User invalidUser = new User("User1", "Nicolas", "3123", validBirthday, validDirection, validPassword);
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
            User invalidUser = new User("User1", "Nicolas", "Hernandez", invalidBirthday, validDirection, validPassword);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BirthdayBeforeNow()
        {
            DateTime invalidBirthday = new DateTime(2100, 12, 22);
            User invalidUser = new User("User1", "Nicolas", "Hernandez", invalidBirthday, validDirection, validPassword);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BirthdayNotEmpty()
        {
            DateTime invalidBirthday = new DateTime();
            User invalidUser = new User("User1", "Fernando", "Rivera", invalidBirthday, validDirection, validPassword);
        }

        [TestMethod]
        public void CreateUserWithValidDirection()
        {
            
            Assert.AreEqual(validDirection, validUser.Direction);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateUserWithInvalidDirection()
        {
            Direction invalidDirection = new Direction();
            invalidDirection = null;
            User invalidUser = new User("User1", "Fernando", "Rivera", validBirthday, invalidDirection, validPassword);
        }
    }
}
