using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // sem přijde váš kód      
        Console.Write("Zadej mi číslo: ");
        int x = int.Parse(Console.ReadLine());
        if (x >0)
        {
            Console.WriteLine("Číslo je kladné");
        }
        else if (x<0)
        {
            Console.WriteLine("Číslo je záporné");
        }
        
            else
            {
                Console.WriteLine("Číslo je 0");
            }
        }
}