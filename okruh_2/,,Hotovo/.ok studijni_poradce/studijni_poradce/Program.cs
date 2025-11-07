using System;

class Program
{
    static void Main()
    {
        Console.Write("Kolik procent získal žák z matematiky? ");
        double matematika = double.Parse(Console.ReadLine());

        Console.Write("Kolik procent získal žák z jazyků? ");
        double jazyky = double.Parse(Console.ReadLine());

        if (matematika > 66 && jazyky > 66)
        {
            if (matematika > jazyky)
            {
                Console.WriteLine("Doporučuje se studovat technický obor.");
            }
            else if (jazyky > matematika)
            {
                Console.WriteLine("Doporučuje se studovat humanitní obor.");
            }
            else
            {
                Console.WriteLine("Oba výsledky jsou stejné — doporučuje se vybrat podle osobních preferencí.");
            }
        }
        else
        {
            Console.WriteLine("Doporučuje se vyučit řemeslo.");
        }
    }
}
