namespace RepetitionPizzaSliceCLO22.Models.Ingredients
{
    using RepetitionPizzaSliceCLO22.Interfaces;

    public class Mozzarella : IIngredients
    {
        public string Name { get; set; }
        public int AmountInGram { get; set; }
        public float Price { get; set; }

        public Mozzarella()
        {
            Name = "Mozzarella";
            AmountInGram = 100;
            Price = 10;
        }
    }

}
