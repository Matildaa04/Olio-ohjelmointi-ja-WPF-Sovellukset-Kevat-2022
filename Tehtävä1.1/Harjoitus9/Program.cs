using System;

namespace Harjoitus9
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio(88, 107); //Min ja max radiokanavat
            Ääni ääni = new Ääni(0, 9); //Min ja max äänenvoimakkuus
            string syöte;
            string voimakkuus;

            Console.WriteLine("Radio päällä. Sulkeaksesi radion, kirjoita Sulje");


            while (true)
            {
                Console.WriteLine("Olet radiokanavalla " + radio.NykyinenKanava + ". Valitse kanava 88-107 välillä."); //Kertoo millä kanavalla olet, jonka jälkeen kysyy mille kanavalle haluat vaihtaa
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

                Console.WriteLine("Äänenvoimakkuus on " + ääni.NykyinenVoimakkuus); //Kertoo äänenvoimakkuuden
                Console.WriteLine("Voimakkuutta voit vaihtaa välillä 1-9: ");
                voimakkuus = Console.ReadLine();

                if (voimakkuus == "Sulje")
                {
                    Console.WriteLine("Radio suljettu"); //sulkee radion jos käyttäjä laittaa syötteeksi Sulje
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