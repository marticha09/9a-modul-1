using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klukarka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi bukva");
            string r = (Console.ReadLine());
            switch (r)
            {
                case "r": Console.WriteLine("vechno blee v chas"); break;
                case "X": Console.WriteLine("klukarka"); break;
                case "m": Console.WriteLine("samo te slushat"); break;
                case "x": Console.WriteLine("samo te slushat"); break;
                case "c": Console.WriteLine("samo te slushat"); break;
                case "h": Console.WriteLine("samo te slushat"); break;
                case "k": Console.WriteLine("samo te slushat"); break;
                case "y": Console.WriteLine("samo te slushat"); break;
                        default:Console.WriteLine("nqma drugi");
                    break;
            }





            }
    }
}
