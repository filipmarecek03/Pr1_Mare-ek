

namespace Zacatkylist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vyber = int.MaxValue;
            
            List<string> studenti = new List<string>();
            List<int> znamky = new List<int>();
            int pozice;
            do
            {
                vyber = VypisMenu();
              
                switch (vyber)
                {
                    case 1:
                       // Console.Clear();
                        Console.WriteLine("Zadej jméno studenta: ");
                        string jmeno = Console.ReadLine();
                        studenti.Add(jmeno);
                        Console.WriteLine("Zadej mi známku:");
                        int znamka;
                        while ((int.TryParse(Console.ReadLine(), out znamka) == false) || (znamka < 0) || (znamka > 5))
                        {
                            Console.WriteLine("Ty joudo nepiš tam blbosti");
                        }
                        znamky.Add(znamka);
                        break;
                    case 2:
                        // Console.Clear();
                        Console.WriteLine("Zadej jméno studenta: ");
                        string hledane = Console.ReadLine();
                        if (studenti.Find(x => x == hledane) != null)
                        {
                            pozice = studenti.IndexOf(hledane);
                            int zn = znamky[pozice];
                            Console.WriteLine("Student nalezen na pozici {0} a má známku {1}.",pozice,zn);
                        }
                        else
                            Console.WriteLine("Student nenalezen");
                        break;
                    case 3:
                        Console.WriteLine("Zadej jméno studenta pro odstranění: ");
                        string odeber = Console.ReadLine();
                        pozice = studenti.IndexOf(odeber);
                        if (studenti.Remove(odeber)) {
                            znamky.RemoveAt(pozice);
                            Console.WriteLine("Student {0} byl odstraněn.", odeber);
                        }
                        else
                        {
                            Console.WriteLine("Student {0} nebyl odstraněn.", odeber);
                        }    


                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("SEZNAM STUDENTŮ");
                        int p = 0;
                        foreach(string s in studenti)
                        { Console.WriteLine("{0} se známkou {1}", s, znamky[p]); 
                        p++;
                        }
                        Console.WriteLine("Pokud chceš skončit napiš P");
                        string end = Console.ReadLine().ToUpper();
                        if (end == "P")
                        {
                            vyber = 5;
                            break;
                        }
                        else
                            Console.Clear();
                        continue;
                        
                       
                }
            } while (vyber != 5);







                /*List<int> znamky = new List<int>();
                int znamka = int.MaxValue;
                do
                {
                    Console.WriteLine("Zadej mi známku:");
                    while((int.TryParse(Console.ReadLine(),out znamka) == false) || (znamka < 0) || (znamka >5))
                    {
                        Console.WriteLine("Ty joudo nepiš tam blbosti");
                    }
                    if(znamka !=0)
                    znamky.Add(znamka);
                } while (znamka != 0);
                VypisZnamky(znamky);*/

            }
        public static void VypisZnamky(List<int> z)
        {
            /* for(int i = 0; i<z.Count;i++)
             {
                 Console.WriteLine("Hodnota znamky je: " + z[i]);
             }*/
            foreach (int hodnota in z)
            {
                Console.WriteLine("Hodnota znamky je: {0}", hodnota);
            }
        }
        public static int VypisMenu()
        {
            int volba = int.MaxValue;
            do
            {


                Console.WriteLine("Student App");
                Console.WriteLine("1. přidej studenta");
                Console.WriteLine("2. vyhledej studenta");
                Console.WriteLine("3. odeber studenta");
                Console.WriteLine("4. vypis studenty");
                Console.WriteLine("5. KONEC");

                while ((int.TryParse(Console.ReadLine(), out volba) == false)) 
                {
                    Console.WriteLine("Ty joudo nepiš tam blbosti");
                }
            } while ((volba < 1) || (volba > 5));
           
            return volba;
        }
    }
}
