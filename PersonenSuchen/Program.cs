
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
            PersonenVerwaltung pVw = new PersonenVerwaltung();
            pVw.GenerateRandomData( anzahl);
            foreach( Person item in pVw.ListPerson )
            {
                Console.WriteLine( item);
            }
            Console.ReadLine();
        }
    }
}