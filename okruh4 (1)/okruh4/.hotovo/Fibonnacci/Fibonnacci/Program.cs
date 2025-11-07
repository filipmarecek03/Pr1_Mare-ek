using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadej, kolik Fibonacciho čísel chceš zobrazit: ");
        int n = int.Parse(Console.ReadLine());

        int a = 1; // první číslo
        int b = 1; // druhé číslo

        Console.Write("Fibonacciho řada: ");

        // vypiš prvních n čísel
        for (int i = 0; i < n; i++)
        {
            Console.Write(a + " ");
            int c = a + b; // spočítáme další číslo
            a = b; // posuneme první číslo
            b = c; // posuneme druhé číslo
        }

        Console.WriteLine(); // nový řádek na konci
    }
}
