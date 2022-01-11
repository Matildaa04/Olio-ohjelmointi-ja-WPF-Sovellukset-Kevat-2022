using System;

namespace Static_Esimerkki
{
    class Program
    {
        static void Main(string[] args)
        {
            float km = 154f;
            float mailit = Muuntaja.KmToMiles(km);

            Console.WriteLine(km + " kilometriä on yhtä kuin " + mailit + " mailia");

        }
    }
}
