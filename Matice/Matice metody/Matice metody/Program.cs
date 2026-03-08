
namespace Matice_Metody
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int[,] matice;
            int[,] maticeT;
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
            maticeT = new int[radky, sloupce];
            matice = NaplnMatici(radky, sloupce);//vyplnena matice se doplni do matice prazdne
            VypisMatici(matice);
            Console.WriteLine("------------------------------------------");
           maticeT=  VypisObraceneMatice(matice);

            VypisMatici(maticeT);
            Console.WriteLine("------------------------------------------");

            VypisVedlejsiDiagonalu(matice);
           // VypisObraceneMatice(matice);
           //  VratPrvek(matice);
        }

        static int[,] NaplnMatici(int pocetr, int pocets)
        {
            int[,] naplnenaMatice = new int[pocetr, pocets];
            Random generator = new Random();
            for (int i = 0; i < pocetr; i++)
            {
                for (int j = 0; j < pocets; j++)
                {
                    naplnenaMatice[i, j] = generator.Next(1, 5);
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
        static int[,] VypisObraceneMatice(int[,] matice)
        {
            int[,] maticeP = new int[matice.GetLength(0), matice.GetLength(1)];
            Console.WriteLine();
            
            for (int i = 0; i < matice.GetLength(0); i++) //radky
            {
                for (int j = 0; j < matice.GetLength(1); j++) //sloupce
                {
                  
                    
                    maticeP[i, j] = matice[j, i];
                }
              
            }
            return maticeP;
        }
        /* static void VratPrvek(int[,] matice)
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
        */
        /*public static int[,] prohyPod(int[,] matice)
        {
            int[,] maticePod = new int[matice.GetLength(0), matice.GetLength(1)];
            Console.WriteLine();

            for (int i = 0; i < matice.GetLength(0); i++) //radky
            {
                for (int j = 0; j < matice.GetLength(1); j++) //sloupce
                {
                    if()
                    {
                        Console.WriteLine(maticePod);
                    }
        
                }

            }
            return maticePod;
        }*/
        static void VypisVedlejsiDiagonalu(int[,] matice)
        {
            int radky = matice.GetLength(0);
            int sloupce = matice.GetLength(1);

            // diagonála existuje jen když je matice čtvercová
            if (radky != sloupce)
            {
                Console.WriteLine("Vedlejší diagonálu lze vypsat jen u čtvercové matice.");
                return;
            }

            Console.WriteLine("Vedlejší diagonála (z pravého horního do levého dolního):");

            for (int i = 0; i < radky; i++)
            {
                Console.Write(matice[i, sloupce - 1 - i] + " ");
            }

            Console.WriteLine();
        }

    }
}
