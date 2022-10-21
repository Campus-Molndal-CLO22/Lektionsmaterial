Console.WriteLine(Dagar.Onsdag);
Console.WriteLine((int)Dagar.Onsdag);

int dag = 1;

// Vad är 1, måndag eller tisdag
if (dag == 1) Console.WriteLine("Måndag");

if (dag == (int)Dagar.Måndag) Console.WriteLine("Måndag");

// Dagar.Tisdag = 8; // funkar inte

bool IsAlive = true;


PLayerstatus status = PLayerstatus.GameOn;
while (status == PLayerstatus.GameOn)
{


    status = PLayerstatus.GameOver;
}

enum Weapon
{
    Stick,
    Stone,
    Rusty_Sword,
    Iron_Sword,
    Katana,
    Machine_gun,

}
enum PLayerstatus
{
    GameOn,
    GameOver,
}

enum GameStatus
{
    KeepPlaying,
    StopPlaying,
}

enum Color
{
    Grön = 4096,
    Röd = 255,
    Blå = 1200,
    Lila, //1201
}

enum Dagar
{
    Fredag,
    Tisdag,
    Måndag,
    Onsdag,
    Torsdag,
    Lördag,
    Söndag
}

