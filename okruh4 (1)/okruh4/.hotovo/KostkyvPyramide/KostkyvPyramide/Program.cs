using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadej výšku pyramidy: ");
        int vyska = int.Parse(Console.ReadLine());
        int pocetKostek = 0;

        for (int i = 1; i <= vyska; i++)
        {
            pocetKostek += i * i; // přičteme čtverec aktuální vrstvy
        }

        Console.WriteLine($"Na pyramidu výšky {vyska} je potřeba {pocetKostek} kostek.");
    }
}

