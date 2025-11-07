namespace Tipovačka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipni si číslo od 1 do 6.");
            int tip = int.Parse(Console.ReadLine());
            Random generátor = new Random();
            int hod = 0;

           
            if ((tip > 0) && (tip < 7))
            {
                hod = generátor.Next(1, 7);
                Console.WriteLine("Číslo na kostce bylo: " + hod);
                if (tip == hod)
                {
                    Console.WriteLine("Hurá,saprávný tip!");
                }
                else
                {
                    Console.WriteLine("Netrefil ses!");
                }
            }
        }
    }
}
