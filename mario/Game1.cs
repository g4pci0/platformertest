﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace mario
{
    public class Game1 : Game
    {

        Texture2D marioSpriteSheet;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        
        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content/sprites";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
            
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here

            marioSpriteSheet = Content.Load<Texture2D>("marioSpriteSheet");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();
            _spriteBatch.Draw(marioSpriteSheet, new Vector2(0, 0), new Rectangle(0, 0, 16, 16), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}