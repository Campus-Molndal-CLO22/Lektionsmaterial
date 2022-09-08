Console.WriteLine("Random!");

// deklarerar random
// instansierar en Random
// tilldelar Random instansen till variabeln random
//Random random = new Random();

// Från och med c# 6
// Seed hämtar en lista av tal, specifik tal ger samma lista varje gång
Random random = new();

// Next ger nästa tal i slumptalslistan
Console.WriteLine(random.Next());
Console.WriteLine(random.Next());
Console.WriteLine(random.Next());
Console.WriteLine(random.Next());

Console.WriteLine("Slumptal mellan 1 och 100");
Console.WriteLine(random.Next(1, 100)); // Maxvärde måste vara +1
Console.WriteLine(random.Next(50, 101)); // Tal mellan 50 - 100
Console.WriteLine(random.Next(101)); // Tal mellan 0 och 100
Console.WriteLine(random.NextDouble()); // Tal mellan 0 och 100

Console.WriteLine("Tre T6or");
Console.WriteLine(random.Next(1, 7)); // T6
Console.WriteLine(random.Next(1, 7)); // T6
Console.WriteLine(random.Next(1, 7)); // T6

/*
Seed: 15
1208223655
469449854
542975234
1631669135
*/