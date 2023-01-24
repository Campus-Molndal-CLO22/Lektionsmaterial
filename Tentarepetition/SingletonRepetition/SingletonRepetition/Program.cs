// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var settings = Settings.GetInstance();
settings.DarkMode = true;
settings.UserName = "Kalle";

settings = Settings.GetInstance();
Console.WriteLine($"DarkMode: {settings.DarkMode}");
Console.WriteLine($"UserName: {settings.UserName}");

class Settings
{
    // Singleton av klassen Settings
    private static Settings _instance;

    // Konstruktor
    private Settings()
    {
        // Läs in inställningar från fil
    }

    // Statisk metod som returnerar instansen av klassen
    public static Settings GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Settings();
        }

        return _instance;
    }


    public bool DarkMode { get; set; } = false;
    public string UserName { get; set; } = "Guest";

    public void Save()
    {
        //save to file
    }
}


