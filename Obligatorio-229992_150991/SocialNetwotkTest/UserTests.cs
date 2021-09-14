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
            User user = new User("User1");
            Assert.AreEqual(user.Username, validUsername);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateUserWithUsernameShorterThanTheMinimumValidLength()
        {
            User user = new User("User");
        }
    }
}
