using System;
using System.Collections.Generic;

namespace Harjoitus13
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Pelaaja> pelaajat = new Dictionary<int, Pelaaja>();
            string syöte;

            while (true)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("Mitä haluat tehdä?");
                Console.WriteLine("1. lisää - Lisää pelaajan listaan");
                Console.WriteLine("2. poista - poistaa pelaajan listasta");
                Console.WriteLine("3. hae - hakee pelaaja kokoelman");

                syöte = Console.ReadLine();

                switch (syöte)
                {
                    case "lisää":
                        LisääPelaaja(pelaajat);
                        break;
                    case "poista":
                        PoistaPelaaja(pelaajat);
                        break;
                    case " tulosta:":
                        HaePelaaja(pelaajat);
                        break;
                    default:
                        break;
                }
            }
        }

        static void LisääPelaaja(Dictionary<int, Pelaaja> pelaajat)
        {
            Pelaaja uusiPelaaja = new Pelaaja();

            while (true)
            {
                Console.WriteLine("Anna uudelle pelaajalle tiedot: ");
                Console.WriteLine("Etunimi: ");
                uusiPelaaja.Etunimi = Console.ReadLine();
                Console.WriteLine("Sukunimi: ");
                uusiPelaaja.Sukunimi = Console.ReadLine();
                Console.WriteLine("Pelaajanumero: ");
                uusiPelaaja.PelaajaNumero = Convert.ToInt32(Console.ReadLine());


                if (pelaajat.ContainsKey(uusiPelaaja.PelaajaNumero))
                {
                    Console.WriteLine("Pelaaja sanastossa on pelaaja samalla pelaajanumerolla");
                    continue;
                }
                else
                {
                    pelaajat.Add(uusiPelaaja.PelaajaNumero, uusiPelaaja);
                    break;
                }
            }
        }

        static void PoistaPelaaja(Dictionary<int, Pelaaja> pelaajat)
        {
            Console.WriteLine("Anna pelaajan pelaajanumero, jonka haluat poistaa: ");
            int syöte = Convert.ToInt32(Console.ReadLine());

            if (pelaajat.ContainsKey(syöte))
            {
                Console.WriteLine("Pelaaja " + pelaajat[syöte].Etunimi + " poistettu");
            }
            else
            {
                Console.WriteLine("Pelaajaa pelaajanumerolla " + syöte + " ei löydetty kokoelmasta");
            }

            pelaajat.Remove(syöte);
        }

        static void HaePelaaja(Dictionary<int, Pelaaja> pelaajat)
        {
            foreach (Pelaaja item in pelaajat.Values)
            {
                item.TulostaTiedot();
            }
        }
    }
}
