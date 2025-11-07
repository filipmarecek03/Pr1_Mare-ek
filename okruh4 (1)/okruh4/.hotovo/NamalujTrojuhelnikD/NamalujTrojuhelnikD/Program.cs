using System;

class MainClass
{
    public static void Main(string[] args)
    {


        //dál pokračujte vy
       
        
            Console.Write("Zadej výšku trojúhelníku: ");
            int vyska = int.Parse(Console.ReadLine());

            for (int i = 0; i < vyska; i++)
            {
                int pocetHvezd = 2 * i + 1;
                int mezery = vyska - i - 1;

                // Vypíše mezery vlevo
                Console.Write(new string(' ', mezery));
                // Vypíše hvězdičky
                Console.WriteLine(new string('#', pocetHvezd));
            }
        }
    }

