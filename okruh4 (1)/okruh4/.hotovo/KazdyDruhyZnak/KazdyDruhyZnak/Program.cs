using System;

class Program
{
    static void Main()
    {
        string text = "Ahoj, jak se máš?"; // Předpřipravená proměnná

        Console.WriteLine("Původní text: " + text);
        Console.Write("Každý druhý znak: ");

        for (int i = 0; i < text.Length; i += 2)
        {
            Console.Write(text[i]);
        }

        Console.WriteLine(); // nový řádek na konci
    }
}

