using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;
using System.Collections.Generic;
using System.Linq;

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
            validUser = new User("User1", validPassword, "Nicolas", "Hernandez", validBirthday, validDirection, @"C:\Users\Admin\Pictures\unnamed.jpg");
            
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
            User invalidUser = new User("User", validPassword, "Nicolas", "Hernandez", validBirthday, validDirection, @"C:\Users\Admin\Pictures\unnamed.jpg");
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
            User invalidUser = new User("User1", validPassword, "", "Hernandez", validBirthday, validDirection,@"C:\Users\Admin\Pictures\unnamed.jpg");
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
            User invalidUser = new User("User1", validPassword, "Nicolas", "", validBirthday, validDirection, @"C:\Users\Admin\Pictures\unnamed.jpg");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NameWithOnlyLetters()
        {
            User invalidUser = new User("User1", validPassword, "123", "Hernandez", validBirthday, validDirection, @"C:\Users\Admin\Pictures\unnamed.jpg");

        }
        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void LastnameWithOnlyLetters()
        {
            User invalidUser = new User("User1", validPassword, "Nicolas", "3123", validBirthday, validDirection, @"C:\Users\Admin\Pictures\unnamed.jpg");
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
            User invalidUser = new User("User1", validPassword, "Nicolas", "Hernandez", invalidBirthday, validDirection, @"C:\Users\Admin\Pictures\unnamed.jpg");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BirthdayBeforeNow()
        {
            DateTime invalidBirthday = new DateTime(2100, 12, 22);
            User invalidUser = new User("User1", validPassword, "Nicolas", "Hernandez", invalidBirthday, validDirection, @"C:\Users\Admin\Pictures\unnamed.jpg");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BirthdayNotEmpty()
        {
            DateTime invalidBirthday = new DateTime();
            User invalidUser = new User("User1", validPassword, "Fernando", "Rivera", invalidBirthday, validDirection,@"C:\Users\Admin\Pictures\unnamed.jpg");
        }

        [TestMethod]
        public void CreateUserWithValidDirection()
        {
            
            Assert.AreEqual(validDirection, validUser.Direction);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateUserWithInvalidDirectionNull()
        {
            Direction invalidDirection = new Direction();
            invalidDirection = null;
            User invalidUser = new User("User1", validPassword, "Fernando", "Rivera", validBirthday, invalidDirection, @"C:\Users\Admin\Pictures\unnamed.jpg");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateUserWithInvalidDirectionStreet()
        {
            Direction invalidDirection = new Direction();
            invalidDirection.Street = "";
            invalidDirection.City = "Montevideo";
            invalidDirection.Counrty = "Uruguay";
            User invalidUser = new User("User1", validPassword, "Fernando", "Rivera", validBirthday, invalidDirection, @"C:\Users\Admin\Pictures\unnamed.jpg");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateUserWithInvalidDirectionCity()
        {
            Direction invalidDirection = new Direction();
            invalidDirection.Street = "Francisco luis 608";
            invalidDirection.City = "";
            invalidDirection.Counrty = "Uruguay";
            User invalidUser = new User("User1", validPassword, "Fernando", "Rivera", validBirthday, invalidDirection, @"C:\Users\Admin\Pictures\unnamed.jpg");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateUserWithInvalidDirectionCountry()
        {
            Direction invalidDirection = new Direction();
            invalidDirection.Street = "Francisco luis 608";
            invalidDirection.City = "Montevideo";
            invalidDirection.Counrty = "";
            User invalidUser = new User("User1", validPassword, "Fernando", "Rivera", validBirthday, invalidDirection, @"C:\Users\Admin\Pictures\unnamed.jpg");
        }

        [TestMethod]
        public void ValidAvatarJPG()
        {
            string validAvatar = @"C:\Users\Admin\Pictures\unnamed.jpg";
            Assert.AreEqual(validUser.Avatar, validAvatar);
        }

        [TestMethod]
        public void ValidAvatarJPEG()
        {
            string validAvatar = @"C:\Users\Admin\Pictures\unnamed.jpeg";
            User validUserJPEG = new User("User1", validPassword, "Nicolas", "Hernandez", validBirthday, validDirection, @"C:\Users\Admin\Pictures\unnamed.jpeg");
            Assert.AreEqual(validUserJPEG.Avatar, validAvatar);
        }

        [TestMethod]
        public void ValidAvatarPNG()
        {
            string validAvatar = @"C:\Users\Admin\Pictures\unnamed.png";
            User validUserPNG = new User("User1", validPassword, "Nicolas", "Hernandez", validBirthday, validDirection, @"C:\Users\Admin\Pictures\unnamed.png");
            Assert.AreEqual(validUserPNG.Avatar, validAvatar);
        }

        [TestMethod]
        public void ValidAdmin()
        {
            validUser.Admin = true;
            Assert.IsTrue(validUser.Admin);
        }

        [TestMethod]
        public void ValidAdminFalse()
        {
            Assert.IsFalse(validUser.Admin);
        }

        [TestMethod]
        public void FollowingListAdding()
        {
            User validUser2 = new User("User1", validPassword, "Nicolas", "Hernandez", validBirthday, validDirection, @"C:\Users\Admin\Pictures\unnamed.png");
            validUser.Following.Add(validUser2);
            Assert.IsTrue(validUser.Following.Count() != 0);
        }

        [TestMethod]
        public void FollowingListEmpty()
        {
            Assert.IsTrue(validUser.Following.Count() == 0);
        }
    }
}
