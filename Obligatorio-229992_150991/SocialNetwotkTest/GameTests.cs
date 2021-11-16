using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocialNetwork;
using System;

namespace SocialNetworkTest
{
    [TestClass]
    public class GameTests
    {
        private string validName = "Hitman 3";
        private string validCategory = "Action";
        const int ValidMaxSize = 5000000; //Byte
        const int InvalidMaxSize = 5000001; //Byte
        Photo validPhoto = new Photo("Game/Hitman 3.jpg", ValidMaxSize);

        [TestMethod]
        public void CreateGameWithValidName()
        {
            Game validGame = new Game(validName, validCategory, validPhoto);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateGameWithInvalidvalidNameEmpty()
        {
            string invalidName = "";
            Game validGame = new Game(invalidName, validCategory, validPhoto);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateGameWithInvalidvalidNameNull()
        {
            string invalidName = null;
            Game validGame = new Game(invalidName, validCategory, validPhoto);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateGameWithInvalidvalidCategoryEmpty()
        {
            string invalidCategory = "";
            Game validGame = new Game(validName, invalidCategory, validPhoto);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateGameWithInvalidvalidCategoryNull()
        {
            string invalidCategory = null;
            Game validGame = new Game(validName, invalidCategory, validPhoto);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateGameWithInvalidvalidCoverPathEmpy()
        {
            Photo invalidPhoto = new Photo("", 5);
            Game validGame = new Game(validName, validCategory, invalidPhoto);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateGameWithInvalidvalidCoverPathNull()
        {
            Photo invalidPhoto = new Photo(null, 5);
            Game validGame = new Game(validName, validCategory, invalidPhoto);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateGameWithInvalidvalidCoverMaxSize()
        {
            Photo invalidPhoto = new Photo("Game/Hitman 3.jpg", InvalidMaxSize);
            Game validGame = new Game(validName, validCategory, invalidPhoto);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateGameWithInvalidvalidCoverNegativeSize()
        {
            Photo invalidPhoto = new Photo("Game/Hitman 3.jpg", -1);
            Game validGame = new Game(validName, validCategory, invalidPhoto);
        }

        [TestMethod]
        public void CreateGameWithValidvalPlayerd()
        {
            Game validGame = new Game(validName, validCategory, validPhoto);
            validGame.SetPlayed();
            Assert.IsTrue(validGame.Played >= 0);
        }
    }
}


