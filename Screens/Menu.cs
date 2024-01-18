using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LunarLander.Screens
{
    public class Menu : GameScreen
    {
        SpriteBatch spriteBatch;
        SpriteFont spriteFont;

        public Menu()
        {
            LoadContent(); 
        }

        public override void LoadContent()
        {
            spriteBatch = new SpriteBatch(StateManager.GraphicsDevice);
            spriteFont = StateManager.Content.Load<SpriteFont>("font");

            StateManager.Game.Window.Title = "Lunar Lander";
        }

        public override void Update(GameTime gameTime, StateManager screen,
            GamePadState gamePadState, MouseState mouseState,
            KeyboardState keyState, InputHandler input)
        {
            if(input.KeyboardState.WasKeyPressed(Keys.Space) ||          //Main to Play
                input.WasPressed(0, InputHandler.ButtonType.A, Keys.A))
            {
                Play play = new Play();
                screen.Push(play);
            }

            if (input.KeyboardState.WasKeyPressed(Keys.CapsLock) ||       //Main to Options
               input.WasPressed(0, InputHandler.ButtonType.A, Keys.A))
            {
                Options options = new Options();
                screen.Push(options);
            }

            if (input.KeyboardState.WasKeyPressed(Keys.LeftShift) ||      //Main to Credits
               input.WasPressed(0, InputHandler.ButtonType.A, Keys.A))
            {
                Credits credits = new Credits();
                screen.Push(credits);
            }

            if (input.KeyboardState.WasKeyPressed(Keys.Escape) ||        //main to exit
              input.WasPressed(0, InputHandler.ButtonType.B, Keys.B))
            {
                StateManager.Game.Exit();
            }

        }

        public override void Draw(GameTime gameTime)
        {
            spriteBatch.Begin();

            Vector2 center = new Vector2(
                StateManager.GraphicsDevice.Viewport.Width / 2,
                    StateManager.GraphicsDevice.Viewport.Height / 2);

            Vector2 v = spriteFont.MeasureString("Main Menu") / new Vector2(2,2);

            spriteBatch.DrawString(spriteFont, "Main Menu", (center - v), Color.White);

            spriteBatch.End();
        }
    }
}

