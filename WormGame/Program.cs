﻿using Otter.Core;
using WormGame.Core;

namespace WormGame
{
    /// @author Antti Harju
    /// @version 14.08.2020
    /// <summary>
    /// See README.md for an explanation of game mechanics.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        public static void Main()
        {
            System.Console.ForegroundColor = System.ConsoleColor.DarkGray;
            Config config = new Config();
            Game game = new Game("Worm Blocks", config.windowWidth, config.windowHeight, config.refreshRate, config.fullscreen)
            {
                WindowResize = false,
                AlwaysUpdate = true,
                MouseVisible = true
            };
            game.Start(config.scene);
        }
    }
}