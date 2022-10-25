// Vad har man Static classer till
//
// + Extensions
// + Program settings
// + Helper classes 

using RepetitionStaticCLO22;

namespace RepetitionStaticCLO22
{
    internal class Program
    {
        public static int Value { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var ns = new NotStatic();
            ns.Value = 10;
        }
    }
}

class NotStatic
{
    public int Value { get; set; }

    public static void DoSomething()
    {
        Program.Value = 20;
        // Static metoden kan inte anropa instansmetoder
    }

    public void DoSomethingMore()
    {
        Value = 32;
        DoSomething();
        // Instansmetoder kan anropa static metoder
    }
}