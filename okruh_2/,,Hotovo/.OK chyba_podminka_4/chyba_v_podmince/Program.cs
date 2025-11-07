using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.Write("Napiš číslo: ");
        string nacteno = Console.ReadLine();
        double cislo = double.Parse(nacteno);

        if ((cislo) <= 5)
        {
            Console.WriteLine("Číslo je malé");
        }
        else
        {
            Console.WriteLine("číslo není malé");
        }
        

    }
}