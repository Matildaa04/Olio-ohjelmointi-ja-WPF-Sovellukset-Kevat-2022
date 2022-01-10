using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus3
{
    class Kiuas
    {
        private string Nimi;
        private int Lämpötila;
        private int Kosteus;
        public bool Tila = false;

        public Kiuas(string nimi, int lämpötila, int kosteus)
        {
            Nimi = nimi;
            Lämpötila = lämpötila;
            Kosteus = kosteus;
        }

        public void NäytäTiedot()
        {
            if (Tila)
            {
                Console.WriteLine("Kiuas " + Nimi + " on päällä");
                Console.WriteLine("Lämpötila = " + Lämpötila);
                Console.WriteLine("Kosteus = " + Kosteus);
            }
            else
            {
                Console.WriteLine("Kiuas " + Nimi + " ei ole päällä");
            }

            
        }
        public void SäädäLämpötila(int uusiLämpötila)
        {
            Lämpötila = uusiLämpötila;
        }

        public void SäädäKosteutta(int uusiKosteus)
        {
            Kosteus = uusiKosteus;
        }
    }
}
