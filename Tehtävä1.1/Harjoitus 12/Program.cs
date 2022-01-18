using System;
using System.Collections.Generic;

namespace Harjoitus_12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> pakka = new List<string>();



            for (int i = 0; i < 13; i++)
            {
                pakka.Add("Pata - " + (i + 1));
                pakka.Add("Hertta - " + (i + 1));
                pakka.Add("Risti - " + (i + 1));
                pakka.Add("Ruutu - " + (i + 1));
            }


            foreach (string kortti in pakka)
            {
                Console.WriteLine(kortti);
            }
        }

        private static Random r = new Random();
        static void Shuffle<T>(List<T> pakka)
        {
            for (int i = 0; i < pakka.Count; i++)
            {
                int idx = r.Next(i, pakka.Count);
                T temp = pakka[idx];
                pakka[idx] = pakka[i];
                pakka[i] = temp;
            }
        }
    }
}

