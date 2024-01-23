using System.ComponentModel.Design;
using System.Linq.Expressions;

namespace Try_ctach_finally_ausprobieren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nicht_Kopiert();
        }
        static void Rechnen_Kopiert()
        {
            string zahl = "Ja";
            string zahlen = "Nein";

            try
            {
                int Ergebnis = Convert.ToInt32(zahl) / Convert.ToInt32(zahlen);
                Console.WriteLine("Das Ergebnis ist:" + Ergebnis);
                
            }

            catch
            {
                
                Console.WriteLine("Keine korrekte Angabe: entweder Buchstaben, Sonderzeichen, zu hohe Zahlen oder durch 0 geteilt.");
            }
        }
        static void Nicht_Kopiert()
        {
            try
            {
                Console.WriteLine("Schreibe: Nein");
                string Land = Console.ReadLine();
                int Meer = 0;
                if (Land == "Nein")
                {
                    Meer = 1;
                }
                Land = "Nein";
                if (Meer == 1)
                { 
                    Console.WriteLine("Strike ´Wii music starts playing´");
                } else if (Meer != 1) 
                {
                    throw new Exception();
                }
            }  
            catch (Exception)
            {
                Console.WriteLine("Schreib gefälligst Nein!");
            }
            finally
            {
                Console.WriteLine("Dieses Programm mit Enter oder irgendeiner anderen Taste beenden");
            }
        }
        static void Mandalorianer()
        {

        }   
    }
}
