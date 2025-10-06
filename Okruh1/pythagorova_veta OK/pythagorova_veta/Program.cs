using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        Console.Write("Zadej mi rozměr odvěsny a: ");
        double a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Zadej mi rozměr odvěsny b: ");
        double b = Convert.ToInt32(Console.ReadLine());
        double počítání = a * a + b * b;
        double odmocneni = Math.Sqrt(počítání);
        double zaokrouhleni = Math.Round(odmocneni, 2);
        Console.WriteLine("Přepona je: " + zaokrouhleni);

        // Konec prostoru pro kód
    }
}