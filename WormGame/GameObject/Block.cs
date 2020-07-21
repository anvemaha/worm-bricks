﻿using Otter.Graphics;
using WormGame.Core;
using WormGame.Pooling;

namespace WormGame.GameObject
{
    /// @author Antti Harju
    /// @version 18.07.2020
    /// <summary>
    /// Brick class. Work in progress.
    /// </summary>
    public class Block : PoolableEntity
    {
        private BlockModule firstModule;

        public override Color Color { get { return firstModule.Graphic.Color ?? null; } set { SetColor(value); } }

        public void SetColor(Color color)
        {
            firstModule.SetColor(color);
        }

        public Block Spawn(Worm worm, Pooler<BlockModule> blockModules, int currentLength)
        {
            X = worm.X;
            Y = worm.Y;

            firstModule = blockModules.Enable();
            if(firstModule == null)
            {
                Disable();
                return null;
            }
            firstModule.CopyWormModule(worm, worm.firstModule, this, blockModules, currentLength);

            return this;
        }

        public override void Disable()
        {
            firstModule.Disable(Position);
            ClearGraphics();
            Enabled = false;
        }
    }
}