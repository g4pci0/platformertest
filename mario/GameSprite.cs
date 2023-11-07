using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace mario
{
    public abstract class GameSprite : GameObject
    {

        protected int _animFrame { get; set; }
        protected int _animFrameMax { get; set; }
        protected int _animSpeed { get; set; }

        public GameSprite(Texture2D sprite, Vector2 position, Rectangle bbox, int animFrame, int animFrameMax, int animSpeed) : base(sprite, position, bbox)
        {
            _animFrame = animFrame;
            _animFrameMax = animFrameMax;   
            _animSpeed = animSpeed;
        }

        override public void Update()
        {

        }
    }
}
