﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Katsoja : Henkilo, Fani
    {
        public bool Kausikortti { get; set; }

        public Katsoja()
        {

        }
        public Katsoja(string nimi, double paino, bool kausikortti)
            : base(nimi, paino)
        {
            Kausikortti = kausikortti;
        }

        public override string ToString()
        {
            // Nimi + paino + Kausikortti
            return base.ToString() + Kausikortti;
        }

        public void Huutaa()
        {
            Console.WriteLine("TORILLE");
        }
    }
}
