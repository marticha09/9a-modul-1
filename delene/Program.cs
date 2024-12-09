using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delene
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedi edno cqlo chislo");
            int a = int.Parse(Console.ReadLine());
            if (a %2 == 0)
                Console.WriteLine("4etno");
        }
    }
}
