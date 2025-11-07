using System;

class Program
{
    static void Main()
    {
        Console.Write("Z jakého čísla chceš spočítat faktoriál: ");
        long cislo = long.Parse(Console.ReadLine()); // může být i int, ale long zvládne větší čísla

        long faktorial = 1;

        for (long i = 1; i <= cislo; i++)
        {
            faktorial *= i;
        }

        Console.WriteLine($"{cislo}! = {faktorial}");
    }
}


        