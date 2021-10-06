using System;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada eesnimi ja perekonnanimi
            //programm tervitab kasutajat kasutades tema initsiaale
            //initsiaalid lõppevad punktiga
            Console.WriteLine("Palun sisestage oma eesnimi");
            string NIMI1 = Console.ReadLine().ToUpper();
            Console.WriteLine("Palun sisestage oma perekonna nimi");
            string NIMI2 = Console.ReadLine().ToUpper();

            Console.WriteLine($"Tere, {NIMI1[0]}. {NIMI2[0]}.!");
                                     //kohal 0 on esimene täht sisestatud
        }
    }
}
