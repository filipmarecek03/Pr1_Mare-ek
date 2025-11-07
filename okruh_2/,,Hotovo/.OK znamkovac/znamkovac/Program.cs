using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // Sem přijde váš kód
        Console.WriteLine("Kolik jsi měl procent z testu??");
        double procenta = double.Parse(Console.ReadLine());
      
            if ((procenta >100) || (procenta < 0))
            Console.WriteLine("neumím vyhodnotit");
        if ((procenta == 100) || (procenta >= 83))
        {
            Console.WriteLine("máš jedničku");
        }
        else if ((procenta < 83) && (procenta >= 67))
        {
            Console.WriteLine("máš dvojku");
        }
        else if ((procenta < 67) && (procenta >= 50))
        {
            Console.WriteLine("máš trojku");
        }
        else if ((procenta < 50) && (procenta >= 33))
        {
            Console.WriteLine("máš židli");
        }
        else 
        {
            Console.WriteLine("máš buuro");
        }
    }
}