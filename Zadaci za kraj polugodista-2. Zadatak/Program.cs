using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaci_za_kraj_polugodista_2.Zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            //Napišite program koji će zatražiti od korisnika da unese broj te će u ovisnosti o unesenom broju ispisati jednu od sljedeće 4 poruke:

            int broj = 0;

            Console.WriteLine("Unesite broj:");
           broj = Convert.ToInt32(Console.ReadLine());

            if (broj%4== 0 && broj%6 != 0) {
                Console.WriteLine("Broj je djeljiv s 4");
            }

            if (broj%6==0 && broj%4 != 0)
            {
                Console.WriteLine("Broj je djeljiv s 6");
            }

            if (broj%4==0 && broj%6==0)
            {
                Console.WriteLine("Broj je djeljiv s 4 i sa 6");
            }

            if (broj % 4!= 0 && broj % 6!= 0)
            {
                Console.WriteLine("Broj nije djeljiv s 4 i sa 6");
            }

            
            Console.ReadLine();



        }
    }
}
