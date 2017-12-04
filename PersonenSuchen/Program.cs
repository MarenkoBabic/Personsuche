
namespace PersonenSuchen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;

    class Program
    {
        static void Main( string[] args )
        {
            Console.WriteLine( "Wieviele Personen wollen sie generierenlassen" );
            bool result = int.TryParse( Console.ReadLine(), out int anzahl );
            Person person = new Person();
            person.GenerateRandomData( anzahl );

            foreach( Person item in person.ListPerson )
            {
                Console.WriteLine( item.FirstName + " " + item.LastName + " " + item.Date.ToString("d") + " " + item.Color );
            }
            Console.ReadLine();
            string auswahl;
            do
            {
                Console.WriteLine( "Person suchen nach:" );
                Console.WriteLine( "1 Vorname,2 Nachname,3 Datum,4 Haarfarbe" );
                auswahl = Console.ReadLine();

                if( auswahl == "1" )
                {
                    Console.WriteLine( "Vorname eingeben:" );
                    string searchName = Console.ReadLine();
                    IEnumerable<Person> firstName = person.ListPerson.Where( x => x.FirstName == searchName );
                    foreach( Person item in firstName )
                    {
                        Console.WriteLine( item.FirstName + " " + item.LastName + " " + item.Date.ToString( "d" ) + " " + item.Color );
                    }
                }
                else if( auswahl == "2" )
                {
                    Console.WriteLine( "Nachname eingeben:" );
                    string searchName = Console.ReadLine();
                    IEnumerable<Person> lastName = person.ListPerson.Where( x => x.LastName == searchName );
                    foreach( Person item in lastName )
                    {
                        Console.WriteLine( item.FirstName + " " + item.LastName + " " + item.Date.ToString( "d" ) + " " + item.Color );
                    }
                }
                else if( auswahl == "3" )
                {
                    Console.WriteLine( "Datum eingeben:" );
                    string searchDate = Console.ReadLine();
                    IEnumerable<Person> date = person.ListPerson.Where( x => x.Date.ToString("d").Replace("/","") == searchDate );
                    foreach( Person item in date )
                    {
                        Console.WriteLine( item.FirstName + " " + item.LastName + " " + item.Date + " " + item.Color );
                    }
                }
                else if( auswahl == "4" )
                {
                    Console.WriteLine( "Haarfarbe eingeben:" );
                    string haarfarbe = Console.ReadLine();
                    IEnumerable<Person> hairColor = person.ListPerson.Where( x => x.Color.ToString() == haarfarbe );
                    foreach( Person item in hairColor )
                    {
                        Console.WriteLine( item.FirstName + " " + item.LastName + " " + item.Date.ToString("d") + " " + item.Color );
                    }
                }
                else
                {
                    Console.WriteLine("Falsche eingabe");
                }
            } while(!string.IsNullOrWhiteSpace(auswahl));
        }
    }
}