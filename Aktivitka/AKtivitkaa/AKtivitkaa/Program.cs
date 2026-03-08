namespace AKtivitkaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Typovac();

        }
        static void Typovac()
        {
            Random generator = new Random();
            while (true)
            { 
            Console.WriteLine("Zadej mi číslo od 1-100");
            Console.WriteLine("-------------------------------------negr---------------------------------------------------------------------");
            int typ = int.Parse(Console.ReadLine());
            int nahodny = generator.Next(1, 101);
            if (nahodny == typ)
            {
                Console.WriteLine("Trefil jsi se:)");
            }
            else if (typ > nahodny)
            {

                Console.WriteLine("Číslo je menší");

            }
            else
            {
                Console.WriteLine("Číslo je větší");
            }    }
        }
    }
}
