// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Fornuna Pseudokod
// ------------------------------------------------
// Pix = 500 vid start
int pix = 500;
// Loop
while (true)
{
    //      Input Lyckotal (1-6)
    int guess = 0;
    while (guess < 1 || guess > 6)
    {
        Console.Write("Ange lyckotal: ");
        int.TryParse(Console.ReadLine(), out guess);
    }
    //      Input Pix
    int bet = 0;
    Console.WriteLine($"Din saldo är {pix}");
    while (bet < 50 || bet > pix)
    {
        Console.Write("Hur mycket vill du satsa: ");
        int.TryParse(Console.ReadLine(), out bet);
    }
    pix -= bet;

    //      Slå tärningar
    Random random = new(DateTime.Now.Millisecond);
    int t1 = random.Next(1, 7);
    int t2 = random.Next(1, 7);
    int t3 = random.Next(1, 7);
    //  Jämför 1,2,3 med lyckotal
    int match = 0;
    if (t1 == guess) match++;
    if (t2 == guess) match++;
    if (t3 == guess) match++;
    Console.Write($" {t1} {t3} {t2} ");
    Console.WriteLine($"Du fick {match} träffar");
    //      Räkna ut vinst
    int win = 0;
    if (match > 0)
    {
        win = (match + 1) * bet;
    }
    //      Informera spelaren
    Console.WriteLine($"Din vinst var {win} pix");
    pix += win;
    Console.WriteLine($"Din saldo är {pix}");
    //      Om pix < 50 Game over
    if (pix < 50) break;
    //      Fråga om man vill spela igen
    Console.WriteLine("Vill du spela igen?");
    string input = Console.ReadLine().ToLower();
    if (input != "")
    {
        if (input[0] == 'n') break;
    }
}
// ------------------------------------------------