using System;

class MainClass
{
    public static void Main(string[] args)
    {

         string zbozi1 = "vejce";
        double cena1 = 3.5;

        string zbozi2 = "rohlík";
        double cena2 = 1.9;

        string zbozi3 = "chleba";
        double cena3 = 25;

        string zbozi4 = "mlíko";
        double cena4 = 22;

        Console.Write("Kolik kusů " + zbozi1 + "(" + cena1 + ")" + " chcete? ");
        double vejce = Convert.ToDouble(Console.ReadLine()) * cena1;

        Console.Write("Kolik kusů " + zbozi2 + "(" + cena2 + ")" + " chcete? ");
        double Rohlík = Convert.ToDouble(Console.ReadLine()) * cena2;

        Console.Write("Kolik kusů " + zbozi3 + "(" + cena3 + ")" + " chcete? ");
        double Chleba = Convert.ToDouble(Console.ReadLine()) * cena3;

        Console.Write("Kolik kusů " + zbozi4 + "(" + cena4 + ")" + " chcete? ");
        double Mlíko = Convert.ToDouble(Console.ReadLine()) * cena4;

        Console.WriteLine($"Váš nákup stojí {vejce+Rohlík+Chleba+Mlíko} Kč");

        string zbozi5 =;
        Console.WriteLine("Zadej název:");
        double cena5 =;
        Console.WriteLine("Zadej cenu věci");
    }
}