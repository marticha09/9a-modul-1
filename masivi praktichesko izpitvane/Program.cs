using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("vuvedi masiv ot celi 4isla razdeleni s interval:");
        string input = Console.ReadLine();

        
        int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

       
        int min = numbers.Min();
        int max = numbers.Max();
        int sum = numbers.Sum();
        double average = numbers.Average();

       
        Console.WriteLine($"nai malkiq element: {min}");
        Console.WriteLine($"nai golemiq element: {max}");
        Console.WriteLine($"sumata na elementite: {sum}");
        Console.WriteLine($"sredna stoinost: {average:F2}");
    }
}
