namespace prevod_casu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolik chceš převíst sekund: ");
            int sec = int.Parse(Console.ReadLine());
            int hodiny = sec/3600;
            int min = sec % 3600;
            int minuty = min / 60;
            int sekundy = min % 60;
            /* \n znamená odřádkování
             */
            Console.Write("\n Hodiny: " + hodiny + " Mínuty: " + minuty + " Zbytek sekund: " + sekundy);

        }
    }
}
