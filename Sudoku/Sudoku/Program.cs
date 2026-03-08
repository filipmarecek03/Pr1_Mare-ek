namespace Sudoku
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matice;
            int radky = 4;
            int sloupce = 4;
            matice = new int[radky, sloupce];
            Console.WriteLine("--- SUDOKU 4x4 (Včetně Diagonál) ---");
            matice = NaplnMatici(radky, sloupce);
            VypisMatici(matice);
            PrintBoard();




            static int[,] NaplnMatici(int pocetr, int pocets)
            {
                int[,] naplnenaMatice = new int[pocetr, pocets];
                Random generator = new Random();
                for (int i = 0; i < pocetr; i++)
                {
                    for (int j = 0; j < pocets; j++)
                    {
                        // 35 % šance, že bude políčko prázdné
                        if (i == j || i + j == 3)
                            Console.ForegroundColor = ConsoleColor.Magenta;// prázdné políčko
                        Console.Write(board[i, j] == 0 ? ". " : board[i, j] + " ");
                    Console.ResetColor();
                        else
                            naplnenaMatice[i, j] = generator.Next(1, 5); // číslo 1–4

                    }
                }
                return naplnenaMatice;
            }
            static void PrintBoard()
            {
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        // Zvýraznění diagonál
                        if (i == j || i + j == 3)
                            Console.ForegroundColor = ConsoleColor.Magenta;

                        Console.Write(board[i, j] == 0 ? ". " : board[i, j] + " ");
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }
            }
            static void VypisMatici(int[,] matice)
            {
                for (int i = 0; i < matice.GetLength(0); i++) //radky
                {
                    for (int j = 0; j < matice.GetLength(1); j++) //sloupce
                    {
                        Console.Write("| " + matice[i, j] + " |");//ohraničení čísel

                    }
                    Console.WriteLine("\n" + "--------------------");//řádek na plepší vzhled
                }
            }
        }
    }
}