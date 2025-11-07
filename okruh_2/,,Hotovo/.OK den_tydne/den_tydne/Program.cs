using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // sem přijde váš kód      
        Console.Write("Zadej poradove cislo dne: ");
        int poradove = int.Parse(Console.ReadLine());
        string nazev = "";

        switch (poradove)
        {
            case 1:
                nazev = "pondělí";
                break;
            case 2:
                nazev = "úterý";
                break;
            case 3:
                nazev = "středa";
                break;
            case 4:
                nazev = "čtvrtek";
                break;
            case 5:
                nazev = "pátek";
                break;
            case 6:
                nazev = "sobota";
                break;
            case 7:
                nazev = "neděle";
                break;
            default:
                Console.WriteLine("Hodnota není platná");
                break;
                
        }
        if (nazev != "")
            Console.WriteLine(nazev);
        }
}