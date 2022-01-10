using System;

namespace Ajoneuvoharjoitus
{
    class Program
    {
        static void Main(string[] args)
        {
            Ajoneuvo auto = new Ajoneuvo();
            auto.Nimi = "Toyota Corolla";
            auto.Nopeus = 420;
            auto.Renkaat = 4;

            auto.TulostaData();

            Ajoneuvo vene = new Ajoneuvo();
            vene.Nimi = "Buster";
            vene.Nopeus = 100;
            vene.Renkaat = 0;

            vene.TulostaData();

        }
    }
}
