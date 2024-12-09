using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimetur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вкарай периметъра = ");
            var r = double.Parse(Console.ReadLine());
            Console.WriteLine("Лицето е = " + Math.PI * r * r);
            // Math.PI - вградена в C# константа за π
            Console.WriteLine("Периметърът е = " + 2 * Math.PI * r);



        }
    }
}
