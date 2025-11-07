using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Stiskněte libovolnou klávesu:");
        ConsoleKeyInfo klavesa = Console.ReadKey(true); // true = nezobrazí se znak v konzoli
        char znak = char.ToLower(klavesa.KeyChar);

        Console.WriteLine($"Stiskli jste: '{znak}'");

        // Seznam českých samohlásek
        char[] samohlasky = { 'a', 'e', 'i', 'o', 'u', 'y', 'á', 'é', 'í', 'ó', 'ú', 'ů', 'ý' };

        if (Array.Exists(samohlasky, c => c == znak))
        {
            Console.WriteLine("Tato klávesa je samohláska.");
        }
        else
        {
            Console.WriteLine("Tato klávesa není samohláska.");
        }

        Console.WriteLine("Program skončil. Stiskněte libovolnou klávesu pro ukončení...");
        Console.ReadKey();
    }
}
