using System;

namespace Harjoitus5
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 23;
            float b = 99;

            Console.WriteLine(Laskin.Summa(a, b));
            Console.WriteLine(Laskin.Erotus(a, b));
            Console.WriteLine(Laskin.Kertolasku(a, b));
            Console.WriteLine(Laskin.Jakolasku(a, b));
        }
    }
}
