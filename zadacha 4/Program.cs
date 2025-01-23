using System;

class Program
{
    static void Main()
    {
        
        Console.Write("vuvedi broq na elementite v masiva: ");
        int n = int.Parse(Console.ReadLine());

       
        int[] arr = new int[n];
        
        Console.WriteLine("vuvedi elementite na masiva:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

      
        while (arr.Length > 1)
        {
            int[] tempArr = new int[arr.Length - 1];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                tempArr[i] = arr[i] + arr[i + 1];
            }
            arr = tempArr; 
        }

        Console.WriteLine("rezoltatut e: " + arr[0]);
    }
}
