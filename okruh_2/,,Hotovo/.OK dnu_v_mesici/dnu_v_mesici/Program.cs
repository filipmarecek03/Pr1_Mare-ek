using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Console.Write("Zadej poradove cislo měsíce: ");
        int poradove = int.Parse(Console.ReadLine());
        string nazev = "";

        switch (poradove)
        {
            case 1:
                nazev = "Leden";
                break;
            case 2:
                nazev = "Únor";
                break;
            case 3:
                nazev = "Březen";
                break;
            case 4:
                nazev = "Duben";
                break;
            case 5:
                nazev = "Květen";
                break;
            case 6:
                nazev = "Červen";
                break;
            case 7:
                nazev = "Červenec";
                break;
            case 8:
                nazev = "Srpen";
                break;
            case 9:
                nazev = "THE BEST MONTH ZAAAŘIII";
                break;
            case 10:
                nazev = "Říjen";
                break;
            case 11:
                nazev = "Lispopad";
                break;
            case 12:
                nazev = "Prosinec";
                break;
            
                break;
            default:
                Console.WriteLine("Hodnota není platná");
                break;

        }
        if (nazev != "")
            Console.WriteLine(nazev);
    }
}