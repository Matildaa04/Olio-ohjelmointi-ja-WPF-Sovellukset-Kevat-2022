using System;

namespace Harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {


            Albumi albumi = new Albumi();

            Console.WriteLine("songs: ");
            albumi.LisääKappale(new Kappale("Kappale 1", "06:25"));
            albumi.LisääKappale(new Kappale("Kappale 2", "02:55"));
            albumi.LisääKappale(new Kappale("Kappale 3", "05:12"));

            albumi.TulostaKappaleet();

        }
    }
}
