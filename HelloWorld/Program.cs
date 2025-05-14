
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


            // Variablendeklaration: <Datentyp> <Bezeichner>   (camel case, beginnend mit Buchstabe)  

            string name;    // string, aus alphanumerischen Characters
            int alter;      // integer, ganzzahlig
            double größe;   // Precision 15-17 digits, vielleicht der Standard, wenn mit der Zahl gerechnet werden soll?

           
            // Variablensetting: <Bezeichner> = <Wert>; heißt auch value assignment  
            name = "Susann";
            alter = 49;
            größe = 1.55;


            // Variableninitialisierung = beides zusammen
            float beispielFloat = 1.55F;    // Precision nur 6-9 digits, am besten nur für feste Dezimalzahlen, mit denen nicht gerechnet wird
            decimal beispielDecimal = 1.55M;  // Precision 28-29 digits, lt Microsoft Learn der Standard, wenn mit der Zahl gerechnet werden soll 
            bool istWeiblich = true;    // Boolean True oder False
            char rating = 'B';          // einzelner alphanumerischer Character, in single quotes
            //...




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
