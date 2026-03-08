using System;

class MainClass
{
    //tuto metodu neupravujte
    public static void Main(string[] args)
    {
        string text = Prijde("Karel"); //zde uložím návratovou hodnotu do proměnné
        Console.WriteLine(text);
    }

    public static string Prijde(string jmeno)
    {
        string veta = "Přijde také " + jmeno;      
        return veta;

    }
}