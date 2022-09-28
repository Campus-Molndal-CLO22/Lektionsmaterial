//----------------------------------------------------------------------------------------------------
// <copyright file="CodicStarScape.cs" company="Codic Education">
// By Marcus Medina, 2021- https://codic-education.azurewebsites.net/
// This file is subject to the terms and stated in MIT License,
// and is published for educational purpose by Codic Education AB
// </copyright>
// ---------------------------------------------------------------------------------------------------

namespace SimpleStarscape.ScreenStuff
{
    using SimpleStarscape.ScreenObjects;
    using System;
    using System.Linq;
    using System.Threading;

    /// <summary>
    /// Defines the <see cref="CodicStarScape" />.
    /// </summary>
    public class CodicStarScape
    {
        /// <summary>
        /// Defines the Amount Of Moving Stars..
        /// </summary>
        private const int AmountOfStars = 20;

        /// <summary>
        /// Defines the display height..
        /// </summary>
        private const int height = 24;

        /// <summary>
        /// Defines the display width..
        /// </summary>
        private const int width = 145;

        /// <summary>
        /// Defines the rnd.
        /// </summary>
        private readonly Random rnd = new();

        /// <summary>
        /// Defines the screen handler.
        /// </summary>
        private readonly ScreenHandler sh = new(width, height);

        /// <summary>
        /// Defines the GhostA.
        /// </summary>
        private MovingSprite GhostA;

        /// <summary>
        /// Defines the GhostB.
        /// </summary>
        private MovingSprite GhostB;

        /// <summary>
        /// Defines the Message.
        /// </summary>
        private MovingSprite Message;

        /// <summary>
        /// Defines the Pacman.
        /// </summary>
        private MovingSprite Pacman;

        /// <summary>
        /// Defines the Stars.
        /// </summary>
        private MovingStar[] Stars;

        /// <summary>
        /// Defines the Ufo.
        /// </summary>
        private MovingSprite Ufo;

        /// <summary>
        /// Defines the UfoDirX.
        /// </summary>
        private int UfoDirX = 1;

        /// <summary>
        /// Defines the UfoDirY.
        /// </summary>
        private int UfoDirY = 1;

        private int speed = 110;

        /// <summary>
        /// The main method to run the starscape.
        /// </summary>
        public void TakeMeToTheStars()
        {
            Console.CursorVisible = false;
            Console.WindowWidth = 150;
            Stars = new MovingStar[AmountOfStars];
            CreateMessage();
            CreateStaticStars();
            CreateMovingStars();
            CreateCodicEducationSign();
            CreatePacman();
            CreateGhosts();
            CreateUfo();
            CreateFrame();
            sh.ShowScreen();
            var lastDimension = (Console.WindowWidth, Console.WindowHeight);
            const bool showUfo = true;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey().Key;
                    if (key is ConsoleKey.Escape or ConsoleKey.Enter) break;
                    if (key == ConsoleKey.UpArrow) { SetSpeed(-10); }
                    if (key == ConsoleKey.DownArrow) { SetSpeed(10); }
                }

                // Force redraw if the console is resized
                if (Console.WindowHeight != lastDimension.WindowHeight || Console.WindowWidth != lastDimension.WindowWidth)
                {
                    sh.ShowScreen();
                    lastDimension = (Console.WindowWidth, Console.WindowHeight);
                }

                MoveStars();
                const int middle = 56;
                sh.DrawSprite(Message, false);
                Message.MoveSprite();
                sh.DrawSprite(Message);

                sh.DrawSprite(Pacman,false);
                Pacman.MoveSprite(1);
                sh.DrawSprite(Pacman);
                if (Pacman.X > width) Pacman.X = -130;

                sh.DrawSprite(GhostA,false);
                GhostA.Layer = GhostA.X > middle ? LayerType.Pacman : LayerType.PacGhosts;
                GhostA.MoveSprite(1);
                sh.DrawSprite(GhostA);
                if (GhostA.X > width) GhostA.X = -130;

