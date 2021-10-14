using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;

namespace SocialNetworkTest
{
    [TestClass]
    public class AlbumTests
    {
        ListeningNow validListeningNow;
        const int ValidMaxSize = 5000000; //Byte
        const int InvalidMaxSize = 5000001; //Byte

        [TestMethod]
        public void CreateAlbumWithValidName()
        {
            Album validName = new Album("Verano 2021");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateAlbumWithEmptyName()
        {
            Album invalidName = new Album("");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateAlbumWithLetterName()
        {
            Album invalidName = new Album("a");
        }


        [TestMethod]
        public void CreateAlbumWithValidPhoto()
        {
            Photo correctPhoto = new Photo("Album/Verano 2021.jpg", ValidMaxSize) ;
            Album validAlbum = new Album("Verano 2021");
            validAlbum.addPhoto(correctPhoto);
        }

        [TestMethod]
        public void CreateAlbumWithMaxValidPhoto()
        {
            Album validAlbum = new Album("Verano 2021");
            
            for (int i = 0; i < 10; i++)
            {
                Photo correctPhoto = new Photo($"Album/Verano 2021 {i}.jpg", ValidMaxSize);
                validAlbum.addPhoto(correctPhoto);
            }

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateAlbumWithMaxInvalidPhoto()
        {
            Album validAlbum = new Album("Verano 2021");
            for (int i = 0; i < 11; i++)
            {
                Photo correctPhoto = new Photo($"Album/Verano 2021 {i}.jpg", ValidMaxSize);
                validAlbum.addPhoto(correctPhoto);
            }

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateAlbumWithRepetidPhoto()
        {
            Album validAlbum = new Album("Verano 2021");
            Photo correctPhoto1 = new Photo("Album/Verano 2021.jpg", ValidMaxSize);
            Photo correctPhoto2 = new Photo("Album/Verano 2021.jpg", ValidMaxSize);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateAlbumWithMaxInvalidPhotoSize()
        {
            Album validAlbum = new Album("Verano 2021");
            Photo invalidPhoto = new Photo($"Album/Verano 2021.jpg", InvalidMaxSize);
            validAlbum.addPhoto(invalidPhoto);
        }
    }
}


