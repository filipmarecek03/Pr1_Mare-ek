using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // sem přijde váš kód      
        Console.WriteLine("Napiš mi číslo: ");
        int cislo = int.Parse(Console.ReadLine());
        if (cislo % 2 == 0)
        {
            Console.WriteLine("Číslo je sudé");
        }
        else
        {
            Console.WriteLine("Číslo je liché");
        }
    }
}