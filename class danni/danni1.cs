using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_danni
{
    internal class danni1
    {
        private string ime;
        public string Ime { get; set; }
        private decimal zaplata;
        public decimal Zaplata { get; set; }

        // Adding the missing Izhod method to fix the error  
        public void Izhod()
        {
            Console.WriteLine($"Ime: {Ime}, Zaplata: {Zaplata}");
        }

        // Adding a Vhod method to match the usage in Program.cs  
        public void Vhod()
        {
            Console.Write("Ime: ");
            Ime = Console.ReadLine();
            Console.Write("Zaplata: ");
            Zaplata = decimal.Parse(Console.ReadLine());
        }
    }
}
