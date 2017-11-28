﻿
namespace PersonenSuchen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;


    class Program
    {
        static void Main( string[] args )
        {
            string searchPerson;
            Console.WriteLine( "Wieviele Personen Personen wollen sie erstellen" );
            bool eingabe = int.TryParse( Console.ReadLine(), out int result );
            RandomName rn = new RandomName();
            // Springt in die Methode mit eingabe als int 
            rn.PersonGenerator( result );

            // Läuft die Abfrage solange durch bis er kein leerzeichen eingibt
            do
            {
                Console.ResetColor();

                // Läuft die Liste durch mit den erzeugen Personen und zeigt sie an 
                foreach( String item in rn.PersonList )
                {

                    Console.WriteLine( item );
                }
                Console.WriteLine( "\n\n" );
                Console.WriteLine("Welche Person woll sie finden" );
                searchPerson = Console.ReadLine();

                //Läuft die Liste durch und sucht sich die Personen raus welche mit den gesuchten Namen Starten 
                foreach( String item in rn.PersonList.Where( x => x.StartsWith( searchPerson ) ) )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                        
                    Console.WriteLine( item );
                }
                Console.ReadLine();
                Console.WriteLine("\n\n");
            } while( !string.IsNullOrWhiteSpace( searchPerson ) );
        }
    }
}