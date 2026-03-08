

namespace Florbal_shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> florbalShop = new List<string>();
            bool konec = false;
            int pocet = 0;

            while (!konec)
            {
                
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n======VÝTEJ VE FLORBAL-SHOP======\n");
                Console.ResetColor();
                Console.WriteLine("1. Seznam holý");
                Console.WriteLine("2. Přidat produkt");
                Console.WriteLine("3. Smazat produkt");
                Console.WriteLine("4. Košík");
                Console.WriteLine("5. Zaplatit");
                Console.WriteLine("6. KONEC");
                string volba = Console.ReadLine();
                switch (volba)
                {
                    case "1":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n=======SEZNAM HOLÝ=======\n");
                        Console.ResetColor();
                        Console.WriteLine("Fat Pipe Raw Concept");
                        Console.WriteLine("Salming Hawk Tourlite");
                        Console.WriteLine("Oxdog Hyperlight");
                        Console.WriteLine("Zone Floorball Harder Airlight");
                        Console.WriteLine("Unihoc Epic Top Light");
                        Console.WriteLine("Exel Shock Pro");
                        Console.WriteLine("Salming Flow Powerlite");
                        Console.WriteLine("Oxdog Ultimate Light");
                        Console.WriteLine("Fat Pipe G-Series");
                        Console.WriteLine("Unihoc Iconic Carbskin");

                        break;
                    case "2":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Košík může obsahovat maximálně 10 věcí");
                        Console.ResetColor();
                        if (pocet >= 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Košík je plný");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ResetColor();
                            Console.Write("Co by sis rád koupil: ");
                            string novahul = Console.ReadLine();
                            florbalShop.Add(novahul);
                            Console.WriteLine("Máš to v košíku");

                            pocet++;
                        }
                        break;
                    case "3":
                        Console.WriteLine("Kolikátý produkt chceš odstranit");
                        Console.WriteLine("První produkt = číslo 0");
                        if (florbalShop.Count == 0)
                        {
                            Console.WriteLine("(prázdný košík)");
                        }
                        else
                        {
                            for (int i = 0; i < florbalShop.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {florbalShop[i]}");
                            }
                        }

                        int odstranit = 0;
                        int.TryParse(Console.ReadLine(), out odstranit);
                        florbalShop.RemoveAt(odstranit);
                        pocet = pocet - 1;
                        Console.WriteLine("Odstraneno");
                        break;
                        
                    case "4":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n=======KOŠÍK=======\n");
                        Console.ResetColor();

                        if (florbalShop.Count == 0)
                        {
                            Console.WriteLine("(prázdný košík)");
                        }
                        else
                        {
                            for (int i = 0; i < florbalShop.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. {florbalShop[i]}");
                            }
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nDěkuji za nákup, že se zase vrátíš!");
                        Console.WriteLine("Zasilka příjde cuby dub");
                        Console.ResetColor();
                        konec = true;
                        break;
                    case "6":
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n Děkuji za používaní e-shopu. Doufám, že se zase vrátíš!");
                        Console.ResetColor();
                        konec = true;
                        break;

                    default:
                        Console.WriteLine("Neplatná volba, zkus to znovu.");
                        break;

                }

            }
        }
    }
}
