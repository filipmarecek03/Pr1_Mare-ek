namespace met_sude_liche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ahoj zadej mi číslo a");
            int a = 0;
            while (int.TryParse(Console.ReadLine(), out a) == false)
            {
                Console.WriteLine("Chybna hodnota, znova");
            }
            Console.WriteLine("Tvoje číslo je " + sudlich(a));

        }
        static string sudlich(int n)
        {
            if (n % 2 == 0) // sudé číslo
            {
                string sude = "číslo je sudé";
                return sude;
            }
            else
            {
                string liche = "číslo je liché";
                return liche;
            }

            
        }
    }
}
