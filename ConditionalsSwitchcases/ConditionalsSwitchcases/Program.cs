using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalsSwitchcases
{

    // Erweiterung von Projekt HelloWorld um Conditionals und Switch Cases
    class Program
    {
        static void Main(string[] args)   //
        {

            // Variablendeklaration
            string name;
            int alter;


            // Variableninitialisierung: <Bezeichner> = <Wert>;   
            name = "Susann";
            alter = 49;


            // Vergleichsoperatoren: 
            // == != < > <= >= 
            // Kombinationsoperatoren:
            // if (cond1 &&/|| cond2)


            // Befehle
            Console.WriteLine("Schalömsche!");
            Console.WriteLine("Mein Name ist " + name + ".");           //Wert von Variable name wird der Methode WriteLine() übergeben
            Console.WriteLine("Ich bin " + alter + " Jahre alt.");


            //if conditionals
            if (alter >= 18) //bedingung
            {
                Console.WriteLine("Ich bin volljährig.");     // dann
            }
//          else if ()
//          {
//
//          }
            else
            {
                Console.WriteLine("Ich bin minderjährig."); // sonst
            }

            // Boolean allg.  
            Console.WriteLine("Boolean-Ausgabe für 5> 10: " + (5 > 10)); // Ausgabe: "False"

            // Switch cases
            int tag = 3;
            Console.WriteLine("Switch Case Wochentag:");
            switch (tag)    //Variablenübergabe
            {
                case 1:     //Falldefinition
                    Console.WriteLine("Montag");
                    break;  //Herausspringen aus Fallblock
                case 2:
                    Console.WriteLine("Dienstag");
                    break;
                case 3:
                    Console.WriteLine("Mittwoch");
                    break;
                default:
                    Console.WriteLine("Ungültiger Tag");
                    break;
            }


            Console.Read();
        }
    }
}