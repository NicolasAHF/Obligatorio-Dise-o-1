using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;

namespace SocialNetworkTest
{
    [TestClass]
    public class DirectoryGameTests
    {
        private User validUserAdmin;
        private User validUserNonAdmin;
        private DateTime validBirthday = new DateTime(1999, 12, 22);
        private Direction validDirection = new Direction();
        private Password validPassword = new Password("P@ssword10");
        private Photo validPhoto = new Photo("Album/Verano 2021.jpg", 5);

        private string validName = "Hitman 3";
        private string validCategory = "Action";
        private Photo validCase = new Photo("Game/Hitman 3.jpg", 5);
        private DirectoryGame directory;
        private bool adminT = true;
        private bool adminF = true;

        [TestInitialize]
        public void Setup()
        {
            validDirection.City = "Montevideo";
            validDirection.Counrty = "Uruguay";
            validDirection.Street = "Francisco luis 608";
            validUserAdmin = new User("User1", validPassword, "Nicolas", "Hernandez", validBirthday, validDirection, validPhoto, adminT);
            validUserNonAdmin = new User("User2", validPassword, "Fernando", "Rivera", validBirthday, validDirection, validPhoto, adminF);

            validUserAdmin.SetAdmin(true);
            validUserNonAdmin.SetAdmin(false);

            directory = new DirectoryGame();
        }

        [TestMethod]
        public void CreateAndAddValidGame()
        {
            validUserAdmin.SetAdmin(true);
            Game validGame = new Game(validName, validCategory, validCase);
            directory.AddGame(validGame, validUserAdmin);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateAndAddValidGameWithNonAdmin()
        {
            Game validGame = new Game(validName, validCategory, validCase);
            directory.AddGame(validGame, validUserNonAdmin);
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateandAddDuplicatedInValidGame()
        {
            Game validGame = new Game(validName, validCategory, validCase);
            directory.AddGame(validGame, validUserAdmin); 
            directory.AddGame(validGame, validUserAdmin);
        }

        [TestMethod]
        public void DeleteValidGameWithAdmin()
        {
            validUserAdmin.SetAdmin(true);
            Game validGame = new Game(validName, validCategory, validPhoto);
            directory.AddGame(validGame, validUserAdmin);
            directory.RemoveGame(validGame, validUserAdmin);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DeleteValidGameWithNonAdmin()
        {
            Game validGame = new Game(validName, validCategory, validPhoto);
            directory.AddGame(validGame, validUserAdmin);
            directory.RemoveGame(validGame, validUserNonAdmin);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]

        public void DeletePlayedValidGame()
        {
            Game validGame = new Game(validName, validCategory, validCase);
            validGame.SetPlayed();
            directory.AddGame(validGame, validUserAdmin);
            directory.RemoveGame(validGame, validUserAdmin);
        }
    }
}
