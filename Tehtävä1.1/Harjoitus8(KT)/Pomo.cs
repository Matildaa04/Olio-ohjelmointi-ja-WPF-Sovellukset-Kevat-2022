using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus8_KT_
{
    class Pomo : Henkilö
    {
        private static int Instanssit = 0;

        public string Nimi;
        public int Ikä;

        public static int Instanssit = 0;

        public Pomo(string nimi, int ikä)
        {
            Nimi = nimi;
            Ikä = ikä;

            Instanssit++;
        }
    }
}
