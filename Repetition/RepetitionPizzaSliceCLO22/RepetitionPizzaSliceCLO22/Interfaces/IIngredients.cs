namespace RepetitionPizzaSliceCLO22.Interfaces
{
    /// <summary>
    /// Interface for ingredients
    /// </summary>
    public interface IIngredients
    {
        /// <summary>
        /// Gets or sets the name of the ingredient
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// Gets or sets the amount in grams
        /// </summary>
        int AmountInGram { get; set; }
        /// <summary>
        /// gets or sets the price
        /// </summary>
        float Price { get; set; }
    }
}