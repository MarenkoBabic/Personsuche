using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonenSuchen
{
    class RandomName
    {
        Random rnd = new Random();
        public DateTime Date()
        {
            int year = rnd.Next( 1990, 2017 );
            int month = rnd.Next( 1, 12 );
            int day = DateTime.DaysInMonth( year, month );
            int Day = rnd.Next( 1, day );

            DateTime dt = new DateTime( year, month, Day );
            return dt;
        }
        public String FirstName()
        {
            string firstName = firstNameList.OrderBy(a => rnd.NextDouble() ).First();
            return firstName;
        }
        public String Lastname()
        {
            string lastName = lastNameList.OrderBy( a => rnd.NextDouble() ).First();
            return lastName;
        }
        

        private List<string> firstNameList = new List<string>()
        { "Josef", "Sepp", "Hans", "Andi", "Peter", "Robert", "Marenko", "Patrick", "Thomas", "Stefan", "Patricia", "Michi", "Markus", "Steven" };
        private List<string> lastNameList = new List<string>()
        { "Prethaler", "Pichler", "Eiweck", "Wolfrath", "Ratzenböck", "Babic", "Grewe", "Gajar", "Bintinger", "Doe" };
    }
}
