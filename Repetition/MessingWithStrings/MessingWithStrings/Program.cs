// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

PrintValues("Hello", 10, 10);

void PrintValues(string name, int strength, int health)
{
    Console.WriteLine(" +-----------------------------------------------------+");
    Console.WriteLine(" | " + name.PadRight(25) + " | " + strength.ToString().PadLeft(10) + " | " + health.ToString().PadLeft(10) + " | ");
    Console.WriteLine(" +-----------------------------------------------------+");
}