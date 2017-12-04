using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonenSuchen
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public HairColor HairColor { get; set; }

        public Person( string firstName, string lastName, DateTime birthDay, HairColor hairColor )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDay = birthDay;
            this.HairColor = hairColor;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + BirthDay + " " + HairColor;
        }
    }
    public class PersonenVerwaltung
    {
        Array getColor = Enum.GetValues( typeof( HairColor ) );
        Random rnd = new Random();

        public List<Person> ListPerson { get; set; }

        public List<Person> GefiltertePersonen { get; set; }

        public List<Person> SucheNachHaarfarbe( HairColor hairColor )
        {
            // Suche nach Personen mit der Haarfarbe

            return null;
        }

        public Person SerachPerson( Person person )
        {
            //this.Personen ... suche ob Person vorhanden
            // return gefundene Person
            return null;
        }

        public void GenerateRandomData( int anzahl )
        {
            for( int i = 0; i < anzahl; i++ )
            {
                Person person = new Person("","",DateTime.Now,HairColor.blau);
                person.FirstName= firstNameList.OrderBy( x => rnd.Next() ).First();
                person.LastName = lastNameList.OrderBy( x => rnd.Next() ).First();
                person.BirthDay = DateTime.Today.AddDays( -rnd.Next( 10 * 365 ) );
                person.HairColor = (HairColor)getColor.GetValue( rnd.Next( getColor.Length ) );
                ListPerson.Add( person );
            }
        }

        private List<string> firstNameList = new List<string>() { "Josef", "Sepp", "Hans", "Andi", "Peter", "Robert", "Marenko", "Patrick", "Thomas" };
        private List<string> lastNameList = new List<string>() { "Prethaler", "Pichler", "Eiweck", "Wolfrath", "Ratzenböck", "Babic", "Grewe", "Gajar" };
    }
}
