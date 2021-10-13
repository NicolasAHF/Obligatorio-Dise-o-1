using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;

namespace SocialNetwokTest
{
    [TestClass]
    public class AlbumTests
    {
        ListeningNow validListeningNow;

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
            Photo correctPhoto = new Photo("Album/Verano 2021.jpg", 5);
            Album validAlbum = new Album("Verano 2021");
            validAlbum.addPhoto(correctPhoto);
        }

        [TestMethod]
        public void CreateAlbumWithMaxValidPhoto()
        {
            Album validAlbum = new Album("Verano 2021");
            
            for (int i = 0; i < 10; i++)
            {
                Photo correctPhoto = new Photo($"Album/Verano 2021 {i}.jpg", 5);
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
                Photo correctPhoto = new Photo($"Album/Verano 2021 {i}.jpg", 5);
                validAlbum.addPhoto(correctPhoto);
            }

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateAlbumWithRepetidPhoto()
        {
            Album validAlbum = new Album("Verano 2021");
            Photo correctPhoto = new Photo("Album/Verano 2021.jpg", 5);
            for (int i = 0; i < 2; i++)
            {
                validAlbum.addPhoto(correctPhoto);
            }

        }
    }
}


