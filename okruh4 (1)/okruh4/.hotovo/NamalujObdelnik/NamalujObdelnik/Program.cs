using System;

class MainClass
{
    public static void Main(string[] args)
    {

        //dál pokračujte vy
        Console.WriteLine("zadej mi vysku");
        int vyska = int.Parse(Console.ReadLine());
        Console.WriteLine("zadej mi sirku");
        int sirka = int.Parse(Console.ReadLine());
        for (int i = 0; i < vyska; i++)
        {
            for (int j = 0; j < sirka; j++)
            {
                Console.Write("#");
            }
            Console.Write("\n");

        }



    }
}