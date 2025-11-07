using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.Write("Napiš číslo: ");
        string nacteno = Console.ReadLine();
        double cislo = double.Parse(nacteno);

        if (10 > Math.Abs(cislo))
            {
            Console.WriteLine($"Číslo {cislo} je blízko nuly.");
        }
        else
            Console.WriteLine($"Číslo {cislo} je poměrně velké.");
    
    }
}