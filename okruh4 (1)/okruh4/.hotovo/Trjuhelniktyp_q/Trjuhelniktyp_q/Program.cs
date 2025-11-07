using System;

class Program
{
    static void Main()
    {
        Console.Write("Zadej délku strany trojúhelníku: ");
        int n = int.Parse(Console.ReadLine());

        // Každý řádek má o jeden # méně než ten předchozí
        for (int i = n; i >= 1; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine(); // nový řádek po každém řádku #
        }
    }
}
