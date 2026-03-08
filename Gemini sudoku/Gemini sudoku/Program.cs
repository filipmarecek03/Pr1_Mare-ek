namespace Gemini_sudoku
{
    using System;

    class SudokuX
    {
        // Herní pole 4x4
        static int[,] board = new int[4, 4];

        // Označení pevných čísel ze zadání
        static bool[,] isFixed = new bool[4, 4];

        static void Main()
        {
            GenerateSimpleGame(); // Vytvoří startovní hru

            while (true)
            {
                Console.Clear();
                Console.WriteLine("--- SUDOKU 4x4 (Včetně Diagonál) ---");
                PrintBoard(); // Vykreslí hrací plochu

                if (IsFull()) // Kontrola, zda je vše vyplněno
                {
                    Console.WriteLine("\nGratulace! Vše je správně vyplněno.");
                    break;
                }

                Console.WriteLine("\nZadej: 'řádek sloupec číslo' (např. 1 2 3) nebo 'R' pro restart:");
                string input = Console.ReadLine()?.ToUpper();

                if (input == "R")
                {
                    GenerateSimpleGame(); // Restart hry
                    continue;
                }

                try
                {
                    // Rozdělení vstupu
                    string[] parts = input.Split(' ');
                    int r = int.Parse(parts[0]) - 1;
                    int s = int.Parse(parts[1]) - 1;
                    int val = int.Parse(parts[2]);

                    if (isFixed[r, s])
                    {
                        Console.WriteLine("Původní čísla nelze měnit!");
                    }
                    else if (IsValidMove(r, s, val)) // Kontrola pravidel
                    {
                        board[r, s] = val; // Uložení čísla
                    }
                    else
                    {
                        Console.WriteLine("CHYBA: Číslo porušuje pravidla!");
                    }
                }
                catch
                {
                    Console.WriteLine("Neplatný vstup.");
                }

                Console.WriteLine("Stiskni libovolnou klávesu...");
                Console.ReadKey();
            }
        }

        // Kontrola, zda je tah platný
        static bool IsValidMove(int row, int col, int val)
        {
            if (val == 0) return true; // 0 = smazání

            // Kontrola řádku a sloupce
            for (int i = 0; i < 4; i++)
            {
                if (board[row, i] == val || board[i, col] == val)
                    return false;
            }

            // Kontrola hlavní diagonály
            if (row == col)
            {
                for (int i = 0; i < 4; i++)
                    if (board[i, i] == val)
                        return false;
            }

            // Kontrola vedlejší diagonály
            if (row + col == 3)
            {
                for (int i = 0; i < 4; i++)
                    if (board[i, 3 - i] == val)
                        return false;
            }

            return true;
        }

        // Vytvoří jednoduché startovní zadání
        static void GenerateSimpleGame()
        {
            Array.Clear(board, 0, board.Length);
            Array.Clear(isFixed, 0, isFixed.Length);

            // Pár pevných čísel
            int[,] start = { { 0, 0, 1 }, { 1, 1, 2 }, { 2, 2, 3 }, { 3, 3, 4 } };

            for (int i = 0; i < start.GetLength(0); i++)
            {
                int r = start[i, 0];
                int s = start[i, 1];
                int v = start[i, 2];

                board[r, s] = v;
                isFixed[r, s] = true;  
            }
        }

        // Vykreslení hrací plochy
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

        // Kontrola, zda je celé pole vyplněné
        static bool IsFull()
        {
            foreach (int i in board)
                if (i == 0) return false;

            return true;
        }
    }
}