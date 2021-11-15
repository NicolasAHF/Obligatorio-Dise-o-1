using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SocialNetwork;
using System.Collections.Generic;
using System.Linq;

namespace SocialNetworkTest
{
    [TestClass]
    public class StatusTests
    {
       


          [TestInitialize]
    public void Setup()
        {

        }

        [TestCleanup]
        public void Cleanup()
        {
            
        }

       
        [TestMethod]
        public void ValidSetStatus()
        {
            Status elStatus = new Status("Día lluvioso hermoso para programar");
        }

        [TestMethod]
        public void ValiLongMinSetStatus()
        {

            string status = "a";
            for (int i = 0; i < 9; i++)
            {
                status += "a";
            }
            Status elStatus = new Status(status);
        }

        [TestMethod]
        public void ValidLongMaxSetStatus()
        {
            string status = "a";
            for (int i = 0; i < 159; i++)
            {
                status += "a";
            }
            Status elStatus = new Status(status);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidLongMinSetStatus()
        {

            string status = "a";
            for (int i = 0; i < 8; i++)
            {
                status += "a";
            }
            Status elStatus = new Status(status);
        }
    
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void InvalidLongMaxSetStatus()
        {
          
            string status = "a";
            for (int i = 0; i < 160; i++)
            {
                status += "a";                
            }
            Status elStatus = new Status(status);
        }

    }
}
