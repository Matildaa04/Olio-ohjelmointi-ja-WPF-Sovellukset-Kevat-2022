﻿using System;

namespace Harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            Koira.KuinkaMonta();
            Kissa.KuinkaMonta();
            Eläin.KuinkaMonta();

            Koira koira1 = new Koira("Mopsi", 4);
            Koira koira2 = new Koira("Saksanpaimenkoira", 6);
            Kissa kissa1 = new Kissa("Oranssi", 2);
            Kissa kissa2 = new Kissa("Musta", 5);

            kissa1.Ääntele();
            koira1.Ääntele();

            Eläin.KuinkaMonta();
            Kissa.KuinkaMonta();
            Eläin.KuinkaMonta();

            koira2.Ääntele();
            kissa2.Ääntele();

        }
    }
}
