using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arrays
{


    class Program
    {
        static void Main(string[] args)
        {
            //1D Arrays

            string[] names = new string[] { "Felinebiene", "Mamakatze", "Papahase" };
            int[] ages = new int[] { 9, 49, 44 };

            int[] agesV2 = new int[3];  //getrennt: 1. Anzahl festlegen
            agesV2[0] = 9;               //          2. befüllen
            agesV2[1] = 49;
            agesV2[2] = 44;

            Console.WriteLine("Schalömsche, " + names[1] + "! Ich hoffe, Du freust Dich auf Deinen " + (ages[1] + 1) + ". Geburtstag :)");



            //2D Arrays

            int[,] ageHeight = new int[3, 2]; // Anzahl Zeilen, Anzahl Spalten; oder evtl. andersrum (macht bei Arrays evtl. keinen Unterschied?)

            ageHeight[0, 0] = 9;
            ageHeight[1, 0] = 49;
            ageHeight[2, 0] = 44;
            ageHeight[0, 1] = 126;
            ageHeight[1, 1] = 155;
            ageHeight[2, 1] = 185;

            Console.WriteLine("Schalömsche, Du bist " + ageHeight[1,0] + " Jahre alt und " + ageHeight[1,1] + "cm groß.");

            Console.WriteLine(ageHeight);
            
            
            
            
            
            Console.Read();







        }
    }

}
