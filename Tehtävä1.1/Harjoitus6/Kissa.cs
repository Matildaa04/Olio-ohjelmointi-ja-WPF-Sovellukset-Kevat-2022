using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6
{
    class Kissa : Eläin
    {
        public string Väri;
        public int Ikä;

        public static int Instanssit = 0;

        public Kissa(string väri, int ikä)
        {
            Väri = väri;
            Ikä = ikä;

            Instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Kissoja on elossa: " + Instanssit);
        }

        public override void Ääntele()
        {
            Console.WriteLine("Miau");
        }
    }
}
