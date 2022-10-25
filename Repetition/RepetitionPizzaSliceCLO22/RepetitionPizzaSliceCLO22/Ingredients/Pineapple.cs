namespace RepetitionPizzaSliceCLO22.Models.Ingredients
{
    using RepetitionPizzaSliceCLO22.Interfaces;

    public class Pineapple : IIngredients
    {
        public string Name { get; set; }
        public int AmountInGram { get; set; }
        public float Price { get; set; }

        public Pineapple()
        {
            Name = "Pineapple";
            AmountInGram = 20;
            Price = 10;
        }
    }

}
