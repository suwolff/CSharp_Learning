
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    //Hello World
    //  + Variablen (Datentypen, Deklaration, Intitialisierung)
    //  + Basic String Formatting
    //  + Basic Number Operations



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
            float beispielFloat = 1.55f;    // Precision nur 6-9 digits, am besten nur für feste Dezimalzahlen, mit denen nicht gerechnet wird
            decimal beispielDecimal = 1.55m;  // Precision 28-29 digits, lt Microsoft Learn der Standard, wenn mit der Zahl gerechnet werden soll 
            bool istWeiblich = true;    // Boolean True oder False
            char rating = 'B';          // einzelner alphanumerischer Character, in single quotes
                                        //...

            // Man kann bei Initialisierung auch var statt <Datentyp> schreiben und durch den assignten Wert den Datentyp implizit bestimmen lassen
            var beispielFloat2 = 1.95f;    
            var gruss = "Schalömsche";
            var grussName = "Feline";



            // Operatoren Bsp.
            int zeitBis100 = 100 - alter;
            // + - * / %
            decimal alterDekaden = 49m / 10;                                    // vorsicht bei division: Type decimal, mindestens einer der Operanden muss auch decimal sein
            decimal quotientAusInt = (decimal)alter / (decimal)zeitBis100;    // bei Berechnung aus ints: Data type cast = temporäre Konversion zu decimal

            // Compound Assignment Operators:
            // += -= *= ++ --
            // verändern den Wert einer Variablen; alter += n --> Addition n zu alter, allter ++ --> Addition 1 zu alter 
            // wichtig in increments & decrements in loops
            // wichtig: RF --> erst wird der aktuelle Wert abgerufen, dann erhöht. Dadurch z.B. in ConsoleWrite Ausgabe vor Erhöhung. Möglich: Umdrehen, ++alter
            int antwort = 42;
            antwort += 7;       // antwort = 49
            antwort++;          // antwort = 50
            antwort *= 2;       // antwort = 100
            



            // Befehle
            Console.WriteLine("Schalömsche!");
            Console.WriteLine("Mein Name ist " + name + ".");           //Wert von Name wird der Methode WriteLine übergeben; +: string concatenation
            Console.WriteLine("Ich bin " + alter + " Jahre alt und " + größe + "m groß."); //Implicit type conversion: alter & größe werden TEMPORÄR in Strings umgewandelt.
            Console.WriteLine("Es sind noch " + zeitBis100 + " Jahre bis zu meinem 100. Geburtstag."); //Operatoren könnten auch direkt hier rein, dann aber mit Klammern! 
            Console.WriteLine($"Tschüssi von {name}!"); //ökonomischere Art zu schreiben: $ vor den String, Variablen mit {} direkt in den String = String interpolation
            Console.WriteLine(alterDekaden);
            Console.WriteLine(quotientAusInt);
            Console.Read(); //führt zu warten auf Enter


            //Character escape sequences: \
            Console.WriteLine("Hello, \"World!\"");
            Console.WriteLine("Hello,\nthis is a new line.");
            Console.WriteLine("Hello,\tthis is a new tab.");
            Console.WriteLine("Hello, this is a backslash: \\.");

            //Unicode escape characters: \u
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!"); // Kon'nichiwa World (funzt nicht in jeder Ausgabe, UTF-16)


            //Verbatim string literal: behält alles an Leerzeichen, Zeilenumbrüchen und Backslashes: @
            Console.WriteLine(@"Hello     , these\are\a\few\backslashes."); //gut wenn man einen Pfad ausgeben muss.

            //String concatenation: +
            Console.WriteLine(gruss + " " + grussName + "!");

            //String interpolation: $
            Console.WriteLine($"{gruss} {grussName}!");

            //Operationen in string concatenation:
            int n1 = 7;
            Console.WriteLine("7+1 ist " + (n1 + 1)); //ohne Klammern wird 71 ausgegeben
            //Operationen in string interpolation:
            Console.WriteLine($"7+1 ist {n1 + 1}"); 
            Console.WriteLine($"7+1 ist {7 + 1}"); //es muss also keine Variable in den {} stehen

            //Kombi aus verbatim literals und string interpolation: $@
            Console.WriteLine($@"{gruss} {grussName}, hier sind drei Backslashes!: \\\");
        }
    }
}
