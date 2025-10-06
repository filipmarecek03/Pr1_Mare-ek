using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        Console.Write("Zadej stranu a: ");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Zadej stranu b: ");
        double b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Zadej stranu c: ");
        double c = Convert.ToInt32(Console.ReadLine());
        double objem = a * b * c;
        double povrch = 2 * (a * b + a * c + b * c);
        Console.WriteLine("Objem kvádru je: " + objem + " Povrch kvádru je: " + povrch);

        // Konec prostoru pro kód
    }
}