                sh.DrawSprite(GhostB,false);
                GhostB.Layer = GhostB.X > middle ? LayerType.Pacman : LayerType.PacGhosts;
                GhostB.MoveSprite(1);
                sh.DrawSprite(GhostB);
                if (GhostB.X > width) GhostB.X = -130;

#pragma warning disable CS0162 // Don't nag about Unreachable code detected
                // flag is set to false to not show the UFO, because less is more
                // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                if (showUfo)
                {
                    MoveUfo();
                }
#pragma warning restore CS0162 // OK, keep nagging about Unreachable code detected
                sh.RefreshScreen();
                Thread.Sleep(speed);
            }
            Console.Clear();
        }

        private void CreateFrame()
        {
            const char topLeft = '┌';
            const char topright = '┐';
            const char bottomLeft = '└';
            const char bottomRight = '┘';
            const char side = '│';
            const char laying = '─';
            sh.PrintAt(LayerType.Frame, 0, 0, new string(laying, width - 1));
            sh.PrintAt(LayerType.Frame, 0, 0, topLeft.ToString());
            sh.PrintAt(LayerType.Frame, width - 1, 0, topright.ToString());
            sh.PrintAt(LayerType.Frame, 0, height - 1, new string(laying, width - 1));
            sh.PrintAt(LayerType.Frame, 0, height - 1, bottomLeft.ToString());
            sh.PrintAt(LayerType.Frame, width - 1, height - 1, bottomRight.ToString());
            for (var y = 1; y < height - 1; y++)
            {
                sh.PrintAt(LayerType.Frame, 0, y, side + new string('\0', width - 2) + side);
            }
        }

        private void SetSpeed(int add)
        {
            speed += add;
            if (speed < 10) speed = 10;
            if (speed > 200) speed = 200;
            sh.PrintAt(LayerType.EscapeText, 0, 0, "                      ");
            sh.PrintAt(LayerType.EscapeText, 0, 0, "Thread.Sleep(" + speed + ")");
        }

        /// <summary>
        /// Create the Codic Education Sign.
        /// </summary>
        private void CreateCodicEducationSign()
        {
            var text = new string[11];
            var row = 0;
            text[row++] = "                                                                                                             ";
            text[row++] = "                             .__                                                       .__                  ";
            text[row++] = "                             |__|                                                      |__|                 ";
            text[row++] = "                                                                                                             ";
            text[row++] = "    _________            .___.__            ___________    .___                    __  .__                  ";
            text[row++] = @"    \_§§§___§\  ____   __|§_/|§§| ____      \_§§§_____/  __|§_/_ __   ____ _____ _/§§|_|§§| ____   ____     ";
            text[row++] = @"    /§§§§\  \/ /§§_§\ /§__§| |§§|/ ___\      |§§§§__)_  /§__§|§§|§§\_/§___\\__§§\\§§§__\§§|/§§_§\ /§§§§\    ";
            text[row++] = @"    \§§§§§\___(§§<_>§)§/_/§| |§§\§§\___      |§§§§§§§§\/§/_/§|§§|§§/\§§\___ /§__§\|§§| |§§(§§<_>§)§§§|§§\   ";
            text[row++] = @"     \______§§/\____/\____§| |__|\___§§>    /_______§§/\____§|____/  \___§§>____§§/__|§|__|\____/|___|§§/   ";
            text[row++] = @"            \/            \/         \/             \/      \/           \/     \/                    \/    ";
            text[row] = "                                                                                                            ";

            for (var i = 0; i < text.Length; i++)
            {
                sh.Center(LayerType.CodicText, 5 + i, text[i].Replace(' ', '\0').Replace('§', ' '));
            }
        }

        /// <summary>
        /// Creates the ghost sprites.
        /// </summary>
        private void CreateGhosts()
        {
            GhostA = new MovingSprite
            {
                FaceA = new string[]
                {
                    "  .-.  ",
                    " |§OO| ",
                    " |§§§| ",
                    " '^^^' "
                },
                FaceB = new string[] {
                    "  .-.  ",
                    " |OO§| ",
                    " |§§§| ",
                    " '^^^' "
                },
                X = -119,
                Y = 10,
                MaxWidth = width,
                Maxheight = height,
                SwapCounter = 3,
                Layer = LayerType.Pacman
            };
            GhostB = new MovingSprite
            {
                FaceA = GhostA.FaceB,
                FaceB = GhostA.FaceA,
                X = -127,
                Y = 12,
                MaxWidth = width,
                Maxheight = height,
                SwapCounter = 4,
                Layer = LayerType.PacGhosts
            };
        }

        /// <summary>
        /// Creates the escape message sprite.
        /// </summary>
        private void CreateMessage()
        {
            Message = new MovingSprite
            {
                FaceA = new string[] { "Press\0ESC\0to\0enter", "                     " },
                FaceB = new string[] { "Press\0ESC\0to\0enter", "or\0ENTER\0to\0escape" },
                X = width-22,
                Y = height-4,
                MaxWidth = width,
                Maxheight = height,
                SwapCounter = 5,
                Layer = LayerType.EscapeText
            };
        }

        /// <summary>
        /// Creates the Moving Stars.
        /// </summary>
        private void CreateMovingStars()
        {
            for (var i = 0; i < AmountOfStars; i++)
            {
                Stars[i] = new MovingStar
                {
                    X = rnd.Next(0, width),
                    Y = rnd.Next(0, height),
                    Xdir = rnd.Next(0, 3) - 1,
                    Ydir = -1,
                    MaxX = width,
                    MaxY = height
                };
            }
            Stars = Stars.OrderBy(s => s.Y).ToArray();
        }

        /// <summary>
        /// Creates the Pacman sprite.
        /// </summary>
        private void CreatePacman()
        {
            Pacman = new MovingSprite
            {
                FaceA = new string[]
                {
                    "  .--.  ",
                    " /§_.-' ",
                   @" \§§'-. ",
                    "  '--'  "
                },
                FaceB = new string[] {
                    "  .--.  ",
                    " /§___' ",
                   @" \§§''. ",
                    "  '--'  "
                },
                X = -100,
                Y = 7,
                MaxWidth = width,
                Maxheight = height,
                SwapCounter = 2,
                Layer = LayerType.Pacman
            };
        }

        /// <summary>
        /// Create the Static Stars.
        /// </summary>
        private void CreateStaticStars()
        {
            for (var i = 0; i < 60; i++)
            {
                sh.PrintAt(LayerType.Stars, rnd.Next(0, width), rnd.Next(0, height), ".");
            }
            for (var i = 0; i < 2; i++)
            {
                sh.PrintAt(LayerType.Stars, rnd.Next(0, width), rnd.Next(0, height), "+");
                sh.PrintAt(LayerType.Stars, rnd.Next(0, width), rnd.Next(0, height), "*");
            }
        }

        /// <summary>
        /// Create the Ufo sprite.
        /// </summary>
        private void CreateUfo()
        {
            Ufo = new MovingSprite
            {
                FaceA = new string[]
                    {
                            "                                          ",
                            "                 _,--=--._                ",
                            "               ,'    _    `.              ",
                            "              -    _(∞)_o   -             ",
                            "         ____'   /_§§§_/]    `____        ",
                            "  -=====::(+):::::::::::::::::(+)::=====- ",
                            "           (+).~~~~~~~~~~~~~,(+)          ",
                            "               .§§§§§§§§§§§,              ",
                            "                 `  -=-  '                ",
                            "                                          "
                    },
                FaceB = new string[]
                {
                            "                                          ",
                            "                 _,--=--._                ",
                            "               ,'    _    `.              ",
                            "              -    _(∞)_o   -             ",
                            "         ____'   _/§§§_/]    `____        ",
                            "  -=====::(+):::::::::::::::::(+)::=====- ",
                            "           (+).~~~~~~~~~~~~~,(+)          ",
                            "               .§§§§§§§§§§§,              ",
                            "                 `  -=-  '                ",
                            "                                          "
                },
                X = -100,
                Y = -180,
                MaxWidth = width,
                Maxheight = height,
                SwapCounter = 5,
                Layer = LayerType.Ufo
            };
        }

        /// <summary>
        /// Move the stars.
        /// </summary>
        private void MoveStars()
        {
            for (var i = 0; i < Stars.Length; i++)
            {
                sh.PrintAt(LayerType.MovingStars, Stars[i].X, Stars[i].Y, "\0");
                var ch = Stars[i].Y is < 8 or > 16 ? "°" : ".";
                Stars[i].MoveStar();
                sh.PrintAt(LayerType.MovingStars, Stars[i].X, Stars[i].Y, ch);
            }
        }

        /// <summary>
        /// Move the Ufo.
        /// </summary>
        private void MoveUfo()
        {
            if (UfoDirX + Ufo.X > width - 25) UfoDirX = -1;
            if (UfoDirX + Ufo.X < 0) UfoDirX = 1;
            if (UfoDirY + Ufo.Y > height - 8) UfoDirY = -1;
            if (UfoDirY + Ufo.Y < 0) UfoDirY = 1;
            sh.DrawSprite(Ufo,false);
            Ufo.MoveSprite(UfoDirX, UfoDirY);
            sh.DrawSprite(Ufo);
        }
    }
}