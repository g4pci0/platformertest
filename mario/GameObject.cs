using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace mario
{
    public abstract class GameObject
    {
        protected Texture2D _sprite;
        protected Vector2 _position;
        protected Rectangle _bbox;

        public GameObject(Texture2D sprite, Vector2 position, Rectangle bbox)
        {
            _sprite = sprite;
            _position = position;
            _bbox = bbox;
        }

        public virtual void Update() { }
        public virtual void Draw() { }
    }
}
