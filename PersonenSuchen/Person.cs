using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonenSuchen
{
    enum HairColor { rot, blau, grün, weiß, blond, braun, schwarz }
    public class Person
    {
        public List<Person> ListPerson { get; set; }
        Array getColor = Enum.GetValues( typeof( HairColor ) );
        Random rnd = new Random();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Date { get; set; }
        public Enum Color { get; set; }
        public Person()
        {
            ListPerson = new List<Person>();
        }

        public void GenerateRandomData( int anzahl )
        {
            for( int i = 0; i < anzahl; i++ )
            {
                Person p = new Person();
                p.FirstName = firstNameList.OrderBy( x => rnd.Next() ).First();
                p.LastName = lastNameList.OrderBy( x => rnd.Next() ).First();
                p.Date = DateTime.Today.AddDays( -rnd.Next( 10 * 365 ) );
                p.Color = (HairColor)getColor.GetValue( rnd.Next( getColor.Length ) );
                ListPerson.Add( p );
            }
        }

        private List<string> firstNameList = new List<string>() { "Josef", "Sepp", "Hans", "Andi", "Peter", "Robert", "Marenko", "Patrick", "Thomas" };
        private List<string> lastNameList = new List<string>() { "Prethaler", "Pichler", "Eiweck", "Wolfrath", "Ratzenböck", "Babic", "Grewe", "Gajar" };

    }
}
