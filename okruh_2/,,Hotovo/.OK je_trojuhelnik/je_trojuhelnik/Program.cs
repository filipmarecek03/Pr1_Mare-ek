using System;

class MainClass
{
    public static void Main(string[] args)
    {

        string nacteno;

        Console.Write("Zadej stranu A: ");
        nacteno = Console.ReadLine();
        double stranaA = double.Parse(nacteno);

        Console.Write("Zadej stranu B: ");
        nacteno = Console.ReadLine();
        double stranaB = double.Parse(nacteno);

        Console.Write("Zadej stranu C: ");
        nacteno = Console.ReadLine();
        double stranaC = double.Parse(nacteno);

        // Sem přijde váš kód
        if (stranaA + stranaB > stranaC && stranaC + stranaB > stranaA && stranaA + stranaC > stranaB)
        {
            Console.WriteLine("Trojúhelník lze sestrojit");
        } 
        else if (stranaA + stranaB == stranaC ||
         stranaC + stranaB == stranaA ||
         stranaA + stranaC == stranaB)
        {
            Console.WriteLine("Nelze sestrojit.");
        }
        else
        {
            Console.WriteLine("Nelze sestrojit");
        }

        }
}