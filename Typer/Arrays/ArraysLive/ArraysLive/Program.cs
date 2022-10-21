//// Vad som egentligen händer är 
//using System;

//string plumber1 = "Mario";
//// new string(new string("Mario"))
//string plumber2 = "Luigi";
//// new string(new string("Luigi"))

//Console.WriteLine(plumber1 + " " + plumber2);

//// [0x0] [0x1] [0x2] [0x3] [0x4] 
////    M     a     r     i     o
//// [0x0] [0x1] [0x2] [0x3] [0x4] 
////    L     u     i     g     i


//plumber1 = plumber1 + " Mario";
//// Vad som egentligen händer är 
//// new string(plumber1 + new string(" Mario"))
//plumber2 += " Mario";

//Console.WriteLine(plumber1 + " " + plumber2);

//// Array har fast storlek
//string[] plumbers = new string[]
//{
//    "Mario",
//    "Luigi",
//    "Extra"
//};

//plumbers[0] = "Mario Mario";
//plumbers[1] = "Luigi Mario";

//string name = "";
//int nameCount = 0;
//do
//{
//    name = Console.ReadLine();
//    if (nameCount >= plumbers.Length) break;
//    plumbers[nameCount] = name;
//    nameCount++;
//} while (name != ""); // Loopen slutar köra om jag inte skriver något

//// Sorterar i bokstavsordning om det är text
//// annars enligt värde från minsta till högsta
//Array.Sort(plumbers);

//for (int count = 0; count < plumbers.Length; count++)
//{
//    //                plumbers[position]
//    Console.WriteLine(plumbers[count]);
//}

//// Deklarera
//string[] gothamVillains = new string[] 
//{
//"Harley Quinn","Scarecrow","The Joker","Ra's al Gul",
//"Poison Ivy","Two face","Catwoman", "Penguin", "Bane",
//"Joe Chill", "Hugo Strange","The Riddler", "Deadshot",
//"Killer Croc","Mr. Freeze"
//};

//// Bearbeta
//Array.Sort(gothamVillains); // Sorterar från minst till högst
//Array.Reverse(gothamVillains); // Vänd listan upp och ner

//// Presentera resultat
//for (int counter = 0; counter < gothamVillains.Length; counter++)
//{
//    Console.WriteLine(gothamVillains[counter]);
//}

string[] namn = "Clark Kent, Bruce Wayne, Celina Kyle"
    .Split(',',StringSplitOptions.TrimEntries);
for (int count =0; count < namn.Length; count++)
{W
    Console.WriteLine(namn[count]);
}

string alla = string.Join(',', namn);
Console.WriteLine( alla );
