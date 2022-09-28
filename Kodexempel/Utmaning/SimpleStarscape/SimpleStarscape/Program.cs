//----------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Codic Education">
// By Marcus Medina, 2021- https://codic-education.azurewebsites.net/
// This file is subject to the terms and stated in MIT License,
// and is published for educational purpose by Codic Education AB
// </copyright>
// ---------------------------------------------------------------------------------------------------

namespace SimpleStarscape
{
    using SimpleStarscape.ScreenStuff;

    /// <summary>
    /// Defines the <see cref="Program" />.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The Main method.
        /// </summary>
        private static void Main()
        {
            var css = new CodicStarScape();
            css.TakeMeToTheStars();
        }
    }
}