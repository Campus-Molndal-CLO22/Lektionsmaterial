// Deklarera namnlista
List<string> Namnlista = new();
Namnlista.Add("Robin");
Namnlista.AddRange(new string[]
    {
        "Batman", "Catwoman","Alfred","Nightwing"
    });

while (true) // evig loop
{
    // Snygg meny
    Console.WriteLine("+--------------+");
    Console.WriteLine("|  Namnlista   |");
    Console.WriteLine("+--------------+");
    Console.WriteLine("1 - Lägg till namn");
    Console.WriteLine("2 - Hitta namn");

    // Loop som upprepar sig tills man matat in en siffra
    int choice = 0; // Användarens val av funktion
    while (true) // evig loop
    {
        // Frågar efter menyval
        string input = Console.ReadLine();

        // Vi frågar TryParse om den kan omvandla texten till en siffra
        // TryParse returnerar true om input går att göra till siffra
        // TryParse returnerar false om input är trams
        // Om TryParse kan omvandla till siffra lägger den värdet i variabeln
        // vi skrev vid out ------------\/
        if (int.TryParse(input, out choice))
        {
            // Om användaren väljer en siffra mellan 1 och 2
            // hoppa ut ur den eviga loopen med kommandor break
            if (choice > 0 && choice < 3) break;
        }
        Console.WriteLine("Felaktig input");
    }

    if (choice == 1)
    {
        // första valet - mata in ett namn
        Console.WriteLine("Ange ett namn");
        string newName = Console.ReadLine();
        if (newName != "") Namnlista.Add(newName); // lägg namnet i listan
    } 
    else if (choice == 2)
    {
        Console.WriteLine("Vad söker du?");
        string find = Console.ReadLine().ToLower(); // tolower gör strängar till gemener
        List<string> found=new(); // = Namnlista.FindAll(x => x == find);
        for (int i = 0; i < Namnlista.Count; i++)
        {
            // Hämtar ett värde ur listan
            string current = Namnlista[i];
            // om värdet är likadan som det vi söker så läggs det 
            // i den nya listan
            if (current.ToLower().Contains(find)) found.Add(current);
        }
        // Skriver ut hela listan
        for (int i = 0; i < found.Count; i++)
        {
            Console.WriteLine(found[i]);
        }
    }


}