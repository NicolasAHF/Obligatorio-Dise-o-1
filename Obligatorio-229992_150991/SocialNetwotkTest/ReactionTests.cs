using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetworkTest
{
    [TestClass]
    public class ReactionTests
    {

        Comment validReaction;

        User validUser;
        DateTime validBirthday = new DateTime(1999, 12, 22);
        Direction validDirection = new Direction();
        Password validPassword = new Password("P@ssword10");
        Photo validPhoto = new Photo("Album/Verano 2021.jpg", 5);
        bool admin = true;


        [TestInitialize]
        public void Setup()
        {
            validUser = new User("User1", validPassword, "Nicolas", "Hernandez", validBirthday, validDirection, validPhoto, admin);
        }

        [TestCleanup]
        public void Cleanup()
        {
            validReaction = null;
        }

        [TestMethod]
        public void CreateReactionWithValidUserAndComment()
        {
            string theReaction = "Me Gusta";
            Reaction calidReaction = new Reaction(theReaction, validUser);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateReactionEmpty()
        {
            string theReaction = "";
            Comment validComment = new Comment(theReaction, validUser);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateReactionWithNullUser()
        {
            string theReaction = "Me Gusta";
            Reaction calidReaction = new Reaction(theReaction, null);
        }
    }
}
