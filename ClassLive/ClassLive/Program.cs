// See https://aka.ms/new-console-template for more information
using ClassLive;

Console.WriteLine("Hello, World!");

// Varje class har sin egen fil!
// CTRL + SHIFT + A = Ny Class

// Instansiera klass
ClassPrivacy c = new();
Console.WriteLine(c.InternalField);
Console.WriteLine(c.PublicField);

Console.WriteLine(StaticClass.Name);
// --------------------------------
StaticClass.Name = "Batman";
Console.WriteLine(StaticClass.Name);

// --------------------------------
ClassPrivacy c1 = new() { PublicField = "Bruce Banner" };
ClassPrivacy c2 = new() { PublicField = "Peter Parker" };

Console.WriteLine(c1.PublicField);
Console.WriteLine(c2.PublicField);
Console.WriteLine(StaticClass.Name);

c1.SetName("Hulk");
Console.WriteLine(c1.PublicField); // Bruce Banner
Console.WriteLine(c1.GetName());
Console.WriteLine(c2.PublicField); // Peter Parker
Console.WriteLine(c2.GetName());
c2.SetName("Spiderman");
Console.WriteLine(c1.PublicField);
Console.WriteLine(c1.GetName());
Console.WriteLine(c2.PublicField);
 Console.WriteLine(c2.GetName());

// Objekt
string data = "";
int x = 0;

object obj = new object();
