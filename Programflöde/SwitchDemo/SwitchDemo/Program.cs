Dagar dag = Dagar.tisdag;

static void Vilodag()
{
    Console.Write("Vilodag");
    Console.WriteLine("Ha en skön helg!");
}

static void Lektion()
{
    Console.Write("Lektion");
    Console.WriteLine("Massor med pladder och kod");
}

static void Självstudier()
{
    Console.Write("Självstudier");
}

int c = 0;
while (c < 10)
{
    c++;
}


if (dag == Dagar.onsdag || dag == Dagar.torsdag || dag == Dagar.Måndag)
{
    Självstudier();
}
else if (dag == Dagar.tisdag || dag == Dagar.fredag)
{
    Lektion();
}
else if (dag == Dagar.lördag || dag == Dagar.söndag)
{
    Vilodag();
}



enum Dagar
{
    Måndag, tisdag, onsdag, torsdag, fredag, lördag, söndag
}

