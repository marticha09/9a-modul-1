using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upr_6_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("izhod 1");
            Console.WriteLine(n--);
            Console.WriteLine("izhod 2");
            Console.WriteLine(n);
            Console.WriteLine("izhod 3");
            Console.WriteLine(--n);
            Console.WriteLine("izhod 4");
            Console.WriteLine(n);
            //Console.WriteLine("izhod 5");
            //Console.WriteLine(n++);
            //Console.WriteLine("izhod 6");
            //Console.WriteLine(n);
            //Console.WriteLine("izhod 7");
            //Console.WriteLine(++n);
            //Console.WriteLine("izhod 8");
            //Console.WriteLine(n);



        }
    }
}
