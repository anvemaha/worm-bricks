﻿using Otter.Graphics;
using Otter.Graphics.Drawables;
using Otter.Utility.MonoGame;
using WormGame.Core;
using WormGame.Static;
using WormGame.Pooling;

namespace WormGame.Entities
{
    /// @author Antti Harju
    /// @version 14.08.2020
    /// <summary>
    /// Fruit class. Spawns automatically to a free position.
    /// </summary>
    public class Fruit : PoolableEntity
    {
        private readonly Collision collision;
        private readonly int width;
        private readonly int height;


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="config">Configuration</param>
        public Fruit(Config config)
        {
            collision = config.collision;
            width = config.width;
            height = config.height;
            Image image = Image.CreateCircle(config.size / 4, Color.Black);
            image.OutlineThickness = config.size / 6;
            image.OutlineColor = Color.White;
            image.CenterOrigin();
            AddGraphic(image);
        }


        /// <summary>
        /// Spawns fruit to a free position.
        /// </summary>
        /// <returns>Fruit or null</returns>
        public Fruit Spawn()
        {
            Vector2 random = Random.ValidPosition(collision, width, height, collision.empty);
            if (random.X == -1)
            {
                Disable();
                return null;
            }
            X = random.X;
            Y = random.Y;
            collision.Add(this, Position);
            return this;
        }
    }
}