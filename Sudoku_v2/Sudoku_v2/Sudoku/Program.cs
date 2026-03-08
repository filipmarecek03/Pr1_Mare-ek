using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace sudoku
{
    class SudokuX
    {
        // Herní pole 4x4
        static int[,] board = new int[4, 4];

        // Označení pevných čísel ze zadání
        static bool[,] isFixed = new bool[4, 4];

        // Generátor náhodných čísel pro výběr zadání
        static Random rnd = new Random();

        static void Main()
        {
            // Hlavní smyčka programu: umožní opakované hraní po dokončení
            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("=======   SUDOKU   =======\n");
                Console.ResetColor();
                Console.WriteLine("Ahoj uživateli. Vítám tě v mé sudoku. Před tím než začneme ti doporučuji si přečíst pravidla hry. ");
                Console.WriteLine("Pokud si chceš prohlídnout pravidla stiskni klávesu P");
                Console.WriteLine("Pokud chceš pokračovat stisnki lihovolnout klávesu");

                string pravidla = Console.ReadLine().ToUpper();

                if (pravidla == "P")
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("=== PRAVIDLA SUDOKU X (4x4) ===");
                    Console.ResetColor();
                    Console.WriteLine("\n1. Cílem je vyplnit tabulku čísly 1 až 4.");
                    Console.WriteLine("2. Číslo se NESMÍ opakovat v:");
                    Console.WriteLine("   - stejném ŘÁDKU");
                    Console.WriteLine("   - stejném SLOUPCI");
                    Console.WriteLine("   - HLAVNÍCH DIAGONÁLÁCH (úhlopříčkách)");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n(Diagonály jsou v tabulce zvýrazněny růžovou barvou.)");
                    Console.ResetColor();

                    Console.WriteLine("\n3. Ovládání:");
                    Console.WriteLine("   - Zadávej: 'řádek sloupec číslo' (např. 1 2 3)");
                    Console.WriteLine("   - Smazání: jako číslo zadej 0 (např. 1 2 0)");

                    Console.WriteLine("\n-------------------------------------------");
                    Console.WriteLine("Stiskni libovolnou klávesu pro návrat do menu...");
                    ConsoleKeyInfo info = Console.ReadKey(); 
                }
                break;
            }
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("=======   SUDOKU   =======\n");
                Console.ResetColor();

                // Nejdřív necháme uživatele vybrat úroveň
                int level = ChooseLevel();

                // Po výběru úrovně načteme náhodné zadání z dané úrovně
                LoadRandomPuzzleForLevel(level);

                // Spustíme herní smyčku pro právě vybrané zadání
                bool finished = PlayCurrentGame(level);

                // Po dohrání nabídneme volbu: pokračovat nebo skončit
                Console.WriteLine();
                Console.WriteLine("Chceš pokračovat ve hře nebo skončit?");
                Console.WriteLine("P = pokračovat (vybrat úroveň znovu), K = konec programu");
                string after = Console.ReadLine()?.ToUpper();

                if (after == "P")
                {
                    // pokračujeme hlavní smyčkou a uživatel znovu vybere úroveň
                    continue;
                }
                else
                {
                    // ukončíme program
                    Console.WriteLine("Díky za hraní! Stiskni libovolnou klávesu pro ukončení...");
                    Console.ReadKey();
                    break;
                }
            }
        }

        // Metoda pro výběr úrovně hry
        static int ChooseLevel()
        {
            while (true)
            {
                Console.WriteLine("Vyber úroveň obtížnosti:");
                Console.WriteLine("1 - Velmi snadná (více nápověd)");
                Console.WriteLine("2 - Snadná");
                Console.WriteLine("3 - Střední");
                Console.WriteLine("4 - Těžká (méně nápověd)");
                Console.Write("Zadej číslo úrovně (1-4): ");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int lvl) && lvl >= 1 && lvl <= 4)
                {
                    // Vracíme index úrovně 0..3
                    return lvl - 1;
                }

                Console.WriteLine("Neplatný výběr úrovně. Zkus to znovu.");
            }
        }

        // Hlavní herní smyčka pro právě načtené zadání
        // Vrací true pokud hráč dohrál (vyplnil pole)
        static bool PlayCurrentGame(int currentLevel)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== SUDOKU ===");
                Console.WriteLine($"Úroveň: {currentLevel + 1}");
                PrintBoard();

                if (IsFull())
                {
                    // Pozor: IsFull kontroluje pouze, že jsou všechna pole vyplněná.
                    // Pokud chceš i kontrolu správnosti, lze přidat další validaci.
                    Console.WriteLine("\nGratulace! Vše je vyplněno.");
                    return true;
                }

                Console.WriteLine("\nZadej: 'řádek sloupec číslo' (např. 1 2 3) (0 = smazat)");
                Console.WriteLine("R = restart (nové zadání stejné úrovně), L = změnit úroveň, Q = ukončit hru");
                string input = Console.ReadLine()?.ToUpper();

                if (input == "R")
                {
                    // Restart: načteme nové náhodné zadání stejné úrovně
                    LoadRandomPuzzleForLevel(currentLevel);
                    continue;
                }
                else if (input == "L")
                {
                    // Změna úrovně: vrátíme se do výběru úrovně
                    int newLevel = ChooseLevel();
                    LoadRandomPuzzleForLevel(newLevel);
                    currentLevel = newLevel; // aktualizujeme aktuální úroveň
                    continue;
                }
                else if (input == "Q")
                {
                    // Ukončení hry (vrátí se do hlavní smyčky, kde se nabídne pokračovat/končit)
                    return false;
                }

                try
                {
                    // Rozdělení vstupu na tři části
                    string[] parts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length != 3)
                    {
                        Console.WriteLine("Neplatný vstup. Zadej tři čísla oddělená mezerou.");
                    }
                    else
                    {
                        int r = int.Parse(parts[0]) - 1;
                        int s = int.Parse(parts[1]) - 1;
                        int val = int.Parse(parts[2]);

                        // Kontrola rozsahu indexů a hodnoty
                        if (r < 0 || r >= 4 || s < 0 || s >= 4 || val < 0 || val > 4)
                        {
                            Console.WriteLine("Neplatné číslo řádku/sloupce/čísla. Řádky a sloupce 1-4, čísla 1-4 (0 = smazat).");
                        }
                        else if (isFixed[r, s])
                        {
                            Console.WriteLine("Původní čísla nelze měnit!");
                        }
                        else if (IsValidMove(r, s, val))
                        {
                            // Uložíme tah (0 = smazat)
                            board[r, s] = val;
                        }
                        else
                        {
                            Console.WriteLine("CHYBA: Číslo porušuje pravidla!");
                        }
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

        // Kontrola, zda je tah platný (řádek, sloupec, obě diagonály)
        static bool IsValidMove(int row, int col, int val)
        {
            if (val == 0) return true; // 0 = smazání je vždy povoleno

            // Kontrola řádku a sloupce
            for (int i = 0; i < 4; i++)
            {
                if (board[row, i] == val || board[i, col] == val)
                    return false;
            }

            // Kontrola hlavní diagonály (pokud je pozice na hlavní diagonále)
            if (row == col)
            {
                for (int i = 0; i < 4; i++)
                    if (board[i, i] == val)
                        return false;
            }

            // Kontrola vedlejší diagonály (pokud je pozice na vedlejší diagonále)
            if (row + col == 3)
            {
                for (int i = 0; i < 4; i++)
                    if (board[i, 3 - i] == val)
                        return false;
            }

            return true;
        }

        // Načte náhodné zadání pro zadanou úroveň (0..3)
        static void LoadRandomPuzzleForLevel(int level)
        {
            // Získáme seznam předpřipravených zadání pro úroveň
            List<int[,]> puzzles = GetPuzzlesForLevel(level);

            // Vybereme náhodné zadání z pětice
            int idx = rnd.Next(puzzles.Count);

            // Načteme vybrané zadání do hracího pole a označíme pevná čísla
            LoadPuzzle(puzzles[idx]);
        }

        // Načte konkrétní puzzle (4x4 matice) do board a isFixed
        static void LoadPuzzle(int[,] puzzle)
        {
            // Vymažeme předchozí stav
            Array.Clear(board, 0, board.Length);
            Array.Clear(isFixed, 0, isFixed.Length);

            // Puzzle je 4x4 pole, kde 0 = prázdné, 1-4 = pevné číslo
            for (int r = 0; r < 4; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    board[r, c] = puzzle[r, c];
                    isFixed[r, c] = puzzle[r, c] != 0;
                }
            }
        }

        // Vrací seznam 5 předpřipravených puzzle pro každou úroveň
        static List<int[,]> GetPuzzlesForLevel(int level)
        {
            // Každé puzzle je 4x4 matice. 0 = prázdné.
            // Úroveň 0 = velmi snadná (více nápověd), úroveň 3 = těžká (méně nápověd).
            // Tato zadání jsou jednoduchá a konzistentní s pravidly diagonální varianty.

            var list = new List<int[,]>();

            if (level == 0) // Velmi snadná
            {
                list.Add(new int[,] {
          {0,0,0,0},
          {0,2,0,0},
          {0,0,0,0},
          {0,0,1,0}
        });
                list.Add(new int[,] {
          {4,0,0,0},
          {0,0,0,0},
          {0,0,0,0},
          {0,0,3,0}
        });
                list.Add(new int[,] {
          {0,0,0,0},
          {0,0,0,0},
          {0,0,0,2},
          {4,0,0,0}
        });
                list.Add(new int[,] {
          {0,1,0,0},
          {0,0,0,0},
          {0,0,0,0},
          {0,0,4,0}
        });
                list.Add(new int[,] {
          {0,0,0,0},
          {0,0,0,1},
          {0,0,0,0},
          {3,0,0,0}
        });
            }
            else if (level == 1) // Snadná
            {
                list.Add(new int[,] {
          {0,1,0,0},
          {0,0,0,0},
          {2,0,0,0},
          {0,0,0,0}
        });
                list.Add(new int[,] {
          {0,0,2,0},
          {2,0,0,0},
          {0,2,0,0},
          {0,0,0,2}
        });
                list.Add(new int[,] {
          {0,0,0,1},
          {0,0,1,0},
          {0,0,3,0},
          {0,0,0,0}
        });
                list.Add(new int[,] {
          {0,1,0,0},
          {0,0,0,3},
          {0,0,2,0},
          {0,0,0,0}
        });
                list.Add(new int[,] {
          {0,0,1,0},
          {0,0,0,0},
          {3,0,0,0},
          {0,0,0,4}
        });
            }
            else if (level == 2) // Střední
            {
                list.Add(new int[,] {
          {1,0,0,0},
          {0,2,0,0},
          {0,0,0,0},
          {0,0,0,4}
        });
                list.Add(new int[,] {
          {0,0,2,0},
          {0,0,0,3},
          {1,0,0,0},
          {0,4,0,0}
        });
                list.Add(new int[,] {
          {0,0,0,0},
          {0,2,0,0},
          {0,0,3,0},
          {4,0,0,0}
        });
                list.Add(new int[,] {
          {0,0,0,1},
          {0,0,2,0},
          {0,3,0,0},
          {0,0,4,0}
        });
                list.Add(new int[,] {
          {0,0,0,0},
          {0,2,0,0},
          {0,0,0,3},
          {4,0,0,0}
        });
            }
            else // level == 3 těžká
            {
                list.Add(new int[,] {
          {0,0,0,0},
          {0,2,0,0},
          {0,0,0,0},
          {1,0,0,4}
        });
                list.Add(new int[,] {
          {0,0,0,4},
          {0,0,3,0},
          {0,2,0,0},
          {1,0,0,0}
        });
                list.Add(new int[,] {
          {4,0,0,3},
          {0,0,0,0},
          {0,0,2,0},
          {1,0,0,0}
        });
                list.Add(new int[,] {
          {1,0,0,4},
          {0,2,0,0},
          {0,0,0,0},
          {0,0,0,3}
        });
                list.Add(new int[,] {
          {4,0,0,1},
          {0,0,0,0},
          {0,3,0,0},
          {0,0,0,2}
        });
            }

            return list;
        }

        // Vykreslení hrací plochy s barevným zvýrazněním diagonál
        static void PrintBoard()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    // Zvýraznění diagonál (magenta)
                    if (i == j || i + j == 3)
                        Console.ForegroundColor = ConsoleColor.Magenta;

                    // Pokud je 0, vypíšeme tečku jako prázdné pole
                    Console.Write(board[i, j] == 0 ? ". " : board[i, j] + " ");
                    Console.ResetColor();
                }
                Console.WriteLine();
            }
        }

        // Kontrola, zda je celé pole vyplněné (neověřuje správnost řešení)
        static bool IsFull()
        {
            foreach (int i in board)
                if (i == 0) return false;

            return true;
        }
    }
}