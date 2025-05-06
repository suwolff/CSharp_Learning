
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    // Erweiterung HelloWorld um Methoden
    // entsprechen Funktionen in der nicht-OOP-Welt!
    // Mit Methoden kann man Code einmal schreiben und dann wiederverwenden
    // Name, Parameterliste, Codeblock, manchmal Rückgabewert
    // Mit Name(Par1, Par2, ...) kann die Methode ausgeführt werden
    // Durch Methoden kann der Code in kleine Abschnitte unterteilt werden, übersichtlicher, wartbarer = Kapselung?

    class Program 
    {
        static void Main(string[] args)  
        {
            MultipleGreetUser("Schalömsche", "Haselmaus", 3);

            double area = RectArea(3.9, 4.0);
            Console.WriteLine("Die Fläche Deines Zimmers beträgt " + area + "qm.");

            int thisage = 9;
            if (CheckAgeOver(thisage, 18))
                Console.WriteLine("Du bist volljährig.");
            else
                Console.WriteLine("Du bist minderjährig. Noch " + (18 - thisage) + " Jahre!");

                MultipleGreetUser("Tschüssi", "Haselmaus", 1);
        }


        // Methode ohne Rückgabewert: void
        // Verweise zählen, wie oft die Methode in der Main-Methode verwendet wird.
        // static: damit die Methode nicht nur über eine Objektinstanz aufgerufen werden kann.
        static void MultipleGreetUser(string greeting, string username, int count)      //Durch Definition als Parameter wird die Variable auch deklariert.
        {
            while (count > 0)
            {
                Console.WriteLine(greeting + ", " + username + "!");
                count -= 1;
            }
        }

        // Methode mit Rückgabewert double
        static double RectArea(double width, double height)
        {
            return width * height;
        }

        // Methode mit Rückgabewert bool
        static bool CheckAgeOver( int age, int min)
        {
           return age > min;
        }
    }
}