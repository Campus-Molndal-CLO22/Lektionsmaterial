namespace RepetitionPizzaSliceCLO22.Interfaces
{
    public interface IPizza
    {
        /// <summary>
        /// List of ingredients
        /// </summary>
        List<IIngredients> Ingredients { get; set; }
        /// <summary>
        /// The price of the pizza
        /// </summary>
        float Price { get; set; }
    }
}
