using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;

namespace SocialNetwotkTest
{
    [TestClass]
    public class PhotoTests
    {
        Photo unaPhoto;


        [TestCleanup]
        public void Cleanup()
        {
            unaPhoto = null;
        }

        [TestMethod]
        public void CreatePhotoWithValidLenght()
        {
            Photo correctPhoto = new Photo("Photo/la.jpg", 4);
        }
        /*
         
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePhotoWithInvalidLenght()
        {
            Photo incorrectPhoto = new Photo("Passwor");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePhotoInvalidEmpty()
        {
            Photo incorrectPhoto = new Photo("");
        }

        [TestMethod]
        public void ValidPassworClearNotEqualsHashPhoto()
        {
            Photo hashPhoto = new Photo("Photo");
            Assert.AreNotEqual(hashPhoto.LaPhoto, "Photo");
        }

        [TestMethod]
        public void InvalidIfPhotoHashEqualsHashPhoto()
        {
            Photo hashPhoto = new Photo("Photo");
            string elHash = "Photo";
            Assert.AreEqual(hashPhoto.LaPhoto, elHash.GetHashCode().ToString());
        }

        [TestMethod]
        public void ValidCorrectCheckPhoto()
        {
            Photo unaPhoto = new Photo("P@ssw0rd10");
            Photo otraPhoto = new Photo("P@ssw0rd10");
            unaPhoto.CheckPhoto(otraPhoto);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidWrongCheckPhoto()
        {
            Photo unaPhoto = new Photo("P@ssw0rd10");
            Photo otraPhoto = new Photo("Mosswprdas10");
            unaPhoto.CheckPhoto(otraPhoto);
        }

        */


    }
}
