using System;

namespace Harjoitus8_KT_
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö pomo = new Pomo("Pekka",40,"Audi",2000); //uusi pomo
            Henkilö työntekijä = new Työntekijä("Ville",25,38); //uusi työntekijä

            Console.WriteLine("----------------------");
            Console.WriteLine("Pomo");
            Console.WriteLine("----------------------");
            Pomo.TulostaTiedot(); //Tulostaa pomon tiedot
            Pomo.KuinkaMontaPomoa(); //Kertoo montako pomoa on olemassa
           
            Console.WriteLine("----------------------");
            Console.WriteLine("Työntekijä");
            Console.WriteLine("----------------------");
            Työntekijä.TulostaTiedot(); //Tulostaa työntekijän tiedot
        }
    }
}
