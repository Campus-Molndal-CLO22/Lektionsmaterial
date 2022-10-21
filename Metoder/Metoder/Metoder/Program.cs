// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Methods!");

// Metod = en funktion som kan kallas på flera ställen i koden
// Metoden kan ta emot parametrar och returnera ett värde

// Test
// ---------------------------------------------------------------------
PrintHello(); // Anropar metoden, inga parametrar och ingen retur
PrintHelloTo("Pekka"); // Anropar metoden, med parametrar och ingen retur

// ---------------------------------------------------------------------

// Metod som inte tar emot parametrar och inte returnerar något
void PrintHello() // Metodhuvud
{ 
    Console.WriteLine("Hello");  // Massor med Kod
} 

// Metod som tar emot parametrar och inte returnerar något
void PrintHelloTo(string name) // Metodhuvud med inparameter
{ 
    Console.WriteLine($"Hello {name}");  // Massor med Kod
} 

// Metod som inte tar emot parametrar och returnerar ett värde
int GetNumber() // Metodhuvud
{ 
    return 42;  // Massor med Kod
}

// Metod som tar emot parametrar och returnerar ett värde
// Deklarera : int number
// Bearbeta  : Gör beräkningar i metoden
// Returnera : return number
// Anropa : int number = GetNumber(42);
int GetNumberFrom(int number) // Metodhuvud med inparameter
{
    return number;  // Massor med Kod
}





