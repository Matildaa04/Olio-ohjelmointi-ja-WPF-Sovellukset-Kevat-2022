using System;
using System.Collections.Generic;

namespace Harjoitus13
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Pelaaja> pelaajat = new Dictionary<int, Pelaaja>();
        }

        static void LisääPelaaja(Dictionary<int, Pelaaja> pelaajat)
        {
            Pelaaja uusiPelaaja = new Pelaaja();


            foreach (Pelaaja item in pelaajat.Values)
            {
                item.TulostaTiedot();
            }
        }
    }
}
