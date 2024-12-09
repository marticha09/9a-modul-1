using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mesec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi cifra");
            string month = (Console.ReadLine());
            switch (month)
            {
                case "12":
                case "1":
                case "2":
                    Console.WriteLine("zima");
                    break;
                case " 3 ":
                case " 4 ":
                case "5":
                    Console.WriteLine("prolet");
                    break;
                case "6":
                case "7":
                case "8":
                    Console.WriteLine("lqto");
                    break;
                case "9":
                case "10":
                case "11":
                    Console.WriteLine("esen");
                    break;
                default:Console.WriteLine("nqma takuv mesec");
                    break;
            }
            

            }
    }
}
