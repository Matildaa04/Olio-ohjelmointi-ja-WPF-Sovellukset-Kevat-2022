using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus2
{
    class Opiskelija
    {
        private string Nimi;
        private string OpiskelijaID;
        private int Opintopisteet;

        public Opiskelija(string _nimi, string id, int ops)
        {
            Nimi = _nimi;
            OpiskelijaID = id;
            Opintopisteet = ops;
        }

        public void TulostaData()
        {
            Console.WriteLine(Nimi, ". ID: " + OpiskelijaID + ". Opintopisteet: " + Opintopisteet);
        }

        public void MuokkaaOpintopisteitä(int määrä)
        {
            Opintopisteet += määrä;
        }

    }
}
