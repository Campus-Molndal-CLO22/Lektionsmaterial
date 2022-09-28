//----------------------------------------------------------------------------------------------------
// <copyright file="MovingSprite.cs" company="Codic Education">
// By Marcus Medina, 2021- https://codic-education.azurewebsites.net/
// This file is subject to the terms and stated in MIT License,
// and is published for educational purpose by Codic Education AB
// </copyright>
// ---------------------------------------------------------------------------------------------------

namespace SimpleStarscape.ScreenObjects
{
    using SimpleStarscape.ScreenStuff;

    /// <summary>
    /// Defines the <see cref="MovingSprite" />.
    /// </summary>
    public class MovingSprite
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
        /// Gets or sets the max width of the screen..
        /// </summary>
        public int MaxWidth { get; set; }

        /// <summary>
        /// Gets or sets the max height of the screen..
        /// </summary>
        public int Maxheight { get; set; }

        /// <summary>
        /// Gets or sets the first face of the sprite (string array)..
        /// </summary>
        public string[] FaceA { get; set; } = new string[] { "Hello" };

        /// <summary>
        /// Gets or sets the second face of the sprite (string array)..
        /// </summary>
        public string[] FaceB { get; set; } = new string[] { "World" };

        /// <summary>
        /// Defines the faceCounter to keep track of the face used..
        /// </summary>
        private int faceCounter;

        /// <summary>
        /// Gets or sets the SwapCounter, how many movements should pass before changing face..
        /// </summary>
        public int SwapCounter { get; set; } = 5;

        /// <summary>
        /// Gets or sets the Layer where to draw the sprite..
        /// </summary>
        public LayerType Layer { get; set; }

        /// <summary>
        /// Gets or sets the current face displayed..
        /// </summary>
        public int FaceSelected { get; set; } = 0;

        /// <summary>
        /// Gets or sets the Last Face Used..
        /// </summary>
        public int LastFaceUsed { get; set; } = 0;

        /// <summary>
        /// Sprite movement according to the X and Y plus and minus values.
        /// </summary>
        /// <param name="Xdir">The Xdir<see cref="int"/>.</param>
        /// <param name="Ydir">The Ydir<see cref="int"/>.</param>
        public void MoveSprite(int Xdir = 0, int Ydir = 0)
        {
            X += Xdir;
            Y += Ydir;
            LastFaceUsed = FaceSelected;

            faceCounter++;
            if (faceCounter > SwapCounter)
            {
                faceCounter = 0;
                FaceSelected++;
                if (FaceSelected > 1) FaceSelected = 0;
            }
        }
    }
}