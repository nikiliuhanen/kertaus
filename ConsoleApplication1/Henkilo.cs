using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Henkilo
    {
        public string Nimi { get; set; }
        private double paino; // 0 - 100 kg kapselointi
        public double Paino
        {
            get
            {
                return paino;
            }
            set
            {
                if (value >= 0 && value <= 100) paino = value;
                else
                {
                    Console.WriteLine("Pelaajan paino ei ole sallittu");
                   
                }
            }
        }
        // constructor
        public Henkilo()
        {
        }
        // parametric constructor
        public Henkilo(string nimi, double paino)
        {
            Nimi = nimi;
            Paino = paino;
        }
        public override string ToString()
        {
            return Nimi + " " + paino;
        }
    }
}
