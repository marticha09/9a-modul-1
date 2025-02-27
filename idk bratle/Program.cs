using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace idk_bratle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadelqne
            Console.Write("kolko danni shte vuvejdash");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int[] den = new int[n];
            string[] imena = new string[n];
            //vhod
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("vuvedi ime");
                imena[i] = Console.ReadLine();

                Console.WriteLine("vuvedi den");
                den[i] = int.Parse(Console.ReadLine());
                //sortirane
                for (int j = 0; j < arr.Length; j++)
                {
                    for (int k = 0; k < arr.Length - 1; k++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int swapVar = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = swapVar;
                        }
                    }
                }
                //izhod
                Console.WriteLine("sortirai dannite po dni");
                for (int a = 0; a<n; a++)
                {
                    Console.WriteLine("ime:" + imena[i] +"Den:"+ den[i]);
                    //izhod1
                    Console.WriteLine("izvejdane na dannite na rojdennika:");
                    Console.WriteLine("Negovoto ime e:" + imena[i] + "denqt na koito ima rojden den");




                }

            }
        }
    }
}
