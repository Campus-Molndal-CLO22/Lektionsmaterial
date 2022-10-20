using System.Diagnostics;
using System.Text;

Console.WriteLine("Hello, NULL!");

/*
 
                Namn, adress, telefon
        program ------------------------> API
                                           |
                <--------------------------+
                Marcus, Onsala
        Skriver ut
                Namn  ---> Marcus
                Adress ---> Onsala
                telefon ---> Krasch pga NULL

*/
// ----------------------------------------------------------------------------------------------------------------
bool CSharpIsFun = true;
bool CplusPLusIsFun = false;
bool? Null = null; // Bool kan alltså ha tre olika värden, true, false eller null

bool newValue;          // Deklarerar variabel som inte kan hantera null
object value = null;    // skapar ett dummy objekt för att visualisera exemplet

if (value == null)      // om objektet är null ska newValue = false;
    newValue = false; 
else 
    newValue = true;

// ternary if är samma sak som if-satsen ovan
newValue = value == null ? false : true;

newValue = !(value == null);  // Om värdet inte är null kommer svaret att bli true

newValue = value != null; // Om värder är null kommer svaret att bli false, annars true

// ----------------------------------------------------------------------------------------------------------------
string cantHandleNull;
string? nullString = null;

cantHandleNull = nullString ?? string.Empty; // ?? betyder om värdet är null, tilldela standardvärde som följer

cantHandleNull ??= string.Empty; // Om strängen är null kommer den att bli tom, annars händer ingenting.

// ----------------------------------------------------------------------------------------------------------------

List<string> Names = null;

// ----------------------------------------------------------------------------------------------------------------

sbyte num = unchecked((sbyte)127);
Console.WriteLine(num);

// 0000000 = 0
// 0000001 = 1
// 0000010 = 2
// 01111111 = 127
// 10000000 = 128
// 110000000 = 0100000001 = 196609
// 1111111 = 255

// ----------------------------------------------------------------------------------------------------------------
byte agressivitet = 1; // Indien + Ghandi = 1 i agressivitet = fredligt
// Indien blir demokrati i CIV 5, därmed minskar agressivitet med 2
agressivitet -= 2;
Console.WriteLine(agressivitet);
// I CIV 4 var agressivitet ett värde mellan 1 och 10, men Ghandi fick 255 i agressivitet
// ----------------------------------------------------------------------------------------------------------------
Console.Clear();
Console.WriteLine(int.MinValue + " " + int.MaxValue);

// ----------------------------------------------------------------------------------------------------------------
Console.WriteLine("-------------------------------------------------------------------------------------------");
float digit= 1.001f;
double ddigit = digit;
decimal fdigit = (decimal)digit;

Console.WriteLine("Float -> Double, Float -> Decimal");
Console.WriteLine("float   : "+digit);
Console.WriteLine("double  : "+ddigit);
Console.WriteLine("decimal : "+fdigit);
Console.WriteLine();

Console.WriteLine("Double -> Float, Double -> decimal");
double dd = 1.0011111111111d;
float fd = (float)dd;
decimal dc = (decimal)dd;
Console.WriteLine("float   : " + fd);
Console.WriteLine("double  : " + dd);
Console.WriteLine("decimal : " + dc);
Console.WriteLine();

Console.WriteLine("Decimal -> Float, Decimal -> Double");
decimal dec1 = (decimal)1.0101001010101;
double dou1 = (double)dec1;
float flo1 = (float)dec1;
Console.WriteLine("float   : " + flo1);
Console.WriteLine("double  : " + dou1);
Console.WriteLine("decimal : " + dec1);

// Slutsats: Double kan vara otillförlitlig pga random deciamltal
// Kan orsaka butterfly effekt

object var1 = "Hello";
object var2 = 5;

var var3 = "Hello world";
var var4 = 10;

var namnlista = new List<string>();
List<string> namnlista2 = new();

string name = "bruce wayne";
name += " is batman";
// I bakgrunden : string("bruce wayne") + new string("is batman") --> new string ("bruce wayne is batman")
// Detta på grund av att en string är egentligen en array av char
// När den tilldelas mer information måste den skapas om i en större version.
Console.WriteLine("-------------------------------------------------------------------------------------------");

StringBuilder sb = new();
sb.AppendLine("Hello");
sb.AppendLine("Hello").Append(' ').Append("world");
sb.Append("Hello world!!!");
// I bakgrunden skapas en lista (tror jag) med allt jag lagt in, så att den är klart snabbare (ung 1000 ggr)
Console.WriteLine(sb.ToString());
Console.WriteLine("-------------------------------------------------------------------------------------------");

// exempel
Console.WriteLine("String test, adderar strängen med ett tecken per varv");
Console.WriteLine("Testet körs fem gånger för att se om minnes cache påverkar");
int max = 100000;
for (int i = 0; i < 5; i++)
{
    Console.Write($"Test #{i} ");
    Stopwatch sw = new();
    sw.Start();
    string a = "";
    for (int ix = 0; ix < max; ix++)
    {
        a += "a";
    }
    sw.Stop();
    Console.WriteLine($"{sw.ElapsedMilliseconds} millisekunder");
    Console.WriteLine($"Strängen har {a.Length} tecken nu");
}
Console.WriteLine();

Console.WriteLine("Stringbuilder test, adderar strängen med ett tecken per varv");
Console.WriteLine("Testet körs fem gånger för att se om minnes cache påverkar");
for (int i = 0; i < 5; i++)
{
    Console.Write($"Test #{i} ");
    Stopwatch sw = new();
    sw.Start();
    StringBuilder a = new StringBuilder();
    for (int ix = 0; ix < max; ix++)
    {
        a.Append("a");
    }
    sw.Stop();
    Console.WriteLine($"{sw.ElapsedMilliseconds} millisekunder");
    Console.WriteLine($"StringBuilder har {a.Length} tecken nu");
}