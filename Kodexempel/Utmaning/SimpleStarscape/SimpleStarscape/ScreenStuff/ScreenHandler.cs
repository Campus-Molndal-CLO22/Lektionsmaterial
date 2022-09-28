//----------------------------------------------------------------------------------------------------
// <copyright file="ScreenHandler.cs" company="Codic Education">
// By Marcus Medina, 2021- https://codic-education.azurewebsites.net/
// This file is subject to the terms and stated in MIT License,
// and is published for educational purpose by Codic Education AB
// </copyright>
// ---------------------------------------------------------------------------------------------------

namespace SimpleStarscape.ScreenStuff
{
    using SimpleStarscape.ScreenObjects;
    using System;

    /// <summary>
    /// Defines the <see cref="ScreenHandler" />.
    /// </summary>
    public class ScreenHandler
    {
        /// <summary>
        /// Defines the Stars layer..
        /// </summary>
        private readonly Layer Stars;

        /// <summary>
        /// Defines the Frame layer..
        /// </summary>
        private readonly Layer Frame;

        /// <summary>
        /// Defines the Pacman & Ghost A layer..
        /// </summary>
        private readonly Layer Pacman;

        /// <summary>
        /// Defines the Moving Stars layer..
        /// </summary>
        private readonly Layer MovingStars;

        /// <summary>
        /// Defines the Codic Text layer..
        /// </summary>
        private readonly Layer CodicText;

        /// <summary>
        /// Defines the Pac Ghost B layer..
        /// </summary>
        private readonly Layer PacGhosts;

        /// <summary>
        /// Defines the Ufo.
        /// </summary>
        private readonly Layer Ufo;

        /// <summary>
        /// Defines the Display layer (the one that gets printed out)..
        /// </summary>
        private readonly Layer Display;

        /// <summary>
        /// Defines the System Message layer..
        /// </summary>
        private readonly Layer EscapeText;

        /// <summary>
        /// Defines the UpdateRow array, to keep track of what rows need to be updated..
        /// </summary>
        private readonly bool[] UpdateRow;

        /// <summary>
        /// Initializes a new instance of the <see cref="ScreenHandler"/> class.
        /// </summary>
        /// <param name="width">The width<see cref="int"/>.</param>
        /// <param name="height">The height<see cref="int"/>.</param>
        public ScreenHandler(int width, int height)
        {
            Width = width;
            Height = height;
            Stars = new(width, height);
            Frame = new(width, height);
            MovingStars = new(width, height);
            CodicText = new(width, height);
            Pacman = new(width, height);
            PacGhosts = new(width, height);
            Ufo = new(width, height);
            EscapeText = new(width, height);
            Display = new(width, height);
            UpdateRow = new bool[height];
        }

        /// <summary>
        /// Gets or sets the Width.
        /// </summary>
        public int Width { get; set; } = 50;

        /// <summary>
        /// Gets or sets the Height.
        /// </summary>
        public int Height { get; set; } = 20;

        /// <summary>
        /// Clears screen and displays it all.
        /// </summary>
        public void ShowScreen()
        {
            Console.CursorVisible = false;
            Console.Clear();
            for (int y = 0; y < Height; y++)
            {
                UpdateRow[y] = true;
            }
            RefreshScreen();
        }

        /// <summary>
        /// Refresh only changed rows.
        /// </summary>
        public void RefreshScreen()
        {
            var mainX = (Console.WindowWidth / 2) - (Width / 2);
            if (mainX < 0) mainX = 0;
            var mainY = (Console.WindowHeight / 2) - (Height / 2);
            if (mainY < 0) mainY = 0;

            for (int y = 0; y < Height; y++)
            {
                Console.SetCursorPosition(mainX, mainY + y);
                if (UpdateRow[y])
                {
                    Console.Write(new string(Display.Chars[y]).Replace("\0", " ").Replace('§', ' '));
                }
                UpdateRow[y] = false;
            }
        }

        /// <summary>
        /// The specific row.
        /// </summary>
        /// <param name="row">The row<see cref="int"/>.</param>
        public void RefreshRow(int row)
        {
            var mainX = (Console.WindowWidth / 2) - (Width / 2);
            if (mainX < 0) mainX = 0;
            var mainY = (Console.WindowHeight / 2) - (Height / 2);
            if (mainY < 0) mainY = 0;

            Console.SetCursorPosition(mainX, mainY + row);
            Console.Write(new string(Display.Chars[row]).Replace("\0", " "));
        }

