using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;

namespace SocialNetworkTest
{
    [TestClass]
    public class PhotoTests
    {

        [TestMethod]
        public void CreatePhotoWithValidFormatAndSize()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.jpg", 5);
        }

        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
         public void CreatePhotoWithInvalidFormat()
         {
            Photo correctPhoto = new Photo("Album/Verano 2021.mp3", 5);
         }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePhotoInvalidEmptyPath()
        {
            Photo correctPhoto = new Photo("", 5);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePhotoWithInvalidMaxSize()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.mp3", 6);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreatePhotoInvalidMinSize()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.mp3", -1);
        }
    }
}
