using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonenSuchen;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        RandomName rn = new RandomName();
        
        [TestMethod]
        public void PersonenSuchen_ListIsNotNull()
        {
            //arrange
            string anzahl = "10000000000000000000";

            //act
            rn.PersonGenerator( anzahl );

            //assert
            Assert.IsNotNull( rn.PersonList );
        }
        [TestMethod]
        public void PersonenSuchen_AnzahlIsNull()
        {
            //arrange
            string anzahl = null;

            //act
            rn.PersonGenerator( anzahl );

            //assert
            Assert.IsNull( anzahl );
        }

        [TestMethod]
        public void PersonenSuchen_()
        {
            //arrange
            string anzahl = null;
            
            //act
            rn.PersonGenerator( anzahl );

            //assert
            Assert.IsNull( anzahl );
        }

    }
}
