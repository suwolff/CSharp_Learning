
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    //Hello World + Variablen & Operatoren


    class Program
    {
        static void Main(string[] args)
        {
         

            // Variablendeklaration: <Datentyp> <Bezeichner>    
            string name;
            int alter;
            double größe;
            //decimal
            //bool (True oder False, z.B. bool istWeiblich)
            //...

            // Variableninitialisierung: <Bezeichner> = <Wert>;   
            name = "Susann";
            alter = 49;
            größe = 1.55;



            // Operatoren Bsp.
            int zeit_bis_100 = 100 - alter; // hier Var-Deklaration und -Initialisierung auf einmal; geht immer.
                                            // + - * / %


            // Befehle
            Console.WriteLine("Schalömsche!");
            Console.WriteLine("Mein Name ist " + name + ".");           //Wert von Name wird der Methode WriteLine übergeben
            Console.WriteLine("Ich bin " + alter + " Jahre alt und " + größe + "m groß.");
            Console.WriteLine("Es sind noch " + zeit_bis_100 + " Jahre bis zu meinem 100. Geburtstag."); //Operatoren könnten auch direkt hier rein 
            Console.Read();
        }
    }
}
