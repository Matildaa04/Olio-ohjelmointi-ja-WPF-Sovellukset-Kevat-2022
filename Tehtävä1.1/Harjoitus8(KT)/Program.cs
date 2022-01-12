using System;

namespace Harjoitus8_KT_
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö pomo = new Pomo("Pekka",40,"Audi",2000);
            Henkilö työntekijä = new Työntekijä("Ville",25,38);

            Console.WriteLine("----------------------");
            Console.WriteLine("Pomo");
            Console.WriteLine("----------------------");
            Pomo.TulostaTiedot();
            Pomo.KuinkaMontaPomoa();
           
            Console.WriteLine("----------------------");
            Console.WriteLine("Työntekijä");
            Console.WriteLine("----------------------");
            Työntekijä.TulostaTiedot();
        }
    }
}
