using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lesni_masivi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //zadelqne
            double n=double.Parse(Console.ReadLine());
            double[] a = new double[4]; 
            for(int i = 0; i < 4; i++) 
            {
                a[i] = double.Parse(Console.ReadLine());
               
            }
            //izhod 1
           for (int i = 0; i < 4; i++) 
            {
                Console.WriteLine($"izhod 1:{a[i]}");
            }
           Array.Sort(a);
            for (int i = 0; i < 4; i++) 
            {
                Console.WriteLine($"izhod 2:{a[i]}");
            }
            Array.Reverse(a);
            for (int i = 0; i < 4; i++) 
            {
                Console.WriteLine($"izhod 3:{a[i]}");
            }
            int pos = 1;
            int countOfZero = 1;
            Array.Clear(a,pos, countOfZero);
            for (int i = 0; i < 4; i++) 
            {
                Console.WriteLine($"izhod 3:{a[i]}");
            }






        }
    }
}
