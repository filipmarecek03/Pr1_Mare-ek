namespace nakup2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pocetKusu;
            double vyslednaCena = 0;


            string zbozi1 = "Vejce";
            double cena1 = 3.5;

            string zbozi2 = "Rohlík";
            double cena2 = 1.9;

            string zbozi3 = "Chleba";
            double cena3 = 25;

            string zbozi4 = "mlíko";
            double cena4 = 22;

            // Sem přijde váš kód
            Console.WriteLine(zbozi1 + " v cene " + cena1 + " Kolik kusu chcete?");
            pocetKusu = int.Parse(Console.ReadLine());
            vyslednaCena = vyslednaCena + pocetKusu * cena1;

            Console.WriteLine(zbozi2 + " v cene " + cena2 + " Kolik kusu chcete?");
            pocetKusu = int.Parse(Console.ReadLine());
            vyslednaCena = vyslednaCena + pocetKusu * cena2;

            Console.WriteLine(zbozi3 + " v cene " + cena3 + " Kolik kusu chcete?");
            pocetKusu = int.Parse(Console.ReadLine());
            vyslednaCena = vyslednaCena + pocetKusu * cena3;

            Console.WriteLine(zbozi4 + " v cene " + cena4 + " Kolik kusu chcete?");
            pocetKusu = int.Parse(Console.ReadLine());
            vyslednaCena = vyslednaCena + pocetKusu * cena4;

            Console.WriteLine("Celkem cena: " + vyslednaCena);

        }
    }
}
