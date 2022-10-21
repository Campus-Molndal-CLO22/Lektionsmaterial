// See https://aka.ms/new-console-template for more // Visual Studio = Redskap för utveckling, en smart texteditor
// VSCode = Redskap för utveckling, en smart texteditor med massor av olika språk
//          och tillägg. Minnessnål så den fungerar bra på mindre maskiner med.
//          Det finns även en version för Mac och Linux.
//          https://code.visualstudio.com/
// Rider = Redskap för utveckling, en smart texteditor med massor av olika språk
// (Jetbrains) Microsofts Roslynator gör samma sak

// Säg till om ni vill ha Github/Azure och/eller Jetbrains


// Fråga om namn och skriv "Hej" + namn
// Fråga om ålder och skriv "Du är" + ålder + "år gammal"
Console.WriteLine("Vad heter du?");

// Deklarera en variabel av typen string
string namn;

// Tilldelar variabeln ett värde, vid klasser/objekt så instansierar vi dem
//namn = "Katt";
namn = Console.ReadLine(); // Frågar användaren om en text

Console.WriteLine("Hej " + namn);

