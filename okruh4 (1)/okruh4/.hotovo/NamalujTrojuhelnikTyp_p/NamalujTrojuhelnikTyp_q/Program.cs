using System;

class MainClass
{
    public static void Main(string[] args)
    {


        //dál pokračujte vy


        Console.Write("Zadej výšku trojúhelníku: ");
        int vyska = int.Parse(Console.ReadLine());

        int pocetHvezd = vyska;
        for (int i = 0; i < vyska; i++)
        {
           
            
            // Vypíše hvězdičky
            Console.WriteLine(new string('#', pocetHvezd));
            pocetHvezd = pocetHvezd - 1;
        }
    }
}

