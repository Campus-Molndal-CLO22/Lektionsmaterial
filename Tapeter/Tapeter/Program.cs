// Tapeter

/*
4 faktorer som bestämmer hur mycket tapet du behöver:
Väggens bredd
Höjden på din vägg
Längden på din tapetrulle
Bredden på din tapetrulle
De formler du kan använda för att beräkna svaret är:

Längd tapetrulle / vägghöjd = antal tapeterremsor du får från en tapetrulle.

Väggbredd / antal hela tapetremsor = antalet tapetrullar du behöver
*/

// Deklarera
float wallWidth = 0;
float wallHeight = 0;
float tapestryLength = 0;
float tapestryWidth = 0;

Console.WriteLine("Ange alla mått i meter");
Console.WriteLine("Hur bredd är väggen?");
wallWidth = float.Parse(Console.ReadLine());

Console.WriteLine("Hur hög är väggen?");
wallHeight= float.Parse(Console.ReadLine());

Console.WriteLine("Hur lång är tapetrullen?");
tapestryLength = float.Parse(Console.ReadLine());

Console.WriteLine("Hur bred är tapetrullen?");
tapestryWidth= float.Parse(Console.ReadLine());

float rollOfWallpaper = tapestryLength / wallHeight;

// Instruktionerna på sidan missade / tapestryWidth
float amount = wallWidth / tapestryWidth / rollOfWallpaper;

Console.WriteLine("Du behöver "+ rollOfWallpaper+" tapetremsor.");
Console.WriteLine("Du behöver " + amount + " rullar.");
