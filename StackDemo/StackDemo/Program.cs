// Stack är en generisk klass som representerar en samling av objekt där
// elementen kan läggas till och tas bort enligt principen LIFO (last in, first out).

// Generisk klass betyder att klassen kan hantera objekt av vilken typ som helst.
// Generiska klasser är en av de mest användbara funktionerna i C#.

Stack<string> namn = new(); // Låser sig till att hantera strängar
Stack<int> nuffror = new(); // Låser sig till att hantera heltal

// Lägg till element i stacken
namn.Push("Kalle Anka");
namn.Push("Donald Duck");
namn.Push("Huey");
namn.Push("Dewey");
namn.Push("Louie");

// Tar bort det översta elementet i stacken och skriver ut det
Console.WriteLine("-- pop --");
Console.WriteLine(namn.Pop());
Console.WriteLine(namn.Pop());

// Skriver ut det översta elementet i stacken utan att ta bort det
Console.WriteLine("-- peek --");
Console.WriteLine(namn.Peek());
Console.WriteLine(namn.Peek());

Console.WriteLine(" --- loop ----");
foreach (var n in namn)
{
    Console.WriteLine(n);
}
Console.WriteLine(namn.Peek());
