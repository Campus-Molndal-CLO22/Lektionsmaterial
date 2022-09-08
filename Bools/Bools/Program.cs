namespace Bools
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bool är antingen True eller False

            // Deklarerar
            int a = 10;
            int b = 20;

            // Jämförelse
            
            bool cmp1 = a > b;  // false
            bool cmp2 = a == b; // false
            bool cmp3 = a < b;  // true

            // Skriver ut resultat
            Console.WriteLine(cmp1);
            Console.WriteLine(cmp2);
            Console.WriteLine(cmp3);

            // && = AND = Båda måste vara True för att få True som svar
            bool cmp4 = (a < b) && (a == 10); // true
            Console.WriteLine(cmp4);

            a = 11;
            bool cmp5 = (a < b) && (a == 10); // false
            Console.WriteLine(cmp5);

            bool cmp6 = (a < b) || (a == 10); // true
            Console.WriteLine(cmp6);



        }
    }
}