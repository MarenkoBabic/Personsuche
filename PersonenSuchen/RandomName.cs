using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonenSuchen
{
    public class RandomName
    {
        #region property
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public List<string> PersonList { get; set; }
        #endregion

        public RandomName()
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this.date = Date;
            PersonList = new List<string>();
        }
        public void PersonGenerator( int anzahl)
        {
            List<string> firstNameList = new List<string>() { "Josef", "Sepp", "Hans", "Andi", "Peter", "Robert", "Marenko", "Patrick", "Thomas" };
            List<string> lastNameList = new List<string>() { "Prethaler", "Pichler", "Eiweck", "Wolfrath", "Ratzenböck", "Babic", "Grewe", "Gajar" };
            Random rnd = new Random();

            for( int i = 0; i < anzahl; i++ )
            {
                FirstName = firstNameList.OrderBy( x => rnd.Next() ).First();
                LastName = lastNameList.OrderBy( x => rnd.Next() ).First();
                Date = RandomDate();
                string Person = FirstName + " " + LastName + " " + Date.ToString( "dd.MM.yyyy" );
                PersonList.Add(Person);
            }
        }




        DateTime RandomDate()
        {
            Random rnd = new Random();
            int year = rnd.Next( 1990, 2017 );
            int month = rnd.Next( 1, 12 );
            int day = DateTime.DaysInMonth( year, month );
            int Day = rnd.Next( 1, day );
            DateTime dt = new DateTime( year, month, Day );
            return dt;
        }


        private DateTime date;
        private string lastName;
        private string firstName;

    }
}