using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // sem přijde váš kód      
        Console.WriteLine("Napiš hodnotu x: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Napiš hodnotu y: ");
        int y = int.Parse(Console.ReadLine());
        if (x > y) 
        {
            Console.WriteLine("x je větší než y");
        }
        
        else
        {
            Console.WriteLine("y je větší než x");

        }
        }
}