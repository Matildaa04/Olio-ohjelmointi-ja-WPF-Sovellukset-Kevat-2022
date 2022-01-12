using System;

namespace Harjoitus9
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio(88, 107);
            Ääni ääni = new Ääni(0, 9);
            string syöte;
            string voimakkuus;

            Console.WriteLine("Radio päällä. Sulkeaksesi radion, kirjoita Sulje");


            while (true)
            {
                Console.WriteLine("Olet radiokanavalla " + radio.NykyinenKanava + ". Valitse kanava 88-107 välillä.");
                Console.WriteLine("Mille kanavalle haluat siirtyä?");
                syöte = Console.ReadLine();


                if (syöte == "Sulje")
                {
                    Console.WriteLine("Radio suljettu");
                    break;
                }
                else
                {
                    radio.NykyinenKanava = int.Parse(syöte);
                }

                Console.WriteLine("Äänenvoimakkuus on " + ääni.NykyinenVoimakkuus);
                Console.WriteLine("Voimakkuutta voit vaihtaa välillä 1-9: ");
                voimakkuus = Console.ReadLine();

                if (voimakkuus == "Sulje")
                {
                    Console.WriteLine("Radio suljettu");
                    break;
                }
                else
                {
                    ääni.NykyinenVoimakkuus = int.Parse(voimakkuus);
                }
            }


        }
    }
}