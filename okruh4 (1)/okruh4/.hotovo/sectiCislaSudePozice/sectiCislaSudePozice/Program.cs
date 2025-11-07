using System;

class Program
{
    static void Main()
    {
        int cislo;
        int soucet = 0;

        for (int i = 1; i <= 10; i++)
        {
            bool platne = false;
            string vstup;

            // Opakuj dokud není zadáno platné číslo
            do
            {
                Console.Write($"Zadej {i}. číslo: ");
                vstup = Console.ReadLine();

                // kontrola, zda je vstup číslo
                if (int.TryParse(vstup, out cislo))
                {
                    platne = true;
                }
                else
                {
                    Console.WriteLine("Neplatný vstup, zadej prosím číslo.");
                }

            } while (!platne);

            // pokud je pozice sudá, přičti k součtu
            if (i % 2 == 0)
            {
                soucet += cislo;
            }
        }

        Console.WriteLine($"Součet čísel na sudých pozicích je: {soucet}");
    }
}

