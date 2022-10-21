// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 1 - Skapa en repository till projektet
//     med knappen "Add to Source Control"
// 2 - Ändra inte mappen
// 3 - Gitignore ska vara "Visual Studio"
// 4 - Licens kan vara Apache 2 eller MIT
// 5 - Lägg till Readme
// 6 - Välj Github konto
// 7 - Välj Repository namn
// 8 - Push!

// Skapa en branch för att testa om vissa förändringar
// blir bra, annars radera branchen. Då kan man testa 
// utan att skada master branchen.

// Slå samman din nya branch med Master med Pull-Request
// Ta bort den nya branchen därefter, både från servern och lokalt

// Ps. Från och med nästa kurs ska vi INTE arbeta mot master
//     Då arbetar vi mot Development, även kallad Dev
//
//  Brancher i development: (Git flow)
//  Master innehåller den färdiga produkten
//  Product.v1 = Version1
//  Product.v2 osv
//  Stage : Det är vad vi testar hos kunden 
//  Test  : Koden som testas innan deployment (=skickas) till kundens server
//  Dev   : Där vi samlar alla nya features
//  Feature branches : Varje ny feature eller fix får en egen branch
//                     med namn enligt Issue i projektplan 
// 10 rader kod = 10 buggar
// 10000 rader kod --> kanske 10 buggar.