using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilo henkilo = new Henkilo();
            henkilo.Nimi = "Jaakko Teppo";
            henkilo.Paino = 80;
            Console.WriteLine("Henkilön nimi : " + henkilo.Nimi);
            Console.WriteLine("Henkilön paino : " + henkilo.Paino);

            string nimi = "Kirsi Kernel";
            double paino = 50;

            Henkilo henkilo2 = new Henkilo(nimi, paino);
            Console.WriteLine("Henkilön nimi : " + henkilo2.Nimi);
            Console.WriteLine("Henkilön paino : " + henkilo2.Paino);

            Henkilo henkilo3 = new Henkilo { Nimi = "Kalle", Paino = 23 };

            Katsoja katsoja = new Katsoja("Pekka Pouta", 75 , true);
            Console.WriteLine(katsoja.ToString());
            katsoja.Huutaa();
            
        }
    }
}
