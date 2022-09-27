// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Dictionary
// index, value

Dictionary<Room, string> RoomDescription = new();
Dictionary<Room, string[]> Exits = new();
RoomDescription[Room.LivingRoom] = "This a cozy livingroom with a TV and a couch";
Exits[Room.LivingRoom] =new string[] { "Left, to the bedroom", "right to the bathroom"};

Console.BackgroundColor = (ConsoleColor)Colors.Background;
Console.ForegroundColor = (ConsoleColor)Colors.ForeGround;
Console.Clear();
Room location = Room.LivingRoom;

Console.WriteLine(RoomDescription[location]);
Console.WriteLine("You can walk to:");
foreach(string exit in Exits[location])
    Console.WriteLine(exit);


// Rooms
enum Room
{
    LivingRoom = 100,
    Bedroom = 200,
    Bathroom = 300
}

enum Colors
{
    Background = ConsoleColor.Blue,
    ForeGround = ConsoleColor.Green,
}