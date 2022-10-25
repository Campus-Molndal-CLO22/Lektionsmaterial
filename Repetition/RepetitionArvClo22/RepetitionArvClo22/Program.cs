internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        // Vovve = moderklass
        // Pudel = barnklass      | syskon
        // Schanuzer = barnklass  | inte kompatibla med varandra
        //                        | båda är kompatible med Vovve



        Pudel fluffy = new();
        fluffy.Namn = "Fluffy";
        fluffy.Bjäbbig = true;
        fluffy.Gosig = false;
        Schnauzer Hans = new();
        Hans.Gosig = true;

        var wolfy = new MuteradPudel()
        {
            Namn = "Wolfie",
            Bjäbbig = false,
            Gosig=true
        };
        
        var vovvar = new List<Vovve>()
        {
            fluffy, Hans, wolfy
        };

        var pudlar = new List<Pudel>()
        {
            fluffy, wolfy
        };

        var muterade = new List<MuteradPudel>()
        {
            wolfy
        };


    }
}

class Vovve
{
    public string Namn { get; set; }
    public int Ålder { get; set; }
    public bool Gosig { get; set; }
    // Alla barnklasser får samma Gos-metod
    public void Gosa()
    {

    }

    // Alla barnklasser får samma metod, men har alternativet att ändra (override)
    // den helt och även att anropa originalmetoden (base.Lek())
    public virtual void Lek()
    {

    }
}

class Schnauzer: Vovve
{
    
}

class Pudel : Vovve
{
    public bool Bjäbbig { get; set; }
}

class MuteradPudel: Pudel
{
    
}