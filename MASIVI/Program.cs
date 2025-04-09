    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MASIVI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nomera = new int[5];
            string[] imena = new string[5];
            //vhod 1
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Vavedete nomera {i+1} :");
                nomera[i] = int.Parse(Console.ReadLine());
                Console.Write($"Vavedete ime {i} :");
                 imena[i] =(Console.ReadLine());
                
            }

            Console.WriteLine(string.Join(", ", nomera));
            Console.WriteLine(string.Join(", ", imena));
            


        }
    }
}
