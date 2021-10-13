using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;

namespace SocialNetworkTest
{
    [TestClass]
    public class DirectoryGameTests
    {

        private string validName = "Hitman 3";
        private string validCategory = "Action";
        Photo validPhoto = new Photo("Game/Hitman 3.jpg", 5);
        private DirectoryGame directory;

        [TestInitialize]
        public void Setup()
        {
            directory = new DirectoryGame();
        }

        [TestMethod]
        public void CreateAndAddValidGame()
        {
            Game validGame = new Game(validName, validCategory, validPhoto);
            directory.AddGame(validGame);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateandAddDuplicatedInValidGame()
        {
            Game validGame = new Game(validName, validCategory, validPhoto);
            directory.AddGame(validGame); 
            directory.AddGame(validGame);
        }

        [TestMethod]
        public void DeleteValidGame()
        {
            Game validGame = new Game(validName, validCategory, validPhoto);
            directory.AddGame(validGame);
            directory.RemoveGame(validGame);
        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]

        public void DeletePlayedValidGame()
        {
            Game validGame = new Game(validName, validCategory, validPhoto);
            validGame.SetPlayed();
            directory.AddGame(validGame);
            directory.RemoveGame(validGame);
        }
    }
}
