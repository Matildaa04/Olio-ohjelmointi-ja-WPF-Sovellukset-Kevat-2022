using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus4
{
    class Albumi
    {


        private List<Kappale> kappaleet = new List<Kappale>();

        public void LisääKappale(Kappale uusiKappale)
        {
            kappaleet.Add(uusiKappale);
        }

        // Tulostaa albumissa olevat kappaleet
        public void TulostaKappaleet()
        {
            
            foreach (Kappale kappale in kappaleet)
            {
                Console.WriteLine(kappale.Nimi + ", " + kappale.Pituus);
            }
        }

        public string Artisti;
        public string Nimi;
        public string Genre;
        public int Hinta;

        public Albumi(string artisti, string nimi, string genre, int hinta)
        {
            Artisti = artisti;
            Nimi = nimi;
            Genre = genre;
            Hinta = hinta;
        }

        public void TulostaAlbumi()
        {
            Console.WriteLine("Artisti: " + Artisti);
            Console.WriteLine("Albumin nimi: " + Nimi);
            Console.WriteLine("Genre: " + Genre);
            Console.WriteLine("Hinta: " + Hinta);
        }

    }
}