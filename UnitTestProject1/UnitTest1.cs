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
        [TestMethod]
        public void PersonenSuchenAnzahl()
        {
            RandomName rn = new RandomName();
            int anzahl = 100;
            List<string> firstNameList = new List<string>() { "Josef", "Sepp", "Hans", "Andi", "Peter", "Robert", "Marenko", "Patrick", "Thomas" };
            List<string> lastNameList = new List<string>() { "Prethaler", "Pichler", "Eiweck", "Wolfrath", "Ratzenböck", "Babic", "Grewe", "Gajar" };
            Random rnd = new Random();

            for( int i = 0; i < anzahl; i++ )
            {
                string firstName = firstNameList.OrderBy( x => rnd.Next() ).First();
                string lastName = lastNameList.OrderBy( x => rnd.Next() ).First();
                DateTime date = rn.RandomDate();
                string Person = firstName + " " + lastName + " " + date.ToString( "dd.MM.yyyy" );
                rn.PersonList.Add( Person );
            }

            Assert.AreEqual( rn.PersonList.Count, anzahl );
        }

        [TestMethod]
        public void PersonSuchenAnzahlIsNull()
        {
            RandomName rn = new RandomName();
            int anzahl = 1000000000;
            List<string> firstNameList = new List<string>() { "Josef", "Sepp", "Hans", "Andi", "Peter", "Robert", "Marenko", "Patrick", "Thomas" };
            List<string> lastNameList = new List<string>() { "Prethaler", "Pichler", "Eiweck", "Wolfrath", "Ratzenböck", "Babic", "Grewe", "Gajar" };
            Random rnd = new Random();

            for( int i = 0; i < anzahl; i++ )
            {
                string firstName = firstNameList.OrderBy( x => rnd.Next() ).First();
                string lastName = lastNameList.OrderBy( x => rnd.Next() ).First();
                DateTime date = rn.RandomDate();
                string Person = firstName + " " + lastName + " " + date.ToString( "dd.MM.yyyy" );
                rn.PersonList.Add( Person );
            }

            Assert.IsNotNull(anzahl);
        }
    }
}
