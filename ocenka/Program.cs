using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ocenka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("въведи каква оценка искаш ?");
            double ocenka=double.Parse(Console.ReadLine());
            if (ocenka == 2)
                Console.WriteLine("слаб 2");
            else
            if (ocenka < 3.49)
                Console.WriteLine("среден 3");
            if(ocenka >= 3.50)
                Console.WriteLine("добър 4");





            
                if (ocenka == 4)
                Console.WriteLine("добър 4");
            else
                if (ocenka == 5)
                Console.WriteLine("много добър 5");
            else
                if (ocenka == 6)
                Console.WriteLine("отличен 6");
            else

                Console.WriteLine("няма такава оценка");





        }
    }
}
