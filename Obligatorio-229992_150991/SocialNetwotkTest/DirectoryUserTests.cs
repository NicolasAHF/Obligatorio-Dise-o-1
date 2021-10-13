using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;

namespace SocialNetworkTest
{
    [TestClass]
    public class DirectoryUserTests
    {
        private User user;
        DateTime validBirthday = new DateTime(1999, 12, 22);
        Direction validDirection = new Direction();
        private DirectoryUser directory;
        Password validPassword = new Password("P@ssword10");
        Photo validPhoto = new Photo("Album/Verano 2021.jpg", 5);

        [TestInitialize]
        public void Setup()
        {
            validDirection.City = "Montevideo";
            validDirection.Counrty = "Uruguay";
            validDirection.Street = "Francisco luis 608";
            user = new User("User1", validPassword, "Nicolas", "Hernandez", validBirthday, validDirection, validPhoto);
            directory = new DirectoryUser();
        }

        [TestCleanup]
        public void Cleanup()
        {
            user = null;
            directory = null;
        }

        [TestMethod]
        public void CreateDirectory()
        {
            Assert.IsNotNull(directory);
        }

        [TestMethod]
        public void CreateNewCategoryDirectoryShouldBeEmpty()
        {
            Assert.IsTrue(directory.IsEmpty());
        }

        [TestMethod]
        public void AddUser()
        {
            directory.AddUser(user);
            Assert.AreEqual(directory.Count(), 1);
        }

        [TestMethod]
        public void DirectoryShouldBeEmpty()
        {
            Assert.IsFalse(directory.UsersAdded(user));
        }
        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddUserThatAlreadyExistsThrowsException()
        {
            directory.AddUser(user);
            User userWithSameUsername = new User("User1", validPassword, "Antonio", "Hernandez", validBirthday, validDirection, validPhoto);
            directory.AddUser(userWithSameUsername);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddUserWhitSameUsernameDifferentCaseThrowsAlreadyExistsException()
        {
            directory.AddUser(user);
            string usernameUperCase = user.Username.ToUpper();
            User userWithSameUsername = new User("User1", validPassword, "Antonio", "Hernandez", validBirthday, validDirection, validPhoto);
            directory.AddUser(userWithSameUsername);
        }

        [TestMethod]
        public void RemoveUser()
        {
            directory.AddUser(user);

            directory.RemoveUser(user);

            Assert.AreEqual(directory.Count(), 0);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidRemoveUser()
        {
            directory.RemoveUser(user);
        }

        [TestMethod]
        public void GetUser()
        {
            directory.AddUser(user);
            User user2 = directory.GetUser("User1");
            Assert.AreEqual(user, user2);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidGetUser()
        {
            User user2 = directory.GetUser("User1");
        }
    }
}
