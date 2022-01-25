using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus13
{
    class Joukkue : Pelaaja
    {
        List<Pelaaja> pelaajat = new List<Pelaaja>();

        public string Nimi;
        public string Kotikaupunki;


        static void LisääPelaaja(Dictionary<int, Pelaaja> pelaajat)
        {

        }

        public void PoistaPelaaja()
        {
            Console.WriteLine("Pelaaja: {0} {1}. Pelaajanumero: {2}", Etunimi, Sukunimi, PelaajaNumero);
        }

    }
}
