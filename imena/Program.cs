using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kak se kazvash");
            int n = int.Parse(Console.ReadLine());
           // int[] arr = new int[n];
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());

            }
            int[] numbers = new int[10];
            Console.WriteLine("kolko ocenki imash");

           
        }
    }
}
