using System;

class Program
{
    static void Main()
    {
        string text = "Toto je velice dlouhá věta, kdo by se ji obtěžoval číst.";

        Console.WriteLine("Původní text: " + text);
        Console.Write("Bez mezer: ");

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] != ' ') // pokud znak není mezera
            {
                Console.Write(text[i]);
            }
        }

        Console.WriteLine(); // nový řádek na konci
    }
}
