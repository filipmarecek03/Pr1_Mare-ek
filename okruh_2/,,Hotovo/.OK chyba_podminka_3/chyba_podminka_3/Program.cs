using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.Write("Napiš číslo: ");
        string nacteno = Console.ReadLine();
        int cislo = int.Parse(nacteno);

        if ((cislo) % 3 == 0)
        {
            Console.WriteLine($"Číslo {cislo} je dělitelné třemi, to se mi líbí.");
        }
        else
            Console.WriteLine($"Třemi číslo {cislo} dělitelné není." + "Taková čísla nemám rád.");
      

    }
}