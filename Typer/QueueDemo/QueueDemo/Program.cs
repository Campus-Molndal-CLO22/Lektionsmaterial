// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Queue är en kölista helt enkelt

// Jellicle cats!
Queue<string> cats = new();
cats.Enqueue("Jenny Anydots"); // Vicky prickigtass
cats.Enqueue("Bustopher Jones"); // fet katt
cats.Enqueue("Mr Mistopheles"); // Magiska katt
cats.Enqueue("Rum tum tugger"); // Rock'n'roll katt



Console.WriteLine("Katterna presenteras");
while (cats.Count > 0)
    Console.WriteLine(cats.Dequeue());
