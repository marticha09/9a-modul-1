using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formuli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FIGURA USPOREDNIK
            double z, x, y;
            Console.Write("x=");
          x= double.Parse(Console.ReadLine());
            Console.Write("y=");
            y= double.Parse(Console.ReadLine());
            //FIGURA PRAVOUGULNIK
            z = 2 * x + 3 * y * y + 4 * x * y + (5 / 20 * x * y * y * y);
            //FIGURA IZHOD USPOREDNIK
            double a = 2.3455;
            Console.WriteLine(Math.Round(z));
            Console.WriteLine(Math.Round(z,4));
            Console.WriteLine(Math.Ceiling(z));
            Console.WriteLine(Math.Floor(z));


        }
    }
}
