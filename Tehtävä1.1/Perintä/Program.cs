using System;

namespace Perintä
{
    class Program
    {
        static void Main(string[] args)
        {


            Henkilö henkilö = new Henkilö("Matti", 20, 1042104);
            Opiskelija opiskelija = new Opiskelija("Pekka", 18, 2155821, 12345, "Careeria");

            Henkilö.KuinkaMontaHenkilöä();
            Opiskelija.KuinkaMontaOpiskelijaa();

            henkilö.TulostaTiedot();
            opiskelija.TulostaTiedot();

            henkilö.Syö();
            henkilö.Juo();
            opiskelija.Syö();
            opiskelija.Juo();
            opiskelija.Opiskele();

        }
    }
}
