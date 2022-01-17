using System;
using System.Collections.Generic;

namespace Kokoelmat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------LISTA---------");
            List<string> lista = new List<string>();
            lista.Add("Pekka");
            lista.Add("Matti");
            lista.Add("Juha");

            lista.Remove("Matti");

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------PINO---------");
            Stack<string> pino = new Stack<string>();

            pino.Push("Kortti 1");
            pino.Push("Kortti 2");
            pino.Push("Kortti 3");

            Console.WriteLine("Pinossa on " + pino.Count + " objektia");
            Console.WriteLine(pino.Peek() + " on pinon pällä");

            pino.Pop();

            Console.WriteLine("Pinossa on " + pino.Count + " objektia");
            Console.WriteLine(pino.Peek() + " on pinon pällä");
 
            Console.WriteLine("---------JONO---------");

            Queue<string> jono = new Queue<string>();

            jono.Enqueue("Matti");
            jono.Enqueue("Pekka");
            jono.Enqueue("Juha");

            Console.WriteLine("Jonossa on " + jono.Count + " henkilöä");
            Console.WriteLine(jono.Peek() + " on ensimmäinen jonossa");

            jono.Dequeue();

            Console.WriteLine("Jonossa on " + jono.Count + " henkilöä");
            Console.WriteLine(jono.Peek() + " on ensimmäinen jonossa");

            Console.WriteLine("---------SANAKIRJA---------");

            Dictionary<string, string> sanakirja = new Dictionary<string, string>();
            sanakirja.Add("151219-6012", "Matti");
            sanakirja.Add("050616-5124", "Pekka");

            Console.WriteLine("Sanakirjassa on " + sanakirja.Count + " henkilöä");

            Console.WriteLine("Etsitään sanakirjasta avaimella '151219-6012', haettu henkilö on " + sanakirja["151219-6012"]);

            foreach(string avain in sanakirja.Keys)
            {
                Console.WriteLine("Sanakirjasta haettu avaimella: " + avain + ".Value: " + sanakirja[avain]);
            }

            foreach (string henkilö in sanakirja.Values)
            {
                Console.WriteLine("Sanakirjasta haettu valuella: " + henkilö);
            }

            Console.WriteLine("Etsitään sanakirjasta avaimella '151219-5012', haettu henkilö on " + sanakirja["151219-6012"]);
            sanakirja.Add("151219-6012", "Juha");
        }
    }
}
