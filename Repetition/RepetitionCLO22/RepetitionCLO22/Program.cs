using RepetitionCLO22;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var name = "Clark Kent";
var age = 37;
var city = "Metropolis";
Console.WriteLine("My name is {0} and I am {1} years old. I live in {2}", name, age, city);

var namnlist = new List<string>();

var knas = new RepetitionCLO22.Knasig.kod.Knasklass();

var num1 = 4.3224;
var num2 = 3.14154238974274687678867008924823;

var sup = new Superman();
Console.WriteLine(sup.Sum(1, 2, 3));
Console.WriteLine(sup.Sum(new int[] {1,2,3,4,5,}));
Console.WriteLine(sup.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10));

Console.WriteLine("Ange en siffra");
int input = Console.ReadLine().ToInt();
int num = "45".ToInt();
"Hello".Print();

Console.WriteLine("Hello ".AddDots(10));

var hero = new Hero();
hero.Level = 1;
hero.SetDefaultHP();
Console.WriteLine("Hero HP :" + hero.DefaultHP);
class Hero
{
    public int Level { get; set; }
    public int HP { get; set; }
    public int DefaultHP { get; set; }
}

static class HeroExtension
{
    public static void SetDefaultHP(this Hero hero)
    {
        hero.DefaultHP = hero.Level * 120;
    }
}
static class StringExtension
{
    public static string AddDots(this string text, int dots)
    {
        return text + new string('.', dots);
    }
    public static void Print(this string text)
    {
        Console.WriteLine(text);
    }
    public static int ToInt(this string input)
    {
        int.TryParse(input, out int number);
        return number;
    }
}
class Superman
{
    string name = "Clak Kent";

    public int Age { get; set; } = 37;

    public int Sum(int a,int b)
    {
        return a + b;
    }
    
    public int Sum(int a, int b, int c)
    {
        return a + b + c;
    }

    public int Sum(params int[] numbers)
    {
        int sum = 0;
        for(int num=0; num<numbers.Length; num++)
        {
            sum += numbers[num];
        }
        return sum;
    }

}