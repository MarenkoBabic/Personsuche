
namespace PersonenSuchen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    enum Haarfarbe { Rot, Blau, Grün, Blond, Schwarz, Braun }

    class Program
    {
        static void Main( string[] args )
        {
            RandomName Name = new RandomName();
            List<RandomName> list = new List<RandomName>();
            Console.WriteLine( "Guten Tag" );
            Console.WriteLine( "Wieviele Personen Personen wollen sie erstellen" );
            bool eingabe = int.TryParse( Console.ReadLine(), out int result );
            for( int i = 0; i < result; i++ )
            {
                Name.FirstName();
                Name.Lastname();
                Name.Date();
                list.Add( Name );
            }
            foreach( var item in list )
            {
                Console.WriteLine( item );
            }
            Console.WriteLine();
            Console.WriteLine( "Person suchen" );
            string personenSuche = Console.ReadLine();

            var findPerson = list.Where( x =>  x.FirstName);


            Console.WriteLine(personenSuche);
            Console.ReadLine();
        }

    }
}
