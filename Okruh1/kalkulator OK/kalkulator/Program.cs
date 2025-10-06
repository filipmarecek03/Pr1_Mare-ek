using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Napiš číslo a: ");
        //double je prodloužý float
        double number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Napiš číslo b: ");
        double number2 = Convert.ToInt32(Console.ReadLine());
        double plus = number1 + number2;
        double mínus = number1 - number2;
        double krát = number1 * number2;
        double děleno = number1 / number2;
        Console.WriteLine("Součet je: " + plus + " Rozdíl je: " + mínus + " Součin je: " + krát + " Podíl je: " + děleno);
    }
}