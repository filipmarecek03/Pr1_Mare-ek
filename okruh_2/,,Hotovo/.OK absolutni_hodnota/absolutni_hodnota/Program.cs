using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // sem přijde váš kód      
        Console.WriteLine("Zadej hodnotu: ");
        double cislo = double.Parse(Console.ReadLine());
        if (cislo < 0) 
        {
            Console.WriteLine("Absolutní hodnota je: " + cislo * (-1));
        }
        else if (cislo == 0)
        {
            Console.WriteLine("absolutni jodnota je 0");
        }
        else
        {
            Console.WriteLine("absolutní hodnota je " + cislo);
        }
    }
}