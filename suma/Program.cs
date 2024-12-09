using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suma
{
    internal class Program
    {
        static void Main(string[] args)
            
        {
            //
            double c, a;
            Console.Write("a=");
            a=double.Parse(Console.ReadLine());
            //var a=double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b=double.Parse(Console.ReadLine());
            c= a + b;
            Console.WriteLine("c="+c);
            Console.WriteLine("c={0}",c);
            Console.WriteLine("sumata na a+b e: "+c);
            Console.WriteLine($"sumata na a+b e ={c}");
            




        }
    }
}
