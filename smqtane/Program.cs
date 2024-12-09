using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smqtane
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Въведи трицифрено число");
            int a=int.Parse(Console.ReadLine());
            int s, d, e;
            s = a / 100;
            d = s % 100;
            e = a % 100 % 10;
            Console.Write(d);
            Console.Write("e=",e);
            Console.Write($"s={s}, e={e},d={d}");
            int b = int.Parse(Console.ReadLine());
            int j, k, h;
            j = b / 10000;
            k = s % 10000 % 1000 / 100;
            h = a % 10000 % 1000 % 100 / 10;



            

            
        }
    }
}
