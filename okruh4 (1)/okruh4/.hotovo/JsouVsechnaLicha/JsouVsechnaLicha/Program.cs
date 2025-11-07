using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadej počet čísel: ");
        int pocet = int.Parse(Console.ReadLine());
        bool vsechnaLicha = true; // předpokládáme, že všechna budou lichá

        for (int i = 0; i < pocet; i++)
        {
            Console.Write($"Zadej {i + 1}. číslo: ");
            
            int cislo = int.Parse(Console.ReadLine());

            if (cislo % 2 == 0) // sudé číslo
            {
                vsechnaLicha = false;
                break; // ukončíme cyklus, jakmile narazíme na sudé číslo
            }
        }

        if (vsechnaLicha)
            Console.WriteLine("Všechna čísla jsou lichá.");
        else
            Console.WriteLine("bylo zadáno sudé číslo.");
    }
}
