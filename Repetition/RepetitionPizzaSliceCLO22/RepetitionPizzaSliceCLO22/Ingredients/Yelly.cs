namespace RepetitionPizzaSliceCLO22.Models.Ingredients
{
    using RepetitionPizzaSliceCLO22.Interfaces;

    public class Yelly : IIngredients
    {
        public string Name { get; set; }
        public int AmountInGram { get; set; }
        public float Price { get; set; }

        public Yelly()
        {
            Name = "Yelly";
            AmountInGram = 45;
            Price = 30;
        }
    }

}
