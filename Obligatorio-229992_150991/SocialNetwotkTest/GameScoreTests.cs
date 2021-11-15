using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocialNetwork;
using System;

namespace SocialNetworkTest
{
    [TestClass]
    public class GameScoreTests
    {
        private string validName = "Hitman 3";
        private int  validScore = 10;
  

        [TestMethod]
        public void CreateGameWithValidName()
        {
            GameScore validGameScore = new GameScore(validName, validScore);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateGameWithInvalidvalidNameEmpty()
        {
            string invalidName = "";
            GameScore validGameScore = new GameScore(invalidName, validScore); ;
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateGameWithInvalidvalidNameNull()
        {
            string invalidName = null;
            GameScore validGameScore = new GameScore(invalidName, validScore);
        }

        [TestMethod]
        public void CreateGameWithValidvalidScore()
        {
            GameScore validGameScore = new GameScore(validName, validScore);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateGameWithInValidvalidScore()
        {
            int invalidScore = -1;
            GameScore validGameScore = new GameScore(validName, invalidScore);
        }
    }
}


