using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konstruktoren_broqch
{
    internal class danni_konstruktor
    {
        public string Ime { get; set; }
        public decimal Zaplata { get; set; }
        public danni_konstruktor(string ime, decimal zaplata)
        {
            Ime = ime;
            Zaplata = zaplata;
        }
    }
}
