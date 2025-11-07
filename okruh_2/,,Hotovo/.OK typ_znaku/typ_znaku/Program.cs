using System;

class MainClass
{
    public static void Main(string[] args)
    {

        Console.Write("Zadej jeden znak: ");
        char znak = Console.ReadKey().KeyChar; // Načtení jednoho znaku bez Enteru
        Console.WriteLine(); // Pro nový řádek

        if (char.IsLetter(znak))
        {
            Console.WriteLine("Zadal jsi písmeno.");
        }
        else if (char.IsDigit(znak))
        {
            Console.WriteLine("Zadal jsi číslo.");
        }
        else
        {
            Console.WriteLine("Zadal jsi jiný symbol.");
        }
    }
}