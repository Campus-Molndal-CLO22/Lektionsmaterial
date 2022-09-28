//----------------------------------------------------------------------------------------------------
// <copyright file="Layer.cs" company="Codic Education">
// By Marcus Medina, 2021- https://codic-education.azurewebsites.net/
// This file is subject to the terms and stated in MIT License,
// and is published for educational purpose by Codic Education AB
// </copyright>
// ---------------------------------------------------------------------------------------------------

namespace SimpleStarscape.ScreenStuff
{
    /// <summary>
    /// Defines the <see cref="Layer" />.
    /// </summary>
    public class Layer
    {
        /// <summary>
        /// Gets or sets the Chars
        /// The Character array.
        /// Used a jagged array to make it easier for Console Writeline to handle.
        /// </summary>
        public char[][] Chars { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Layer"/> class.
        /// </summary>
        /// <param name="width">The width<see cref="int"/>.</param>
        /// <param name="height">The height<see cref="int"/>.</param>
        public Layer(int width, int height)
        {
            Chars = new char[height][];
            for (int i = 0; i < height; i++)
            {
                Chars[i] = new char[width];
            }
        }
    }
}