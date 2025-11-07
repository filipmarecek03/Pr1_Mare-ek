using System;

class MainClass
{

    public static void Main(string[] args)
    {
      
        int hodiny = 5;
        int minuty = 42;
        Console.WriteLine("Autobusi jezdí v: " + hodiny + ":" + minuty);
        for (int i = 1; i < 20; i++)
        {
            if (minuty + 13 < 60)
            {
                minuty = minuty + 13;
                Console.WriteLine(hodiny + ":" + minuty);
            }
            else
            {
                minuty = 60 - (minuty + 13);
                hodiny = hodiny + 1;
                minuty = minuty * (-1);

                Console.WriteLine(hodiny + ":" + minuty);
            }
            }
    }
}