        /// <summary>
        /// Set text at given layer and position.
        /// </summary>
        /// <param name="layerType">The layerType<see cref="LayerType"/>.</param>
        /// <param name="x">The x<see cref="int"/>.</param>
        /// <param name="y">The y<see cref="int"/>.</param>
        /// <param name="text">The text<see cref="string"/>.</param>
        public void PrintAt(LayerType layerType, int x, int y, string text)
        {
            var layer = GetLayer(layerType);
            for (int i = 0; i < text.Length; i++)
            {
                var pos = x + i;
                var ch = text[i];
                if (pos < Width && pos >= 0 && y >= 0 && y < Height)
                {
                    layer.Chars[y][pos] = ch;
                    ch = GetTopCharacter(pos, y, ch);
                    Display.Chars[y][pos] = ch;
                    UpdateRow[y] = true;
                }
            }
        }

        /// <summary>
        /// The top visible character from the layers.
        /// </summary>
        /// <param name="x">The x<see cref="int"/>.</param>
        /// <param name="y">The y<see cref="int"/>.</param>
        /// <param name="ch">The ch<see cref="char"/>.</param>
        /// <returns>The <see cref="char"/>.</returns>
        private char GetTopCharacter(int x, int y, char ch)
        {
            if (Frame.Chars[y][x] > 0) return Frame.Chars[y][x];
            else if (Pacman.Chars[y][x] > 0) return Pacman.Chars[y][x];
            else if (CodicText.Chars[y][x] > 0) return CodicText.Chars[y][x];
            else if (PacGhosts.Chars[y][x] > 0) return PacGhosts.Chars[y][x];
            else if (Ufo.Chars[y][x] > 0) return Ufo.Chars[y][x];
            else if (EscapeText.Chars[y][x] > 0) return EscapeText.Chars[y][x];
            else if (MovingStars.Chars[y][x] > 0) return MovingStars.Chars[y][x];
            else if (Stars.Chars[y][x] > 0) return Stars.Chars[y][x];
            return ch;
        }

        /// <summary>
        /// Get a layer from given layerType.
        /// </summary>
        /// <param name="layerType">The layerType<see cref="LayerType"/>.</param>
        /// <returns>The <see cref="Layer"/>.</returns>
        public Layer GetLayer(LayerType layerType)
        {
            var layer = layerType switch
            {
                LayerType.Stars => Stars,
                LayerType.Frame => Frame,
                LayerType.Pacman => Pacman,
                LayerType.CodicText => CodicText,
                LayerType.EscapeText => EscapeText,
                LayerType.PacGhosts => PacGhosts,
                LayerType.MovingStars => MovingStars,
                LayerType.Ufo => Ufo,
                _ => EscapeText,
            };
            return layer;
        }

        /// <summary>
        /// Center text at given layer and position.
        /// </summary>
        /// <param name="layerType">The layerType<see cref="LayerType"/>.</param>
        /// <param name="y">The y<see cref="int"/>.</param>
        /// <param name="text">The text<see cref="string"/>.</param>
        public void Center(LayerType layerType, int y, string text)
        {
            var pos = (Width / 2) - (text.Length / 2);
            PrintAt(layerType, pos, y, text);
        }

        /// <summary>
        /// Draw sprite on the sprite layer.
        /// </summary>
        /// <param name="sprite">The sprite<see cref="MovingSprite"/>.</param>
        /// <param name="showSprite">True if sprites is to be drawn, false to erase the sprite (before movement)</param>
        /// <returns>The <see cref="int"/>.</returns>
        public int DrawSprite(MovingSprite sprite, bool showSprite=true)
        {
            // Delete the sprite from the layer first
            // OBS! kind of wonky, needs more work
            var currentFace = sprite.LastFaceUsed == 0 ? sprite.FaceA : sprite.FaceB;
            var max = currentFace.Length;
            if (!showSprite)
            {
                for (int y = 0; y < currentFace.Length; y++)
                {
                    for (int x = 0; x < currentFace[y].Length; x++)
                    {
                        PrintAt(sprite.Layer, sprite.X + x, sprite.Y + y, "\0");
                    }
                }
            }
            else
            {
                // Draw the layer
                currentFace = sprite.FaceSelected == 0 ? sprite.FaceA : sprite.FaceB;
                if (currentFace.Length > max) max = currentFace.Length;
                for (int y = 0; y < currentFace.Length; y++)
                {
                    for (int x = 0; x < currentFace[y].Length; x++)
                    {
                        var symbol = currentFace[y][x];
                        if (symbol == ' ') symbol = '\0';
                        else if (symbol == '§') symbol = ' ';
                        PrintAt(sprite.Layer, sprite.X + x, sprite.Y + y, symbol.ToString());
                    }
                }
            }
            return max;
        }
    }
}