using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetworkTest
{
    [TestClass]
    public class UserTests
    {
       
        User validUser;
        DateTime validBirthday = new DateTime(1999, 12, 22);
        Direction validDirection = new Direction();
        Password validPassword = new Password("P@ssword10");
        Photo validPhoto = new Photo("Album/Verano 2021.jpg", 5);
        bool admin = true;

          [TestInitialize]
    public void Setup()
        {
            validDirection.City = "Montevideo";
            validDirection.Counrty = "Uruguay";
            validDirection.Street = "Francisco luis 608";
        validUser = new User("User1", validPassword, "Nicolas", "Hernandez", validBirthday, validDirection, validPhoto, admin);
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
            User invalidUser = new User("User", validPassword, "Nicolas", "Hernandez", validBirthday, validDirection, validPhoto, admin);
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
            User invalidUser = new User("User1", validPassword, "", "Hernandez", validBirthday, validDirection, validPhoto, admin);
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
            User invalidUser = new User("User1", validPassword, "Nicolas", "", validBirthday, validDirection, validPhoto, admin);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NameWithOnlyLetters()
        {
            User invalidUser = new User("User1", validPassword, "123", "Hernandez", validBirthday, validDirection, validPhoto, admin);

        }
        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void LastnameWithOnlyLetters()
        {
            User invalidUser = new User("User1", validPassword, "Nicolas", "3123", validBirthday, validDirection, validPhoto, admin);
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
            User invalidUser = new User("User1", validPassword, "Nicolas", "Hernandez", invalidBirthday, validDirection, validPhoto, admin);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BirthdayBeforeNow()
        {
            DateTime invalidBirthday = new DateTime(2100, 12, 22);
            User invalidUser = new User("User1", validPassword, "Nicolas", "Hernandez", invalidBirthday, validDirection, validPhoto, admin);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BirthdayNotEmpty()
        {
            DateTime invalidBirthday = new DateTime();
            User invalidUser = new User("User1", validPassword, "Fernando", "Rivera", invalidBirthday, validDirection, validPhoto, admin);
        }

        [TestMethod]
        public void ChangePasswordWithValidUserEnteredPassword()
        {
            validPassword.SetPasswordEncription("P@ssword10");
            validUser = new User("User1", validPassword, "Fernando", "Rivera", validBirthday, validDirection, validPhoto, admin);
            Password userEnteredActualPassword = new Password("P@ssword10");
            Password newPassword = new Password("Password20");
            validUser.ChangePassword(validUser, userEnteredActualPassword, newPassword);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ChangePasswordWithInvalidUserEnteredPassword()
        {
            Password validPassword = new Password("P@ssword10");
            validUser = new User("User1", validPassword, "Fernando", "Rivera", validBirthday, validDirection, validPhoto, admin);
            Password userEnteredPassword = new Password("Contraseña20");
            Password newPassword = new Password("Password20");
            validUser.ChangePassword(validUser, userEnteredPassword, newPassword);
        }

        [TestMethod]
        public void ValidTrueAdmin()
        {
            validUser.SetAdmin(true);
            Assert.IsTrue(validUser.Admin);
        }


        [TestMethod]
        public void ValidFalseAdmin()
        {
            validUser.SetAdmin(false);
            Assert.IsFalse(validUser.Admin);
        }


        [TestMethod]
        public void FollowingListAdding()
        {
            User validUser2 = new User("User1", validPassword, "Nicolas", "Hernandez", validBirthday, validDirection, validPhoto, admin);
            validUser.Following.Add(validUser2);
            Assert.IsTrue(validUser.Following.Count() != 0);
        }

        [TestMethod]
        public void FollowingListEmpty()
        {
            Assert.IsTrue(validUser.Following.Count() == 0);
        }

        [TestMethod]
        public void ValidSetStatus()
        {
            User validUser = new User("User1", validPassword, "Fernando", "Rivera", validBirthday, validDirection, validPhoto, admin);
            validUser.SetStatus("Día lluvioso hermoso para programar");
        }

        [TestMethod]
        public void ValidMinSetStatus()
        {
            User validUser = new User("User1", validPassword, "Fernando", "Rivera", validBirthday, validDirection, validPhoto, admin);

            string status = "a";
            for (int i = 0; i < 9; i++)
            {
                status += "a";
            }
            validUser.SetStatus(status);
        }

        [TestMethod]
        public void ValidMaxSetStatus()
        {
            User validUser = new User("User1", validPassword, "Fernando", "Rivera", validBirthday, validDirection, validPhoto, admin);

            string status = "a";
            for (int i = 0; i < 159; i++)
            {
                status += "a";
            }
            validUser.SetStatus(status);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidMinSetStatus()
        {
            User validUser = new User("User1", validPassword, "Fernando", "Rivera", validBirthday, validDirection, validPhoto, admin);

            string status = "a";
            for (int i = 0; i < 8; i++)
            {
                status += "a";
            }
            validUser.SetStatus(status);
        }
    
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidMaxSetStatus()
        {
            User validUser = new User("User1", validPassword, "Fernando", "Rivera", validBirthday, validDirection, validPhoto, admin);
            
            string status = "a";
            for (int i = 0; i < 160; i++)
            {
                status += "a";                
            }
            validUser.SetStatus(status);
        }

    }
}
