namespace RepetitionPizzaSliceCLO22.Models.Ingredients
{
    using RepetitionPizzaSliceCLO22.Interfaces;
    public class Rat : IIngredients
    {
        public string Name { get; set; }
        public int AmountInGram { get; set; }
        public float Price { get; set; }

        public Rat()
        {
            Name = "Rat";
            AmountInGram = 20;
            Price = 200;
        }
    }

}
