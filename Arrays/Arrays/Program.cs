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

            string[] names = new string[] { "Felinebiene", "Mamakatze", "Papahase" };   // INITIALIZE (alte Version)
            int[] ages = new int[] { 9, 49, 44 };

            int[] agesV2 = new int[3];  //getrennt: 1. Anzahl festlegen DECLARE
            agesV2[0] = 9;              //          2. befüllen         SET / ASSIGN VALUES
            agesV2[1] = 49;
            agesV2[2] = 44;

            int[] agesV3 = { 9, 49, 44 };   // (auch alte Version)
            int[] agesV4 = [ 9, 49, 44 ];   // INITIALIZE (neue Version lt MSLearn)

            Console.WriteLine($"Schalömsche, {names[1]}! Ich hoffe, Du freust Dich auf Deinen {agesV4[1] + 1}. Geburtstag :)");
            Console.WriteLine($"In Deiner Familie sind {names.Length} Personen.");



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
