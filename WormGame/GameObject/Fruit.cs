﻿using Otter.Graphics;
using Otter.Graphics.Drawables;
using Otter.Utility.MonoGame;
using WormGame.Core;
using WormGame.Pooling;

namespace WormGame.GameObject
{
    public class Fruit : Poolable
    {
        private readonly Collision field;


        public Fruit(Config config) : base()
        {
            field = config.field;
            Image image = Image.CreateRectangle(config.size);
            AddGraphic(image);
            image.CenterOrigin();
        }


        public Fruit Spawn(int x, int y, Color color)
        {
            X = field.EntityX(x);
            Y = field.EntityY(y);
            field.Set(this, Position);
            return this;
        }
    }
}
