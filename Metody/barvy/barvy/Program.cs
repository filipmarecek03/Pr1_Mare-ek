namespace barvy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej oblibenou barvu");
            string oblibenábarva = Console.ReadLine();

               


            Console.WriteLine("Zadej číslo na násobení");
            int cislo = int.Parse(Console.ReadLine());
            
           /* while (int.TryParse(Console.ReadLine(), out cislo) == false)
            {
                Console.WriteLine("Chybna hodnota, znova");
            }
           */
            Barva(oblibenábarva);
            Console.WriteLine("Dvojnásobek čísla " + cislo + " je: " + dvakrat(cislo));

        }
        static void Barva(string oblibenabarva)
        {
            Console.WriteLine("Tvoje oblíbená barva je: " + oblibenabarva);
        }
        static int dvakrat(int a)
        {
            int v = 0;
            v = a * 2;
            return v;
        }

    }
}
