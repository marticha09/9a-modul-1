using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ne_karame_chas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi edno chislo ot 1 do 5 ");
            var a=int.Parse(Console.ReadLine());
            Console.Write("vuvedi vtoro chislo ot 1 do 5 ");

            var b = int.Parse(Console.ReadLine());
            int c = a % b;
            switch (c)
            {
                case 1: Console.WriteLine("ponedelnik"); break;
                case 2: Console.WriteLine("vtornik e den " + a + "!"); break;
                case 3:
                case 4:
                case 5: Console.WriteLine("az dnes izbrah cifra" + a + "razbrah zadachata"); break;
                default:
                    Console.WriteLine("izbral si cifra po golqma ot 5 i po malko ot 1");
                    break;

            }
        }
    }
}
