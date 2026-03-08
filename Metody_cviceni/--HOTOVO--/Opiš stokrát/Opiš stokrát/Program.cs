using System;

class MainClass
{
    public static void Main(string[] args)
    {
        //zde metodu zavolejte
        Console.WriteLine("Zadej text: ");
        string text = Console.ReadLine();
        Console.WriteLine("Zadej kolikrá tto chceš vypsat: ");
        int kolik = int.Parse(Console.ReadLine());
       Stokrat(text, kolik);
    }

    //zde metodu deklarujte
    static void Stokrat(string veta, int opakuj)
    {
        for (int i = 0; i < opakuj; i++)
        {
            Console.WriteLine(veta);
        }
    }
}