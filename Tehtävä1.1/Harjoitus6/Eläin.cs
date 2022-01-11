using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6
{
    class Eläin
    {
        private static int Instanssit = 0;

        public Eläin()
        {
            Instanssit++;
        }

        public static void KuinkaMonta()
        {
            Console.WriteLine("Eläimiä on elossa: " + Instanssit);

        }

        public abstract void Ääntele();
    }
}
