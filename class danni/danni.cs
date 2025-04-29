using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_danni
{
    internal class danni
    {
        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }

        }
        private decimal zaplata;
        public decimal Zaplata
        {
            get { return zaplata; }
            set { zaplata = value; }

        }
      public void Vhod()
        {
            Console.Write("ime: ");
            Ime = Console.ReadLine();
            Console.Write("zaplata: ");
            zaplata = decimal.Parse(Console.ReadLine());
        }
        public void Izhod()
        {
            Console.WriteLine($"ime: {Ime}");
            Console.WriteLine($"zaplata: {Zaplata}");
        }
    }
}
