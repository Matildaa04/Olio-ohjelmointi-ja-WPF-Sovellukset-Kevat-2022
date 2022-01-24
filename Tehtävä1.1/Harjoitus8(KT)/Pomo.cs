using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus8_KT_
{
    class Pomo : Henkilö //Tämä on henkilö-luokan aliluokka
    {
        public override string Nimi { get; set; }
        public static string Tunnus;
        public static int Ikä;
        public static string Auto;
        public static int Bonus;

        public static int Instanssit = 0;

        //Konstruktori pomolle
        public Pomo(string nimi, int ikä, string auto, int bonus)
        {
            Tunnus = nimi;
            Ikä = ikä;
            Auto = auto;
            Bonus = bonus;

            Instanssit++;
        }

        public static void KuinkaMontaPomoa() //Tarkistetaan, montako pomoa on olemassa kaikista henkilöistä
        {
            Console.WriteLine("Pomoja on olemassa: " + Instanssit);

        }

        public static void TulostaTiedot()
        {
            Console.WriteLine("Nimi: " + Tunnus);
            Console.WriteLine("Ikä: " + Ikä);
            Console.WriteLine("Ajaa autoa: " + Auto);
            Console.WriteLine("Bonuksen määrä: " + Bonus);
        }
    }
}
