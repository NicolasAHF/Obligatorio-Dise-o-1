using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetworkTest
{
    [TestClass]
    public class CommentTests
    {
       
        Comment validComment;

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
            validComment = null;
        }

        [TestMethod]
        public void CreateCommentWithValidUserAndComment()
        {
            string theComment = "Muy bueno el obligatorio realizado por el equipo";
            Comment validComment = new Comment(theComment, validUser);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateCommentEmpty()
        {
            string theComment = "";
            Comment validComment = new Comment(theComment, validUser);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateCommentWithNullUser()
        {
            string theComment = "Muy bueno el obligatorio realizado por el equipo";
            Comment validComment = new Comment(theComment, null);
        }
    }
}
