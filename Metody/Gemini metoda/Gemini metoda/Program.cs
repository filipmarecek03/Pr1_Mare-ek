using System;

class Program
{
    static void Main() // M musí být velké!
    {
        // 1. Vytvoření generátoru (R musí být velké)
        Random generator = new Random();

        // 2. Vytvoření pole pro 5 čísel
        int[] pole = new int[5];

        // 3. Naplnění pole náhodnými čísly (0-100)
        for (int i = 0; i < 5; i++)
        {
            pole[i] = generator.Next(0, 101); // 101, aby tam mohla být i 100
        }

        Console.WriteLine("Čísla větší než 50:");

        // 4. Výpis čísel větších než 50
        for (int i = 0; i < 5; i++)
        {
            if (pole[i] > 50)
            {
                Console.WriteLine(pole[i]);
            }
        }
    }
}