using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Napiš mi 1. slovo: ");
        string slovo1 = Console.ReadLine();
        Console.WriteLine("Napiš mi 2. slovo: ");
        string slovo2 = Console.ReadLine();
        if (slovo1.Length > slovo2.Length)
        {
            Console.WriteLine($"Delší slovo je: {slovo1}");
        }
        else if (slovo2.Length > slovo1.Length)
        {
            Console.WriteLine($"Delší slovo je: {slovo2}");
        }
        else
        {
            Console.WriteLine("Obě slova jsou stejně dlouhá.");
        }

    }
}