namespace RepetitionPizzaSliceCLO22.Models
{
    using RepetitionPizzaSliceCLO22.Interfaces;

    public class RamdomizzaSette : RamdomizzaTre, IPizza
    {
        /// <summary>
        /// Anropar sin moderklass med parametern 7
        /// </summary>
        public RamdomizzaSette() : base(7)
        {
        }
    }
}
