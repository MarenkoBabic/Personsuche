using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonenSuchen
{
    enum Haarfarbe { rot, blau, grün, weiß }
    public class RandomName
    {
        public List<string> PersonList { get; set; }
        public RandomName()
        {
            PersonList = new List<string>();
        }
        public void PersonGenerator( int anzahl )
        {
            List<string> firstNameList = new List<string>() { "Josef", "Sepp", "Hans", "Andi", "Peter", "Robert", "Marenko", "Patrick", "Thomas" };
            List<string> lastNameList = new List<string>() { "Prethaler", "Pichler", "Eiweck", "Wolfrath", "Ratzenböck", "Babic", "Grewe", "Gajar" };
            Random rnd = new Random();
            Array Haarfarbe = Enum.GetValues( typeof( Haarfarbe ) );
            int range = 10 * 365;
            for( int i = 0; i < anzahl; i++ )
            {
                string firstName = firstNameList.OrderBy( x => rnd.Next() ).First();
                string lastName = lastNameList.OrderBy( x => rnd.Next() ).First();
                DateTime date = DateTime.Today.AddDays( -rnd.Next( range ) );
                var farbe = (Haarfarbe)Haarfarbe.GetValue( rnd.Next( Haarfarbe.Length ) );
                string Person = firstName + " " + lastName + " " + date.ToString( "dd.MM.yyyy" ) + " " + farbe;
                PersonList.Add( Person );
            }
        }
    }
}