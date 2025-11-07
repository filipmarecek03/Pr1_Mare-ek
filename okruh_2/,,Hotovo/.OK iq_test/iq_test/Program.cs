using System;

class Program
{
    static void Main()
    {
        int skore = 0;
        string odpoved;

        Console.WriteLine("Vítejte v kvízu!");
        Console.WriteLine("----------------");

        // 1. otázka
        Console.Write("Kolik je 2 + 4? ");
        odpoved = Console.ReadLine();

        if (odpoved == "6")
        {
            skore += 5;
            Console.WriteLine("Správně!");
        }
        else
        {
            skore -= 3;
            Console.WriteLine("Špatně!");
        }

        // 2. otázka
        Console.Write("Které písmeno je první v abecedě? ");
        odpoved = Console.ReadLine();

        if (odpoved.ToLower() == "a")
        {
            skore += 5;
            Console.WriteLine("Správně!");
        }
        else
        {
            skore -= 3;
            Console.WriteLine("Špatně!");
        }

        // 3. otázka
        Console.Write("Je číslo 13 sudé (A/N)? ");
        odpoved = Console.ReadLine();

        if (odpoved.ToUpper() == "N")
        {
            skore += 5;
            Console.WriteLine("Správně!");
        }
        else
        {
            skore -= 3;
            Console.WriteLine("Špatně!");
        }

        // Výsledek
        Console.WriteLine("----------------");
        Console.WriteLine($"Vaše celkové skóre je: {skore} bodů");

        Console.WriteLine("Děkujeme za účast!");
    }
}
