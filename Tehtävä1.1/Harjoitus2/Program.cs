using System;

namespace Harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            Opiskelija opiskelija = new Opiskelija("Pekka", "12345", 0);
            opiskelija.TulostaData();
            opiskelija.MuokkaaOpintopisteitä(10);
            opiskelija.MuokkaaOpintopisteitä(15);
            opiskelija.TulostaData();
        }
    }
}
