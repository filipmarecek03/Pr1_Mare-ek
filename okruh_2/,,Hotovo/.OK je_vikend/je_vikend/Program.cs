using System;

class MainClass
{
    public static void Main(string[] args)
    {
        // sem přijde váš kód      
        Console.WriteLine("Zadej číslo odpovídající dni v týdnu: ");
        int cislo = int.Parse(Console.ReadLine());
        string nazev = "";

        switch (cislo)
        {
            case 1:
                nazev = "není víkend";
                break;
            case 2:
                nazev = "není víkend";
                break;
            case 3:
                nazev = "není víkend";
                break;
            case 4:
                nazev = "není víkend";
                break;
            case 5:
                nazev = "není víkend";
                break;
            case 6:
                nazev = "Jupiii, je víkend!";
                break;
            case 7:
                nazev = "Jupiii, je víkend!";
                break;
            default:
                Console.WriteLine("Hodnota není platná");
                break;

        }
        if (nazev != "")
            Console.WriteLine(nazev);
    }
}
