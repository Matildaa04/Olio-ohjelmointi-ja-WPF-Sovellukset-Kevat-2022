using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus3
{
    class Kiuas
    {
        //Kiukaan ominaisuudet
        private string Nimi;
        private int Lämpötila;
        private int Kosteus;

        public bool Tila = false; //Määrittää, onko kiuas päällä vai pois päältä

        //Konstruktori kiukaalle
        public Kiuas(string nimi, int lämpötila, int kosteus)
        {
            Nimi = nimi;
            Lämpötila = lämpötila;
            Kosteus = kosteus;
        }

        public void NäytäTiedot()
        {
            if (Tila) //Jos kiuas on päällä, tulostetaan if lauseen sisältö
            {
                Console.WriteLine("Kiuas " + Nimi + " on päällä");
                Console.WriteLine("Lämpötila = " + Lämpötila);
                Console.WriteLine("Kosteus = " + Kosteus);
            }
            else //Jos kiuas ei ole päällä, tulostetaan else lauseen sisältö
            {
                Console.WriteLine("Kiuas " + Nimi + " ei ole päällä");
            }

            
        }
        public void SäädäLämpötila(int uusiLämpötila) //Muutetaan lämpötilaa
        {
            Lämpötila = uusiLämpötila;
        }

        public void SäädäKosteutta(int uusiKosteus) //Muutetaan kiukaan kosteutta
        {
            Kosteus = uusiKosteus;
        }
    }
}
