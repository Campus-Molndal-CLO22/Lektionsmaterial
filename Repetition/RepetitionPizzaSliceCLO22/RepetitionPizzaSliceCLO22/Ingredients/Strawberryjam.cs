namespace RepetitionPizzaSliceCLO22.Models.Ingredients
{
    using RepetitionPizzaSliceCLO22.Interfaces;

    public class Strawberryjam : IIngredients
    {
        public string Name { get; set; }
        public int AmountInGram { get; set; }
        public float Price { get; set; }

        public Strawberryjam()
        {
            Name = "Strawberry jam";
            AmountInGram = 50;
            Price = 45;
        }
    }

}
