using System;

class MainClass
{
    public static void Main(string[] args)
    {
     
        //dál pokračujte vy
        Console.WriteLine("zadej mi delku strany a");
        int delka = int.Parse(Console.ReadLine());
        for (int i = 0; i < delka; i++) {
            for (int j = 0; j < delka; j++) {
                Console.Write("#");
            }           
            Console.Write("\n");

        }


        
    }
}