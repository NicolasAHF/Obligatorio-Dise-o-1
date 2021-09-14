using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;

namespace SocialNetwotkTest
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void CreateUserWithValidName()
        {
            User user = new User();
            user.Username = "User1";
            string validUsername = "User1";
            Assert.AreEqual(user.Username, validUsername);
        }
    }
}
