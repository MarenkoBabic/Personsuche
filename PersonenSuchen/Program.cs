
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
            Console.WriteLine( "Guten Tag" );
            Console.WriteLine( "Wieviele Personen Personen wollen sie erstellen" );
            bool eingabe = int.TryParse( Console.ReadLine(), out int result );
            RandomName rn = new RandomName();
            rn.PersonGenerator( result );

            foreach( var item in rn.PersonList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}