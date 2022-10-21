// List<> <--- generisk typ
//             den byter form till det vi anger

// C.R.U.D
// C = Create  ( Add )
// R = Read    ( list[x], Find )
// U = Update  ( list[x] = "Hello" )
// D = Delete  ( Remove, RemoveAll )
// L = List    ( ForEach )

List<int> siffror = new List<int>();
siffror.Add(10);
siffror.Add(15);
siffror.Add(22);
siffror.Add(34);
siffror.Add(22);

//siffror.Remove(22); // Tar bort första bästa matching
siffror.RemoveAll(x => x == 22);
// Lambda kod  => 
// x är bara en variabel
// x==22 är ett villkor
// kommandot RemoveAll loopar igenom ALLA värden i listan och tar bort
// matchande

// Skriver över den gamla listan
siffror = siffror.FindAll(x => x > 20);

for (int count = 0; count < siffror.Count; count++)
{
    Console.WriteLine(siffror[count]);
}

// x = helt vanlig variabel
// efter => talar vi om vad som ska köras
// ForEach loopar igenom hela listan
siffror.ForEach(x => Console.WriteLine(x));

List<string> namn = new();
namn.Add("Celina Kyle");

// hemskt men det funkar!
List<List<int>> listamednummer = new();
listamednummer.Add(new List<int> { 1, 2, 4 });

// ArrayList
