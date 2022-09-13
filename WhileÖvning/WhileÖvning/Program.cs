// Begränsad till en fast punkt
for (int counter = 0; counter < 10; counter++)
{
    Console.WriteLine(counter);
}

int count = 0;
while (count < 10)
{
    Console.WriteLine(count);
    count++;
}

string password = "abc123";
string input = "abc123";
while(input!=password)
{
    Console.WriteLine("Ange lösenord:");
    input = Console.ReadLine();
    // Kolla senare om mer än tre försök gjorts
    // i så fall ring SÄPO
}
// for (; input != password;)
// {
// }

// Kör minst en gång per runda
do
{
    Console.WriteLine("Ange lösenord:");
    input = Console.ReadLine();
    // Kolla senare om mer än tre försök gjorts
    // i så fall ring SÄPO
} while (input != password);

