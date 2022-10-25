namespace RepetitionPizzaSliceCLO22.Models.Ingredients
{
    using RepetitionPizzaSliceCLO22.Interfaces;

    public class Surströmming : IIngredients
    {
        public string Name { get; set; }
        public int AmountInGram { get; set; }
        public float Price { get; set; }

        public Surströmming()
        {
            Name = "Surströmming";
            AmountInGram = 5;
            Price = -10; // We pay you if you eat it!
        }
    }
}
