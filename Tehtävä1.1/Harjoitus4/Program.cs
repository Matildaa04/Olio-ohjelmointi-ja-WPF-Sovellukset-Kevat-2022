using System;

namespace Harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------"); //Lisäsin näitä writelinejä visuaalisuuden takia
            Console.WriteLine("Albumi: ");
            Console.WriteLine("-----------------------------");
            Albumi albumi = new Albumi("David Bowie","Scary Monsters","pop/rock",10); //Uusi albumi konstruktorin avulla

            albumi.TulostaAlbumi();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Biisit: ");
            Console.WriteLine("-----------------------------");
            albumi.LisääKappale(new Kappale("It's No Game", "04:16")); //Nämä kaikki ovat albumista löytyvät laulut
            albumi.LisääKappale(new Kappale("Up The Hill Backwards","03:15"));
            albumi.LisääKappale(new Kappale("Scary Monsters","05:13"));
            albumi.LisääKappale(new Kappale("Ashes to Ashes","04:25"));
            albumi.LisääKappale(new Kappale("Fashion","04:49"));
            albumi.LisääKappale(new Kappale("Teenage Wildlife","06:56"));
            albumi.LisääKappale(new Kappale("Scream Like a Baby","03:36"));
            albumi.LisääKappale(new Kappale("Kingdom Come","03:47"));
            albumi.LisääKappale(new Kappale("Because You're Young","04:55"));

            albumi.TulostaKappaleet();
        }
    }
}
