using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus13
{
    class Pelaaja
    {
        public string Etunimi;
        public string Sukunimi;
        public int PelaajaNumero;

        public void TulostaTiedot()
        {
            Console.WriteLine("Pelaaja: {0} {1}. Pelaajanumero: {2}", Etunimi, Sukunimi, PelaajaNumero);
        }
    }
}
