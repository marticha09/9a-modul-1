using System;

class Program
{
    static void Main()
    {
        
        char[] alphabet = new char[26];
        for (int i = 0; i < 26; i++)
        {
            alphabet[i] = (char)('a' + i);
        }
        
        Console.Write("vuvedi duma s malki bukvi: ");
        string word = Console.ReadLine();

       
        foreach (char letter in word)
        {
            int index = Array.IndexOf(alphabet, letter);
            Console.WriteLine($"bukvata '{letter}' ima index {index}");
        }
    }
}


