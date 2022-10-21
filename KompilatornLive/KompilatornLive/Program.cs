using KompilatornLive;

Console.WriteLine("Hello, Compiler!");

// CSharp --> IL --> CLR --> JIT -> Native Code -> Exe

// CSharp - Koden vi skriver
//      -> Intermediate Language, Assembleraktig språk 
//              -> Common Language Runtime - gemensam för alla .net språk 
//                      -> Just In Time Compiler - omvandlar till maskinkod
//                              -> Native Code - OS anpassad kod, Mac, Windows, Linux, BSD, Iphone mm
//                                  -> Exe - Körbar fil.
// När vi kör run eller trycker F5.
// Objekt mappen = Kompileringen
// Bin mappen = Körbar fil

// IL = Intermediate Language, det betyder att det är en språk som CLR förstår
// CLR = Common Language Runtime, det är en virtuell maskin som kör C# program,
// den är skriven i C++ och är en del av .NET Framework. 
// EXE = Executable, det är en fil som kan köras på datorn
// DLL = Dynamic Link Library, det är en fil som kan köras på datorn
// JIT = Just In Time, det är en teknik som kör C# programmet i realtid.

// Vid kompilering av C# till EXE så skapas en EXE-fil som innehåller både C#-koden och CLR-koden.
// Vid kompilering av C# till DLL så skapas en DLL-fil som innehåller C#-koden och en EXE-fil som innehåller CLR-koden.


//  IL är en abstrakt representation av en .NET applikation som är helt oberoende av plattform.
//  IL är en representation av C# koden som är lätt att förstå för en maskin.
//  IL gör det möjligt att köra C# koden på alla plattformar som stödjer .NET.

// ILSpy är ett program som kan öppna en EXE fil och visa dess IL kod.
// ILSpy kan även öppna en DLL fil och visa dess IL kod.
// ILSpy kan även öppna en PDB fil och visa dess IL kod.
// Länk: https://marketplace.visualstudio.com/items?itemName=SharpDevelopTeam.ILSpy

// DotPeek är ett program som kan öppna en EXE fil och visa dess IL kod.
// DotPeek kan även öppna en DLL fil och visa dess IL kod.
// DotPeek kan även öppna en PDB fil och visa dess IL kod.
// Länk: https://www.jetbrains.com/decompiler/

//  ILDASM är ett program som kan öppna en EXE fil och visa dess IL kod.
//  ILDASM kan även öppna en DLL fil och visa dess IL kod.
//  ILDASM kan även öppna en PDB fil och visa dess IL kod.
//  Länk: https://docs.microsoft.com/en-us/dotnet/framework/tools/ildasm-exe-il-disassembler

// Läs: https://medium.com/@kunaltandon.kt/c-clr-il-jit-compilation-code-access-security-explained-269124121f5
// Läs: https://www.geeksforgeeks.org/c-sharp-net-framework-basic-architecture-component-stack/?ref=gcse
// Läs: https://www.javatpoint.com/net-common-language-runtime
// Läs: https://en.wikipedia.org/wiki/Mono_(software)


var x = 10;
x++;
var text = x > 10 ? "Funkar" : "Oops";
Console.WriteLine(text);

// Jag är cool!

// I Releaseläge skippas våra debug
// I alla kompileringslägen försvinner kommentarer

if (x == 11) Console.WriteLine("Elva!!!");
// Debug.WriteLine skriver ut information
System.Diagnostics.Debug.WriteLine($"x={x}");
x++;
// Debug Assert varnar om ett visst värde uppfyller villkoret
//System.Diagnostics.Debug.Assert(x != 12);

//---------------
// Debug!
//---------------
Console.WriteLine();
//new TestClass().Run();
// TODO: Skriv inte så mycket kommentarer!!!

new MerTestande().Run();