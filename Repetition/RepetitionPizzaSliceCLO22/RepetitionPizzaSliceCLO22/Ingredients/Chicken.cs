namespace RepetitionPizzaSliceCLO22.Models.Ingredients
{
    using RepetitionPizzaSliceCLO22.Interfaces;

    public class Chicken : IIngredients
    {
        public string Name { get; set; }
        public int AmountInGram { get; set; }
        public float Price { get; set; }

        public Chicken()
        {
            Name = "Chicken";
            AmountInGram = 50;
            Price = 20;
        }
    }

}
