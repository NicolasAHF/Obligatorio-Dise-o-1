using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;

namespace SocialNetworkTest
{
    [TestClass]
    public class PhotoTests
    {
        const int ValidMaxSize = 5000; //Byte
        const int InvalidMaxSize = 5001; //Byte
        [TestMethod]
        public void CreatePhotoWithValidFormatAndSizeJPGToLower()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.jpg", ValidMaxSize);
        }

        [TestMethod]
        public void CreatePhotoWithValidFormatAndSizeJPEGToLower()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.jpeg", ValidMaxSize);
        }

        [TestMethod]
        public void CreatePhotoWithValidFormatAndSizePNGToLower()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.png", ValidMaxSize);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
         public void CreatePhotoWithInvalidFormatToLower()
         {
            Photo correctPhoto = new Photo("Album/Verano 2021.mp3", ValidMaxSize);
         }

        [TestMethod]
        public void CreatePhotoWithValidFormatAndSizeJPGToUpper()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.JPG", ValidMaxSize);
        }

        [TestMethod]
        public void CreatePhotoWithValidFormatAndSizeJPEGToUpper()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.JPEG", ValidMaxSize);
        }

        [TestMethod]
        public void CreatePhotoWithValidFormatAndSizePNGToUpper()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.PNG", ValidMaxSize);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePhotoWithInvalidFormatToUpper()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.MP3", ValidMaxSize);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePhotoInvalidEmptyPath()
        {
            Photo correctPhoto = new Photo("", ValidMaxSize);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePhotoInvalidNullPath()
        {
            Photo correctPhoto = new Photo(null, ValidMaxSize);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePhotoWithInvalidMaxSize()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.jpg", InvalidMaxSize);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePhotoInvalidMinSize()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.jpg", -1);
        }
    }
}
