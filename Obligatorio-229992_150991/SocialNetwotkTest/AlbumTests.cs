using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocialNetwork;
using System;

namespace SocialNetwotkTest
{
    [TestClass]
    public class AlbumTests
    {
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
    }
}


