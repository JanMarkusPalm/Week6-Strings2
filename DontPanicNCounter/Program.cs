using System;

namespace DontPanicNCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm  kuvab mitu 'n' tähte on
            //lauses "dont panic"

            string dontpanic = ("Don't Panic").ToUpper();

            int counter = 0;

            foreach (char character in dontpanic)
            {
                if (character == 'N')
                {
                    counter++;
                }
            }
            Console.WriteLine($"{dontpanic}s on {counter} N tähte.");
           

        }
    }
}
