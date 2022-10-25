namespace RepetitionPizzaSliceCLO22.Models.Ingredients
{
    using RepetitionPizzaSliceCLO22.Interfaces;

    public class Gouda : IIngredients
    {
        public string Name { get; set; }
        public int AmountInGram { get; set; }
        public float Price { get; set; }

        public Gouda()
        {
            Name = "Gouda";
            AmountInGram = 100;
            Price = 3;
        }
    }
}
