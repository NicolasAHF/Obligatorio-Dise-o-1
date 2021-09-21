using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;

namespace SocialNetwotkTest
{
    [TestClass]
    public class ListeningNowTest
    {
        ListeningNow validListeningNow;

        [TestInitialize]
        public void Setup()
        {

            validListeningNow = new ListeningNow("High", "Maria Becerra", "Animal");

        }

        [TestMethod]
        public void ValidSongNameCreation()
        {
            string validSongName = "High";
            Assert.AreEqual(validListeningNow.SongName, validSongName);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidSongNameCreation()
        {
            ListeningNow invalidListeningNow = new ListeningNow("", "Maria Becerra", "Animal");
        }

        [TestMethod]
        public void ValidArtistCreation()
        {
            string validArtist = "Maria Becerra";
            Assert.AreEqual(validListeningNow.Artist, validArtist);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidArtistCreation()
        {
            ListeningNow invalidListeningNow = new ListeningNow("High", "", "Animal");
        }

        [TestMethod]
        public void ValidAlbumNameCreation()
        {
            string validAlbumName = "Animal";
            Assert.AreEqual(validListeningNow.AlbumName, validAlbumName);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidAlbumNameCreation()
        {
            ListeningNow invalidListeningNow = new ListeningNow("High", "Maria Becerra", "");
        }
    }
}
