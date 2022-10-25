namespace RepetitionPizzaSliceCLO22.Extensions
{
    public static class StringExtender
    {
        /// <summary>
        /// Omvandlar från string till int
        /// </summary>
        /// <param name="input">Strängen som ska omvanndlas</param>
        /// <returns>Det omvandlade talet</returns>
        public static int ToInt(this string input)
        {
            int.TryParse(input, out int result);
            return result;
        }

    }
}
