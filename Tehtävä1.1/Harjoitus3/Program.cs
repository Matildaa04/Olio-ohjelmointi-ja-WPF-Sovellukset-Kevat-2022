using System;

namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas kiuas = new Kiuas("Kiuas", 45, 30);
            kiuas.NäytäTiedot();
            kiuas.SäädäLämpötila(78);
            kiuas.SäädäKosteutta(55);

        }
    }
}
