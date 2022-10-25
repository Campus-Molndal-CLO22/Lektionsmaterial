namespace RepetitionPizzaSliceCLO22.Models.Ingredients
{
    using RepetitionPizzaSliceCLO22.Interfaces;

    public class Cinnamon : IIngredients
    {
        public string Name { get; set; }
        public int AmountInGram { get; set; }
        public float Price { get; set; }

        public Cinnamon()
        {
            Name = "Cinnamon";
            AmountInGram = 45;
            Price = 10;
        }
    }

}
