using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP
{

    // C# = vollständig objektorientiert
    // OO = Programmierparadigma = Denkweise
    // Objekte einer Klasse haben die selben Eigenschaften, belegt mit unterschiedlichen Werten
    // Objekte der Klasse Array haben die Eigenschaft Length
    // Objekte können Methoden haben und für sich selbst aufrufen (= Codeblöcke, die über ihren Namen immer wieder aufgerufen werden können)
    // Objekte können über Methoden miteinander interagieren
    // Klassen = Baupläne für Objekte, beschreiben die Eigenschaften und Methoden der Objekte
    // Klasse Haus anlegen, Eigenschaften und Methoden definieren
    // Vererbung von Klassen: Erweiterung, die die Eigenschaften und Methoden der Basisklasse erbt
    // Wenn die Klasse einmal definiert ist, kann man davon Objekte erzeugen
    // Konstruktor = eine Methode, die beim Erstellen eines Objekts aufgerufen mit new wird (Vorgaben für die Parameter)
    // Eigenschaften = besondere Art von objektbeschreibenden Variablen, deren Wert mit get-Methode gelesen und mit set-Methode überschrieben wird
    // Eigenschaften dienen der Kapselung von Daten
    // Datenkapselung zur Gruppierung und zum Schutz der Daten eines Objekts vor äußeren Zugriffen (private statt public)

    

    class Program
    {
        static void Main(string[] args)
        {
            //Objekte erzeugen

            Person person1 = new Person(1, "Feline", 9);  //kürzer dank Konstruktor; Parameter kommen direkt in die Klammer
            Person person2 = new Person(2, "Claas", 44);
            Person person3 = new Person(3, "Lotti", 0);

            // AR_Kat1 Patient01234_Datensatz56789 = new AR_Kat1(<patNr>, <datensatzNr>, <minAlter>, <maxAlter>, <erlaubteDiagnosen>, <ausgeschlosseneLeistungen>);

           /*
           Person person1 = new Person();   //länger ohne Konstruktor, getrennt: 1. Anlage
           person1.Id = 1;                  //                                   2. Eigenschaften
           person1.Name = "Feline";
           person1.Alter = 9;
           */


            //Methoden aufrufen

            person1.Geburtstagsgruß("Mama");    
            person2.Geburtstagsgruß("Susann");
            person3.Geburtstagsgruß("Feline & Susann & Claas");

           
            Console.Read();

        }
    }




    // Klasse definieren (immer in einem namespace, hier OOP)

    class Person        // Name der Klasse, großgeschrieben
    {
        //Eigenschaften
        public int Id { get; set; }  // getter für Abruf, Setter für Setzen/Überschreiben
        public string Name { get; set; }
        public int Alter { get; set; }

        //Methoden
        public void Geburtstagsgruß(string absender)    //public statt static: damit man auch außerhalb dieses class-Codeblocks auf diese Methode zugreifen kann
        {
            Console.WriteLine("Schalömsche " + Name + "! Alles Gute zu Deinem " + (Alter +1) + ". Geburtstag von " + absender + " <3");
        }

        //Konstruktor
        public Person(int id, string name, int alter)  
        {
            Id = id;                //den Eigenschaften des Objekts werden die Parameter des Konstruktors übergeben
            Name = name;
            Alter = alter;
        }
    }

}
