using System;
using System.ComponentModel.Design;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        int x;
        int y;
        Console.WriteLine("Napiš mi hodnotu x: ");
        x = int.Parse(Console.ReadLine());
        Console.WriteLine("Napiš mi hodnotu y: ");
        y = int.Parse(Console.ReadLine());
        /*
        if ((x > 0) && (y > 0)) ;
        Console.WriteLine("Bod je v 1. kvadrantu");
        if ((x < 0) && (y > 0)) ;
        Console.WriteLine("Bod je v 2. kvadrantu");
        if ((x < 0) && (y < 0)) ;
        Console.WriteLine("Bod je v 3. kvadrantu");
        if ((x > 0) && (y < 0)) ;
        Console.WriteLine("Bod je v 4. kvadrantu");
        if ((x == 0) || (y == 0)) ;
        Console.WriteLine("Bod je 0");
        */
        if ((x > 0) && (y > 0)) 
        Console.WriteLine("Bod je v 1. kvadrantu");
        else if ((x < 0) && (y > 0))
            Console.WriteLine("Bod je v 2. kvadrantu");
        
        else if ((x < 0) && (y < 0))
            Console.WriteLine("Bod je v 3. kvadrantu");
        else if ((x > 0) && (y < 0))
            Console.WriteLine("Bod je v 4. kvadrantu");
        else
            Console.WriteLine("Leží na ose");


        // Konec vašeho kódu
    }
}