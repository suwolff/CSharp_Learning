using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;


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


            // if conditionals
            if (alter >= 18) // bedingung
            {
                Console.WriteLine("Ich bin volljährig.");     // dann
            }
//          else if ()
//          {
//              ...
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


            // Exercise MIcrosoft Learn Würfelspiel
            // If any two dice you roll result in the same value, you get two bonus points for rolling doubles.
            // If all three dice you roll result in the same value, you get six bonus points for rolling triples.
            // If the sum of the three dice rolls, plus any point bonuses, is 15 or greater, you win the game.Otherwise, you lose.


            Random dice1 = new();
            Random dice2 = new();
            Random dice3 = new();
                    
            int roll1 = dice1.Next(1, 7);
            int roll2 = dice1.Next(1, 7);
            int roll3 = dice1.Next(1, 7);

            int sumRolls = roll1 + roll2 + roll3;
            
            int bonus;
            int total;

            if (roll1 == roll2 && roll1 == roll3)
                bonus = 6;                                                  // wenn nur 1 Statement von der Condition kontrolliert wird wie hier, kann man die curly braces weglassen.
            else if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
                bonus = 2;
            else
                bonus = 0;

            total = sumRolls + bonus;

            Console.WriteLine($"roll1: {roll1}\nroll2: {roll2}\nroll3: {roll3}\nsum of rolls: {sumRolls}\nbonus: {bonus}\ntotal: {total}");

            if (total >= 15)
                Console.WriteLine("Du hast gewonnen!");
            else
                Console.WriteLine("Leider verloren :(");

            Console.Read();


            //Challenge Microsoft Learn:

            Random random = new();
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            // Your code goes here

            Console.WriteLine(daysUntilExpiration);

            if (daysUntilExpiration <= 0)
            {
                Console.WriteLine("Subscription expired!");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Subscription expires within a day!");
                discountPercentage = 20;
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Subscription expires in {daysUntilExpiration} days!");
                discountPercentage = 10;
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Subscription will expire soon!\nRenew now!");
            }


            if (discountPercentage > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}!");
            }



        }
    }
}