using System;

class MainClass 
{
    public static void Main(string[] args)
    {
       
        double cislo1 = 1.3;
        double cislo2 = 4.6;
        double cislo3 = -3.3;
        Console.WriteLine( cislo1 + " " + cislo2 + " " +  cislo3);
        double maximum = Max(cislo1, cislo2, cislo3);//sem doplňte zavolání metody
        Console.WriteLine($"Největší ze zadaných čísel je {maximum}.");
    }
    private static double Max (double c1, double c2, double c3)
    {

        if (c1 >= c2 && c1 >= c3)
        {
            return c1;
        }
        else if (c2 >= c1 && c2 >= c3)
        {
            return c2;
        }
        else
        {
            return c3; // Pokud není největší c1 ani c2, musí to být c3
        }
    }
    //sem napište deklaraci metody
}