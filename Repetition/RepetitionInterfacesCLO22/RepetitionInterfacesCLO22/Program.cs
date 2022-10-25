namespace RepetitionInterfacesCLO22
{
    using RepetitionInterfacesCLO22.Enemies;
    using RepetitionInterfacesCLO22.Interfaces;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var ogre = new Ogre();
            ((IVillian)ogre).Hello();

            IVillian evil = GetMonster();
            evil.Hello();
        }

        public static IVillian GetMonster()
        {
            var rnd = new Random();
            switch (rnd.Next(1, 4))
            {
                case 1: return new Ogre();
                case 2: return new Troll();
                default:
                    return new Monster();
            }
        }
    }
}
