using System;

namespace Harjoitus3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiuas harvia = new Kiuas("Kiuas", 90, 50); //Luodaan uusi kiuas
            
            harvia.NäytäTiedot(); //Tällä tulostetaan kiukaan tiedot
            harvia.Tila = true; //Kiuas menee päälle
            harvia.NäytäTiedot();
            harvia.SäädäLämpötila(100); //Säädetään lämpötilaa
            harvia.SäädäLämpötila(60); //Säädetään kosteutta
            harvia.NäytäTiedot();

        }
    }
}
