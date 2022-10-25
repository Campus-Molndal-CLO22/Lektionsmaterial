namespace RepetitionPizzaSliceCLO22.Models.Ingredients
{
    using RepetitionPizzaSliceCLO22.Interfaces;

    public class PeanutButter : IIngredients
    {
        public string Name { get; set; }
        public int AmountInGram { get; set; }
        public float Price { get; set; }

        public PeanutButter()
        {
            Name = "Peanut butter";
            AmountInGram = 300;
            Price = 10;
        }
    }

}
