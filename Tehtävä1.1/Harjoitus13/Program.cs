using System;
using System.Collections.Generic;

namespace Harjoitus13
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Pelaaja> pelaajat = new Dictionary<int, Pelaaja>();
            string syöte;

            syöte = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("1. lisää pelaaja ");
                Console.WriteLine("2. poista pelaaja ");
                Console.WriteLine("3. tulosta ");
                Console.WriteLine("4. poistu ");

                syöte = Console.ReadLine();

                switch (syöte)
                {
                    case "lisää":
                        LisääPelaaja(pelaajat);
                        break;
                    case "poista":
                        PoistaPelaaja(pelaajat);
                        break;
                    case " tulosta:":
                        TulostaPelaaja(pelaajat);
                        break;
                    case "poistu":
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
