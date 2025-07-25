﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    // Loops: While, Do While, For, For Éach

    class Program
    {
        static void Main(string[] args)   //
        {
            int zahl;
            int[] ages;         //Array deklariert


            // while Loop
            Console.WriteLine("while Loop");
            zahl = 0;
            while (zahl <= 10) 
            {
                Console.WriteLine(zahl);
                zahl += 1;
            }


            // do while Loop --> dann wird der Code wenigstens einmal ausgeführt, auch wenn die Bedingung nicht erfüllt ist.
            Console.WriteLine("do while Loop");
            zahl = 20;
            do
            {
                Console.WriteLine(zahl);
                zahl += 1;
            } while (zahl <= 10);


            // for Loop ohne Array
            Console.WriteLine("for Loop");
            for (int i = 0; i <= 10; i++)           // Zähler initialisiert; Bedingung zum Weitermachen (ähnlich while); Zähler um 1 raufsetzen (äquivalent i += 1)
            {
                Console.WriteLine(i);                
            }


            // for Loop mit Array
            Console.WriteLine("for Loop mit Array");
            ages = new int[]{9, 49, 44};            //Array initialisiert
            for (int i = 0; i < ages.Length; i++)   //Length = Eigenschaft der Array-Klasse       
            {
                Console.WriteLine(ages[i]);
            }


            // foreach Loop                            //Vorteil: Klammer kürzer; Nachteil: z.B. kein Zugriff auf [i-1], keine Option, den Wert eines Eintrags zu ändern
            Console.WriteLine("foreach Loop");
            ages = new int[] { 9, 49, 44 };            //Array initialisiert //noch kürzer: int[] ages = [ 9, 49, 44]
            foreach (int a in ages)                    //a = Wert in Array       
            {
                Console.WriteLine(a);
            }

            Console.Read();


            // MSLearn foreach loop exercise
            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
            foreach (int i in inventory)
            {
                sum += i;
                bin++;
                Console.WriteLine($"Bin {bin} = {i} items (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");

            Console.Read();

            // MSLearn foreach loop challenge
            string[] orderIDs = [ "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" ];
            foreach (string id in orderIDs)
            { 
                if (id.StartsWith('B'))     // StartsWith() = string method
                {
                    Console.WriteLine(id);
                }
            }
        }


         
    }
}