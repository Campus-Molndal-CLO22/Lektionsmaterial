// OOOOPs

var hero = new Hero() { Name = "Hero"};
hero.PrintHero();
hero.XP = 0;
hero.PrintHero();

var enemy = new Hero() { Name = "Evil hero"};
Fight(hero, enemy);

void Fight(Hero hero, Hero enemy)
{
    Random random = new Random();
    while (hero.HP>0 && enemy.HP>0)
    {
        Console.Clear();
        hero.PrintHero();
        Console.WriteLine();
        enemy.PrintHero();
        Console.WriteLine();
        enemy.Defend(hero.Attack(enemy));
        hero.Defend(enemy.Attack(hero));
        Console.ReadLine();
    }

    if (hero.HP <= 0) Console.WriteLine($"{hero.Name} dog :(");
    if (enemy.HP <= 0) Console.WriteLine($"{enemy.Name} dog :)");
}

class Hero
{
    public string Name { get; set; }
    // Health = påverkas av strider
    public int HP { get; set; } = 100;
    // Påverkas level, MaxHealth = 100 + 100 * level
    public int MaxHealth { get { return 100 + 100 * Level; } } 
    // Påverkas av XP
    public int Level { get; set; } = 1;
    
    // påverkas av strider
    private int xp = 0;
    public int XP { get { return xp; } set { SetXP(value); } }

    public Hero()
    {
        HP = MaxHealth;
        Toughness = MaxToughness;
    }
    private void SetXP(int value)
    {
        // player.XP = 10;
        // player.XP++;
        // player.XP +=10;
        xp = value;
        if (xp > XPNeeded) Level++;
        Toughness = MaxToughness;
        HP = MaxHealth;
    }

    // påverkas av Level, 50 + 50*level
    public int Strength { get { return 50 + 50 * Level; } } 
    
    // påverkas av Level, 50 + 50*level
    public int Toughness { get; set; } = 0;

    // påverkas av Level, 50 + 50*level
    public int MaxToughness { get { return 50 + 50 * Level; } } 

    /// <summary>
    /// XP needed for next level, 100*(level+1)
    /// </summary>
    public int XPNeeded { get { return 100 * (Level + 1); } }

    public void PrintHero()
    {
        Console.WriteLine($"Player    :{Name}");
        Console.WriteLine($"HP        :{HP}/ {MaxHealth}");
        Console.WriteLine($"XP        :{XP} / {XPNeeded}");
        Console.WriteLine($"Toughness :{Toughness}");
        Console.WriteLine($"Level     :{Level}");
    }

    internal void Defend(int attack)
    {
        if (attack < Toughness) 
        {
            Console.WriteLine("Attacken misslyckades!");
            Toughness -= attack;
        }
        else
        {
            HP -= attack;
        }
    }

    internal int Attack(Hero enemy)
    {
        Random random = new Random();
        int attack = Strength / 2 + random.Next(Strength);
        Console.WriteLine($"{Name} anfaller {enemy.Name} med styrka {attack}");
        return attack;
    }
}



