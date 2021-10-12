using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;

namespace SocialNetwotkTest
{
    [TestClass]
    public class DirectionTests
    {


        [TestMethod]
        public void CreateDirectionValid()
        {
            Direction validDirection = new Direction ("Uruguay", "La Comercial", "Cufre 1981");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateDirectionWhitEmptyCountry()
        {
            Direction validDirection = new Direction("", "La Comercial", "Cufre 1981");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateDirectionWhitEmptyCity()
        {
            Direction validDirection = new Direction("Uruguay", "", "Cufre 1981");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateDirectionWhitEmptyStreet()
        {
            Direction validDirection = new Direction("Uruguay", "La Comercial", "");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateDirectionWhitNullCountry()
        {
            Direction validDirection = new Direction(null, "La Comercial", "Cufre 1981");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateDirectionWhitNullCity()
        {
            Direction validDirection = new Direction("Uruguay", null, "Cufre 1981");
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CreateDirectionWhitNullStreet()
        {
            Direction validDirection = new Direction("Uruguay", "La Comercial", null);
        }

    }
}