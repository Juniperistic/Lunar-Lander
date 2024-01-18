using System;
using System.Collections.Generic;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


using MyLibrary;

namespace LunarLander.Screens 
{
    public class Play : GameScreen
    {
        PrimitiveBatch pb;

        Lander lander;
        Terrain terrain;

        public float textScale;

        public Play()
        {
            LoadContent();
        }

        public override void LoadContent()
        {
            pb = new PrimitiveBatch(StateManager.GraphicsDevice);

            terrain = new Terrain(StateManager.Game);
            terrain.Initialize();

            lander = new Lander(StateManager.Game);
            lander.Initialize();

            textScale = 1.5f;    
        }

        public override void Update(GameTime gameTime, StateManager screen,
            GamePadState gamePadState, MouseState mouseState,
            KeyboardState keyState, InputHandler input)
        {
            if(input.KeyboardState.WasKeyPressed(Keys.P) ||
                input.WasPressed(0, InputHandler.ButtonType.Start, Keys.Delete))
            {
                Pause pause = new Pause();              
                screen.Push(pause);
            }

            if (input.KeyboardState.WasKeyPressed(Keys.Escape) ||
              input.WasPressed(0, InputHandler.ButtonType.B, Keys.B))
            {
                input.Dispose();

                screen.Pop();
            }

            lander.Update(gameTime);
            terrain.Update(gameTime);

        }

        public override void Draw(GameTime gameTime)
        {
           StateManager.GraphicsDevice.Clear(Color.Black);

            lander.Draw(gameTime);
            terrain.Draw(gameTime);

            //all possible letters & symbols
            //Font.WriteText(pb, 10, 10, 3, Color.White, "ABCDEFGHIJ");
            //Font.WriteText(pb, 10, 40, 3, Color.White, "KLMNOPQRST");
            //Font.WriteText(pb, 10, 70, 3, Color.White, "UVWXYZ1234");
            //Font.WriteText(pb, 10, 100, 3, Color.White, "56789.-/");

        }
    }
}

