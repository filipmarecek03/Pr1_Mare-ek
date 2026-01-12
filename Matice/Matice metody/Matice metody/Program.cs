
namespace Matice_Metody
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[,] matice;
            Console.WriteLine("Zadej pocet radku:");
            int radky;
            while (int.TryParse(Console.ReadLine(), out radky) == false || radky <= 0)
            {
                Console.WriteLine("Opakuj volbu");
            }
            Console.WriteLine("Zadej pocet sloupcu:");
            int sloupce;
            while (int.TryParse(Console.ReadLine(), out sloupce) == false || sloupce <= 0)
            {
                Console.WriteLine("Opakuj volbu");
            }
            //ocekavame spravne nactene rozmery
            matice = new int[radky, sloupce];
            matice = NaplnMatici(radky, sloupce); //vyplnena matice se doplni do matice prazdne
            VypisMatici(matice);
            VratPrvek(matice);
        }

        static int[,] NaplnMatici(int pocetr, int pocets)
        {
            int[,] naplnenaMatice = new int[pocetr, pocets];
            Random generator = new Random();
            for (int i = 0; i < pocetr; i++)
            {
                for (int j = 0; j < pocets; j++)
                {
                    naplnenaMatice[i, j] = generator.Next(1, 10);
                }
            }
            return naplnenaMatice;
        }

        static void VypisMatici(int[,] matice)
        {
            for (int i = 0; i < matice.GetLength(0); i++) //radky
            {
                for (int j = 0; j < matice.GetLength(1); j++) //sloupce
                {
                    Console.Write(matice[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void VratPrvek(int[,] matice)
        {
            Console.WriteLine("Zadej cislo radku:");
            int radek;
            while (int.TryParse(Console.ReadLine(), out radek) == false || radek < 0 || radek > matice.GetLength(0))
            {
                Console.WriteLine("Zadej znovu");
            }

            Console.WriteLine("Zadej cislo sloupce:");
            int sloupec;
            while (int.TryParse(Console.ReadLine(), out sloupec) == false || sloupec < 0 || sloupec > matice.GetLength(0))
            {
                Console.WriteLine("Zadej znovu");
            }

            Console.WriteLine("Vypsany prvek je: " + matice[radek - 1, sloupec - 1]);
        }
    }
}
