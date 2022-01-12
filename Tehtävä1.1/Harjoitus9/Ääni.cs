using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus9
{
    class Ääni
    {
        private int minVoimakkuus;
        private int maxVoimakkuus;

        private int nykyinenVoimakkuus;

        public Ääni(int minVoimakkuus, int maxVoimakkuus)
        {
            this.minVoimakkuus = minVoimakkuus;
            this.maxVoimakkuus = maxVoimakkuus;

            NykyinenVoimakkuus = minVoimakkuus;
        }

        public int NykyinenVoimakkuus
        {
            get => nykyinenVoimakkuus;
            set
            {
                if (value > maxVoimakkuus || value < minVoimakkuus)
                {
                    Console.WriteLine("Virheellinen äänenvoimakkuus! Äänenvoimakkuus ei vaihtunut");
                }
                else
                {
                    nykyinenVoimakkuus = value;
                }

            }
        }
    }
}
