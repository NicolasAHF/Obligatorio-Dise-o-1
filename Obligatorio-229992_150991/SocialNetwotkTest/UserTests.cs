using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;

namespace SocialNetwotkTest
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void CreateUserWithValidUsername()
        {
            string validUsername = "User1";
            User user = new User("User1", "Nicolas");
            Assert.AreEqual(user.Username, validUsername);
        }
        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateUserWithUsernameShorterThanTheMinimumValidLength()
        {
            User user = new User("User", "Nicolas");
        }
        
        [TestMethod] 
        public void CreateUserWithValidName()
        {
            string validName = "Nicolas";
            User user = new User("User1", "Nicolas");
            Assert.AreEqual(user.Name, validName);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateUserWithEmptyName()
        {
            User user = new User("User1", "");
        }
    }
}
