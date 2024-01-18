using System;
using System.Collections.Generic;
using System.Linq.Expressions;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

using MyLibrary;

namespace LunarLander
{
    public class LunarLander : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        StateManager screen;

        public LunarLander()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            
            IsMouseVisible = true;

            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            _graphics.ApplyChanges();
        }

        protected override void Initialize()
        {
            screen = new StateManager(this);
            screen.Push(new Screens.Splash());

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

        }

        protected override void Update(GameTime gameTime)
        {
            //if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed
            //    || Keyboard.GetState().IsKeyDown(Keys.Escape))

            //{
            //    Exit();
            //}

            screen.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            screen.Draw(gameTime);

            //all possible letters & symbols
            //Font.WriteText(pb, 10, 10, 3, Color.White, "ABCDEFGHIJ");
            //Font.WriteText(pb, 10, 40, 3, Color.White, "KLMNOPQRST");
            //Font.WriteText(pb, 10, 70, 3, Color.White, "UVWXYZ1234");
            //Font.WriteText(pb, 10, 100, 3, Color.White, "56789.-/");

            base.Draw(gameTime);
        }
    }
}