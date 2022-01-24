using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus9
{
    class Radio
    {
        //ominaisuudet
        private int minKanava;
        private int maxKanava;

        private int nykyinenKanava;

        //Konstruktori
        public Radio(int minKanava, int maxKanava)
        {
            this.minKanava = minKanava;
            this.maxKanava = maxKanava;

            NykyinenKanava = minKanava;
        }

        public int NykyinenKanava
        {
            get => nykyinenKanava;
            set
            {
                if (value > maxKanava || value < minKanava) //Tulostaa if lauseen, jos käyttäjä syöttää virheellisen kanavan
                {
                    Console.WriteLine("Virheellinen kanava! Jäädään kanavalle " + nykyinenKanava);
                }
                else
                {
                    nykyinenKanava = value;
                }
            }
        }
    }
}
