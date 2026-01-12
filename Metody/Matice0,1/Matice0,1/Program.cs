
namespace Matice0_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matice;
            Console.WriteLine("Zadej počet řádků");
            int radky = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadej počet sloupců");
            int sloupec = int.Parse(Console.ReadLine());
            matice = new int[radky, sloupec];
            int cislo = 0;
            //for (int =0; i <matice.GetLength(0); i++) funkce na procházení
            for (int i = 0; i < radky; i++)
            {
                for (int j = 0; j < sloupec; j++)
                {
                    matice[i, j] = cislo;
                    cislo++;
                }
            }
            for (int i = 0; i < radky; i++)
            {
                for (int j = 0; j < sloupec; j++)
                {
                    Console.Write(matice[i, j] + " ");///vypis radku
                }
                Console.WriteLine();
            }
            Console.WriteLine("Zadej radek k vypsani (zacatek v 0): ");
            int r;
            while (int.TryParse(Console.ReadLine(), out r) == false || r < 0 || r > radky)
            {
                Console.WriteLine("chybne zadana hodnota, opakuj volbu");
            }
            
            int soucetSudych = 0; // Proměnná pro ukládání součtu

            for (int i = 0; i < sloupec; i++)
            {
                int aktualniCislo = matice[r, i];
                Console.Write(aktualniCislo + " ");

                // Kontrola, zda je HODNOTA v matici sudá
                if (Jesude(aktualniCislo))
                {
                    soucetSudych += aktualniCislo;
                }
            }

            Console.WriteLine($"\nSoučet sudých čísel na vybraném řádku: {soucetSudych}");
            int soucetVsechSudych = 0;

            for (int i = 0; i < radky; i++) // Procházíme řádky
            {
                for (int j = 0; j < sloupec; j++) // Procházíme sloupce
                {
                    int hodnota = matice[i, j];
                    if (Jesude(hodnota))
                    {
                        soucetVsechSudych += hodnota;
                    }
                }
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"Součet všech sudých čísel v celé matici: {soucetVsechSudych}");
            Console.WriteLine("--------------------------------------");
        }

        
        static bool Jesude(int cislo)
        {
            if (cislo % 2 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
