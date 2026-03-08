using System;

class MainClass
{
    //tuto mětodu neměňte
    public static void Main(string[] args)
    {
        Console.WriteLine(JeVNorme(35.1, 33, 3.5)); //true
        Console.WriteLine(JeVNorme(35.1, 33, 1.5)); //false
        Console.WriteLine(JeVNorme(11.8, 13, 1.3)); //true
    }

    //zde napište vaši metodu
    static bool JeVNorme(double x, int y, double z)
    {
        if ((y+z>x))
        {
            return true;
        }
        else
        {
            return false;
        } 
    }
}