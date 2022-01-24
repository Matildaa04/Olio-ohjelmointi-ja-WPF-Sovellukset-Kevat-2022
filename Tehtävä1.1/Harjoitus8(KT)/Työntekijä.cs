using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus8_KT_
{
    class Työntekijä : Henkilö //Tämä luokka on henkilö-luokan aliluokka
    {
        public override string Nimi { get; set; }
        public static string Tunnus;
        public static int Ikä;
        public static int Työtunnit;


        public Työntekijä(string nimi, int ikä, int työtunnit)
        {
            Tunnus = nimi;
            Ikä = ikä;
            Työtunnit = työtunnit;

        }

        public static void TulostaTiedot()
        {
            Console.WriteLine("Nimi: " + Tunnus);
            Console.WriteLine("Ikä: " + Ikä);
            Console.WriteLine("Työtunnit viikossa: " + Työtunnit);
        }

    }
}
