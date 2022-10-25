namespace RepetitionPizzaSliceCLO22.Models.Ingredients
{
    using RepetitionPizzaSliceCLO22.Interfaces;

    public class Turkey : IIngredients
    {
        public string Name { get; set; }
        public int AmountInGram { get; set; }
        public float Price { get; set; }

        public Turkey()
        {
            Name = "Turkey";
            AmountInGram = 50;
            Price = 30;
        }
    }

}
