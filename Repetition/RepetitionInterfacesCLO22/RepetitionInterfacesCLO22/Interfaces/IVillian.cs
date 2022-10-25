namespace RepetitionInterfacesCLO22.Interfaces
{
    interface IVillian
    {
        string Name { get; set; }
        int HP { get; set; } 
        int MaxHP { get; set; }

        void Attack();

        void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
}
