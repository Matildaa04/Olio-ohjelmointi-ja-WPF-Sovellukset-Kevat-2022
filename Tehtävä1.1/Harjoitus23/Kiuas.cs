using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus23
{
    class Kiuas
    {
        public int Lämpötila { get; set; }
        public int Kosteus { get; set; }
        public bool OnkoPäällä { get; set; }

        public void VaihdaLämpötila(int uusiLämpötila)
        {
            Lämpötila = uusiLämpötila;

            if (Lämpötila > 120)
                Lämpötila = 120;

            if (Lämpötila < 10)
                Lämpötila = 10;
        }
        public void VaihdaKosteutta(int uusiKosteus)
        {
            Kosteus = uusiKosteus;

            if (Lämpötila > 100)
                Lämpötila = 100;

            if (Lämpötila < 0)
                Lämpötila = 0;
        }
    }
}
