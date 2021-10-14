using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;

namespace SocialNetworkTest
{
    [TestClass]
    public class PasswordTests
    {
        private Password unaPassword;


        [TestCleanup]
        public void Cleanup()
        {
            unaPassword = null;
        }

        [TestMethod]
        public void CreatePasswordWithValidLenght()
        {
            Password correctPassword = new Password("Password");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePasswordWithInvalidLenght()
        {
            Password incorrectPassword = new Password("Passwor");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePasswordInvalidEmpty()
        {
            Password incorrectPassword = new Password("");
        }

        [TestMethod]
        public void ValidPassworClearNotEqualsHashPassword()
        {
            Password hashPassword = new Password("Password");
            Assert.AreNotEqual(hashPassword.LaPassword, "Password");
        }

        [TestMethod]
        public void InvalidIfPasswordHashEqualsHashPassword()
        {
            Password hashPassword = new Password("Password");
            string elHash = "Password";
            Assert.AreEqual(hashPassword.LaPassword, elHash.GetHashCode().ToString());
        }

        [TestMethod]
        public void ValidCorrectCheckPassword()
        {
            Password unaPassword = new Password("P@ssw0rd10");
            Password otraPassword = new Password("P@ssw0rd10");
            unaPassword.CheckPassword(otraPassword);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidWrongCheckPassword()
        {
            Password unaPassword = new Password("P@ssw0rd10");
            Password otraPassword = new Password("Mosswprdas10");
            unaPassword.CheckPassword(otraPassword);
        }
    }
}