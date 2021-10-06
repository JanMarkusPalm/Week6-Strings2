using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab mitu 'n', 'o' ja 'i' tähte on lauses "Hello, World!"

            string Helloworld = "Hello World";

            int counter1 = 0;
            int counter2 = 0;
            int counter3 = 0;
            foreach (char character in Helloworld)
            {
                if (character == 'h')
                {
                    counter1++;
                }
            }
            foreach (char character in Helloworld)
            {
                if (character == 'o')
                {
                    counter2++;
                }
            }
            foreach (char character in Helloworld)
            {
                if (character == 'i')
                {
                    counter3++;
                }
            }
            Console.WriteLine($"{Helloworld}s on {counter1} n tähte, {counter2} o tähte ja {counter3} i tähte,");
            
        }
    }
}
