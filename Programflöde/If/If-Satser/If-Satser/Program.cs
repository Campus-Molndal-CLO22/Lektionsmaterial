Console.WriteLine("Skriv en siffra mellan 1 och 10");
int siffra = Convert.ToInt32(Console.ReadLine());

// If kräver ett villkor som resulterar i en boolean
// Om en rad följer if-satsen kommer den att tillhöra if-satsen
// fler än en rad måste läggas inom måsvingar
if (siffra == 0)
    Console.WriteLine("En nolla!");
if (siffra > 0)
    Console.WriteLine("Större än noll");
if (siffra < 0)
    Console.WriteLine("Mindre än noll");
if (siffra > 5)
    Console.WriteLine("Större än 5");
if (siffra < 5)
    Console.WriteLine("mindre än 5");
if (siffra == 10)
{
    Console.WriteLine("En tia!!!!");
    Console.WriteLine("Tjohooooo!!");
}
// --------------------------------------------------
if (siffra == 10)
{
    Console.WriteLine("En tia!!!!");
    Console.WriteLine("Tjohooooo!!");
}
else if (siffra < 5)
    Console.WriteLine("mindre än 5");
else if (siffra > 5)
    Console.WriteLine("Större än 5");
else if (siffra == 0)
    Console.WriteLine("En nolla!");
else if (siffra > 0)
    Console.WriteLine("Större än noll");
else if (siffra < 0)
    Console.WriteLine("Mindre än noll");
else
    Console.WriteLine("Jag fattar noll!");

// flowchart
//
//  Input
//
//  ==0 --> "En nolla"
//   >9 --> "Större än noll"
// osv

bool test = true;
if (!test)
    Console.WriteLine("Rock'n'Roll");
else if (test==false)
    Console.WriteLine("Hip hop");
else
    Console.WriteLine("Whatever");

/*
 * jag går som på MOLN här i MOLNDAL för nu finns datorer att hämta för dem som anmält sig: Drop-in öppettider
Måndag: 08.30-11.30
Tisdag: 08.30-11.30
Onsdag: 08.30-11.30
Torsdag: 08.30-11.30
Fredag: Stängt
Plats: Campus Mölndal, Krokslätts Fabriker 12a, vån 2, rum 234
medtag legitimation
 */


















