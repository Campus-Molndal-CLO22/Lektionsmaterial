namespace RepetitionPizzaSliceCLO22.Models.Ingredients
{
    using RepetitionPizzaSliceCLO22.Interfaces;

    /// <summary>
    /// Apple slices
    /// </summary>
    public class Apple : IIngredients
    {
        public string Name { get; set; }
        public int AmountInGram { get; set; }
        public float Price { get; set; }

        public Apple()
        {
            Name = "Apple";
            AmountInGram = 45;
            Price = 10;
        }
    }

}
