using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // sem přijde váš kód      
        Console.WriteLine("napiš 1. celé číslo ");
        int A = int.Parse(Console.ReadLine());
        Console.WriteLine("napiš 2. celé číslo ");
        int B = int.Parse(Console.ReadLine());
        Console.WriteLine("napiš 3. celé číslo ");
        int C = int.Parse(Console.ReadLine());
        Console.WriteLine("napiš 4. celé číslo ");
        int D = int.Parse(Console.ReadLine());

        if (A > B && A > C && A > D && B >C && B>D && C>D)
            {
            Console.WriteLine(A + " pak " + B + " pak " + C + " pak " + D + " pak ");
        }
            else
        {
            Console.WriteLine("není velký");
        }

    }
}