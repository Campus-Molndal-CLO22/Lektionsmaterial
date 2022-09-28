//----------------------------------------------------------------------------------------------------
// <copyright file="MovingStar.cs" company="Codic Education">
// By Marcus Medina, 2021- https://codic-education.azurewebsites.net/
// This file is subject to the terms and stated in MIT License,
// and is published for educational purpose by Codic Education AB
// </copyright>
// ---------------------------------------------------------------------------------------------------

namespace SimpleStarscape.ScreenObjects
{
    using System;

    /// <summary>
    /// Defines the <see cref="MovingStar" />.
    /// </summary>
    public class MovingStar
    {
        /// <summary>
        /// Gets or sets the X position..
        /// </summary>
        public int X { get; set; }

        /// <summary>
        /// Gets or sets the Y position..
        /// </summary>
        public int Y { get; set; }

        /// <summary>
        /// Gets or sets the MaxX (width of the screen)..
        /// </summary>
        public int MaxX { get; set; }

        /// <summary>
        /// Gets or sets the MaxY (height of the screen)..
        /// </summary>
        public int MaxY { get; set; }

        /// <summary>
        /// Gets or sets the X direction..
        /// </summary>
        public int Xdir { get; set; }

        /// <summary>
        /// Gets or sets the Y direction..
        /// </summary>
        public int Ydir { get; set; }

        /// <summary>
        /// Defines the rnd.
        /// </summary>
        private static readonly Random rnd = new();

        /// <summary>
        /// Moves the star and randomizes position when the border is reached.
        /// </summary>
        public void MoveStar()
        {
            X += Xdir;
            Y += Ydir;
            if (X < 0) { Y = rnd.Next(0, MaxY); X = MaxX - 1; }
            if (X >= MaxX) { Y = rnd.Next(0, MaxY); X = 0; }
            if (Y < 0) { Y = MaxY - 1; X = rnd.Next(0, MaxX); }
            if (Y >= MaxY) { Y = 0; X = rnd.Next(0, MaxX); }
        }
    }
}