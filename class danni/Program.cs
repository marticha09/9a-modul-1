using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_danni
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("br slujiteli: ");
            int n = int.Parse(Console.ReadLine());
            danni1[] slujitel = new danni1[n];
            for(int i=0; i<n;i++)
            {
                Console.WriteLine($"slujitel{i + 1}");
                slujitel[i] = new danni1();
                slujitel[i].Vhod();
            }
            Console.WriteLine("---spisak na slujtelite---");
            for (int i = 0; i < n; i++)
            {
             slujitel[i].Izhod();
            }

        }
    }
}
