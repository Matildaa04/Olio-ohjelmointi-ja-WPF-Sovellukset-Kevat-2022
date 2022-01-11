using System;

namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas harvia = new Kiuas("Kiuas", 90, 50);
            harvia.NäytäTiedot();
            harvia.Tila = true;
            harvia.NäytäTiedot();
            harvia.SäädäLämpötila(100);
            harvia.NäytäTiedot();

        }
    }
}
