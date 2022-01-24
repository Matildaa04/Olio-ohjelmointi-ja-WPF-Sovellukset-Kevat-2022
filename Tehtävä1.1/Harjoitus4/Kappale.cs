using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus4
{
    class Kappale
    {
        //Ominaisuudet
        public string Nimi;
        public string Pituus;

        //Konstruktori kappaleille
        public Kappale(string _nimi, string _pituus)
        {
            Nimi = _nimi;
            Pituus = _pituus;
        }
    }
}
