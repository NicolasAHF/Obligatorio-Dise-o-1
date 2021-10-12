using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;

namespace SocialNetworkTest
{
    [TestClass]
    public class PhotoTests
    {

        [TestMethod]
        public void CreatePhotoWithValidFormatAndSizeJPGToLower()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.jpg", 5);
        }

        [TestMethod]
        public void CreatePhotoWithValidFormatAndSizeJPEGToLower()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.jpeg", 5);
        }

        [TestMethod]
        public void CreatePhotoWithValidFormatAndSizePNGToLower()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.png", 5);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
         public void CreatePhotoWithInvalidFormatToLower()
         {
            Photo correctPhoto = new Photo("Album/Verano 2021.mp3", 5);
         }

        [TestMethod]
        public void CreatePhotoWithValidFormatAndSizeJPGToUpper()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.JPG", 5);
        }

        [TestMethod]
        public void CreatePhotoWithValidFormatAndSizeJPEGToUpper()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.JPEG", 5);
        }

        [TestMethod]
        public void CreatePhotoWithValidFormatAndSizePNGToUpper()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.PNG", 5);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePhotoWithInvalidFormatToUpper()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.MP3", 5);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePhotoInvalidEmptyPath()
        {
            Photo correctPhoto = new Photo("", 5);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePhotoInvalidNullPath()
        {
            Photo correctPhoto = new Photo(null, 5);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePhotoWithInvalidMaxSize()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.jpg", 6);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePhotoInvalidMinSize()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.jpg", -1);
        }
    }
}
