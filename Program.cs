using System;
using System.Diagnostics;

namespace Exceptions
{
    internal class Program
    {
        int yes = 1;
        int no = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben sie die Farbe ihres Bugattis ein R=");
            string r = Console.ReadLine();
            Console.WriteLine("Bitte geben sie die Farbe ihres Bugattis ein G=");
            string g = Console.ReadLine();
            Console.WriteLine("Bitte geben sie die Farbe ihres Bugattis ein B=");
            string b = Console.ReadLine();
            Console.WriteLine("Mögen sie Loona? ( 1 für ja 0 für nein )");
            string h = Console.ReadLine();


            try
            {
                int Bugatti_Veron = Convert.ToInt32(r) + Convert.ToInt32(g) + Convert.ToInt32(b);
                Console.WriteLine("Die Summe ist" + Bugatti_Veron);
            }
            catch
            {
                Console.WriteLine("Falswe Antwourt deine Köpung findet Morgen statt uwu");
            }
            if (Convert.ToInt32(h) == 0)
            {
                Console.WriteLine("mögen sie Anthropomorphische Tiere (Beispiel Donald Duck)");
                string i = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("schlecht");
            }
        }
            
    }
}

