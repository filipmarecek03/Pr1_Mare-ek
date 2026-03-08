using System;
using System.Collections.Generic; // Potřebujeme pro práci s Listem

namespace TodoListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vytvoříme dynamický seznam úkolů
            List<string> seznamUkolu = new List<string>();
            bool konec = false;

            while (!konec)
            {
                Console.WriteLine("\n--- TVŮJ TO-DO LIST ---");
                Console.WriteLine("1. Přidej úkol");
                Console.WriteLine("2. Splnit úkol (smazat první)");
                Console.WriteLine("3. Výpis úkolů");
                Console.WriteLine("4. KONEC");
                Console.Write("Vyber možnost: ");

                string volba = Console.ReadLine();

                switch (volba)
                {
                    case "1":
                        Console.Write("Napiš text úkolu: ");
                        string novyUkol = Console.ReadLine();
                        Console.Write("Priorita (vysoka = začátek / nijaká = konec): ");
                        string priorita = Console.ReadLine().ToLower();

                        if (priorita == "vysoka")
                        {
                            // Vloží na index 0 (začátek)
                            seznamUkolu.Insert(0, novyUkol);
                        }
                        else
                        {
                            // Přidá klasicky na konec
                            seznamUkolu.Add(novyUkol);
                        }
                        
                        break;

                    case "2":
                        if (seznamUkolu.Count > 0)
                        {
                            Console.WriteLine($"Splněno a smazáno: {seznamUkolu[0]}");
                            seznamUkolu.RemoveAt(0); // Smaže první prvek v seznamu
                        }
                        else
                        {
                            Console.WriteLine("Seznam je prázdný, není co plnit.");
                        }
                        break;

                    case "3":
                        Console.WriteLine("\nAktuální seznam úkolů:");
                        if (seznamUkolu.Count == 0)
                        {
                            Console.WriteLine("(žádné úkoly)");
                        }
                        else
                        {
                            for (int i = 0; i < seznamUkolu.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {seznamUkolu[i]}");
                            }
                        }
                        break;

                    case "4":
                        konec = true;
                        Console.Clear();
                        Console.WriteLine("\nAhoj příště!");
                        

                        break;

                    default:
                        Console.WriteLine("Neplatná volba, zkus to znovu.");
                        break;
                }
            }
        }
    }
}