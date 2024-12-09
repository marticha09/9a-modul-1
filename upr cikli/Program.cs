using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace upr_cikli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            var n=int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var stars = new string('*',i);
                var dollars = new string('$', i);
                var spaces = new string(' ', n - i);
                Console.Write(spaces);
                Console.Write(dollars);
                Console.Write('*');
                Console.Write(stars);
                Console.WriteLine(spaces);
            }
          
               for (int i=n; i>= 0; i--)
            {
                var stars = new string('$', i);
                var spaces = new string(' ', n - i);
                Console.Write(spaces);
                Console.Write(stars);
                Console.Write('*');
                Console.Write(stars);
                Console.WriteLine(spaces);
            }




        }
    }
}
