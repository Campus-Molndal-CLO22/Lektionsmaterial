// Anropar string constructor
Console.WriteLine(new string('-', 100));

string names = "Clark Kent, Bruce Wayne, Barbara Gordon";
foreach (string name in names.Split(',', StringSplitOptions.TrimEntries))
    Console.WriteLine(name);

Console.WriteLine(new string('-', 100));

// Deserialisera en CSV fil
List<string> csv = new List<string>()
{
    "Shirt, Medium, 'Blue, Marine', $14",
    "Shirt, Large, Red, $15",
   "Pants, Medium, Khaki, $23"
 };

foreach (string line in csv)
    {
    string[] parts = line.Split(',', StringSplitOptions.TrimEntries);
    Console.WriteLine($"Product: {parts[0]}");
    Console.WriteLine($"Size: {parts[1]}");
    Console.WriteLine($"Color: {parts[2]}");
    Console.WriteLine($"Price: {parts[3]}");
    Console.WriteLine();
}

Console.WriteLine(new string('-', 100));

// Använda string.Join
string[] names2 = new string[] { "Clark Kent", "Bruce Wayne", "Barbara Gordon" };
Console.WriteLine(string.Join(", ", names2));

// Substring
string text = "Hello world";
Console.WriteLine(text.Substring(0,4) + text.Substring(6)); // 

// IndexOf
int i = text.IndexOf('w');
if (i>=0)
{ 
    Console.WriteLine(i);
    Console.WriteLine(text.Substring(i));
}

int pos = text.IndexOf("Zapp");
Console.WriteLine(pos);

// Första och sista bokstaven
Console.WriteLine($"{text[0]} {text[^1]}");

Console.WriteLine(text.ToLower());
Console.WriteLine(text.ToUpper());

string comp1 = "Clark";
string comp2 = "clark";

Console.WriteLine(comp1==comp2);
Console.WriteLine(string.Compare(comp1, comp2, true));
Console.WriteLine(string.Compare(comp1, comp2, false));
if (comp1.Equals(comp2,StringComparison.InvariantCultureIgnoreCase)) 
    Console.WriteLine("De är lika");

Console.WriteLine((int)'c');
Console.WriteLine((int)'C');

//ASCII tabell
for (int ch = 32; ch < 65; ch++)
{
    Console.WriteLine($"{ch} = {(char)ch}");
}

Console.WriteLine((char)7);




