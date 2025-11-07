using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        Console.Write("Zadej celé číslo:");
        int cislo = int.Parse(Console.ReadLine());
        if (cislo % 2 == 0 && cislo % 3 == 0)
        {
            Console.WriteLine($"Číslo {cislo} je dělitelné 2 i 3.");
        }
        else if (cislo % 2 == 0)
        {
            Console.WriteLine($"Číslo {cislo} je dělitelné jen 2.");
        }
        else if (cislo % 3 == 0)
        {
            Console.WriteLine($"Číslo {cislo} je dělitelné jen 3.");
        }
        else
        {
            Console.WriteLine("Číslo není dělitelné ani dvojku, ani trojkou.");
        }
    }

    }