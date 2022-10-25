namespace RepetitionPizzaSliceCLO22.Models.Ingredients
{
    using RepetitionPizzaSliceCLO22.Interfaces;

    public class MashedPotatoes : IIngredients
    {
        public string Name { get; set; }
        public int AmountInGram { get; set; }
        public float Price { get; set; }

        public MashedPotatoes()
        {
            Name = "Mashed potatoes";
            AmountInGram = 150;
            Price = 5;
        }
    }
}
