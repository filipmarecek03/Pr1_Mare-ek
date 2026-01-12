using System;

class MainClass
{
    //zde nic neměňte
    public static void Main(string[] args)
    {
        double[] cisla = { -1.3, 2.2, 1.5, 1.4, 2.7 };
        Console.WriteLine(PodLimitem(cisla, 1.5)); //vypíše -1.3 a 1.4 
        Console.WriteLine(PodLimitem(cisla, 1.6)); //vypíše -1.3 , 1.5 a 1.4
    }

    //zde deklarujte vaši metodu
    /*
    static double[] PodLimitem( double[]cissla, double limit)
    {
        double[] vysledek = new double[cissla.Length];
        int pozice = 0;
        for (int i = 0; i < cissla.Length; i++)
        {


            if (cissla[i] < limit)
            {
                vysledek[pozice] = cissla[i];
            }
        }
        return vysledek;
    }
    */
    static string PodLimitem(double[] cissla, double limit)
    {
        double[] vysledek = new double[cissla.Length];
        int pozice = 0;
        string vystup = "";
        for (int i = 0; i < cissla.Length; i++)
        {


            if (cissla[i] < limit)
            {
                vysledek[pozice] = cissla[i];
                pozice++;
            }
        }
        for (int i = 0;i<pozice;i++)
        {
            vystup = vystup + vysledek[i] + " ";
            
        }
        return vystup;
    }

}