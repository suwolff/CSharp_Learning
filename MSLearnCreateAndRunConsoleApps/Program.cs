// See https://aka.ms/new-console-template for more information


//Methods

//Klasse: System.Console, Methode: WriteLine(), Parameter: "Hello, World!"
Console.WriteLine("Hello, World!"); 

//Klasse: System.Random, Methode: Next()
Random randomisierungWürfel = new(); // Anlegen eines neuen Objekts / der neuen Instanz randomisierungWürfel aus der Klasse Random
int würfelwurf = randomisierungWürfel.Next(1, 7); // Verwendung der Methode Next() mit den Parametern von, bis; 1,7 sind die Argumente des Aufrufs = Werte, die den Parametern zugewiesen werden 
                                                  // Methode gibt ein int als return value aus, dieser wird in Variable würfelwurf gespeichert
Console.WriteLine($"Wurf = {würfelwurf}");
Console.Read();

//WriteLine = stateless/static method, funktioniert unabhängig von state der Klasse Console --> können direkt von der Klasse aus aufgerufen werden
//Next = stateful/instance method, funktioniert in Abhängigkeit vom state der Klasse, der im Objekt gespeichert ist --> müssen von einem Objekt/Instanz aus aufgerufen werden
//Your code uses the dice object like a variable that stores the state of the Random class. When you call the Next() method on the dice object,
//the method uses the state stored in the dice object to generate a random number.


//Overloaded Methods: Random.Next() funktioniert ohne Argumente, mit einem oder mit zwei Argumenten
Random dice = new Random();
int roll1 = dice.Next(); 
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);
Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
Console.Read();

//Challenge:
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue); //gefunden in System.Math-Klasse; static-Methode
Console.WriteLine(largerValue);
Console.Read();


