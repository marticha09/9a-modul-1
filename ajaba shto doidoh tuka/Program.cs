using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ajaba_shto_doidoh_tuka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi 4islo ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("koe 4islo da vuveda ");
            var num=int.Parse(Console.ReadLine());
            var number = 2 ;
            while (num <= n)
            {
                Console.WriteLine(num);
                num = 2 * num + 1;
            }
            
            
        }
    }
}
