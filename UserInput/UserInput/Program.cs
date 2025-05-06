using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserInput
{


    class Program
    {
        static void Main(string[] args)
        {
            string username; 
            int age;

            Console.Write("Wie heißt Du?: "); // Write statt WriteLine --> ohne Zeilenumbruch
            username = Console.ReadLine();

            Console.Write("Wie alt bist Du?: ");
            age = Convert.ToInt32(Console.ReadLine()); //Convert ist eine Klasse (aus namespace System, genau wie Console), toInt ist eine Methode dieser Klasse 

            Console.WriteLine("Schalömsche, " + username + "! Ich hoffe, Du freust Dich auf Deinen " + (age + 1) + ". Geburtstag :)");
            Console.Read();
        }
    }

}
