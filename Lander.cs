using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MyLibrary;
using SharpDX.Direct2D1;

namespace LunarLander
{
    public class Lander : DrawableGameComponent
    {
        private PrimitiveBatch pb;

        List<SoundEffect> soundEffects;

        private Vector2 position;
        private float scale;

        private float fuel;
        TimeSpan elapsedTime;

        SpriteFont spriteFont;

        public float Fuel
        {
            get { return fuel; }
            set
            {

                {
                    if (value < 0) { fuel = 0; }
                    else if (value > 100) { fuel = 100; }
                    else { fuel = value; }
                }
            }
        }
        private KeyboardState oldKeyboardState;

        public Lander(Game game) : base(game)
        {
            pb = new PrimitiveBatch(game.GraphicsDevice);
        }

        public override void Initialize()
        {
            oldKeyboardState = new KeyboardState();

            position = new Vector2(20, 20);
            scale = 3;

            fuel = 100;

            soundEffects = new List<SoundEffect>();

            fuel = 100;
            elapsedTime = TimeSpan.Zero;

            base.Initialize();
        }


        protected override void LoadContent()
        {
            soundEffects.Add(StateManager.Content.Load<SoundEffect>("explosion")); //0
            soundEffects.Add(StateManager.Content.Load<SoundEffect>("success")); //1
            soundEffects.Add(StateManager.Content.Load<SoundEffect>("thrust")); //2

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            var instance = soundEffects[2].CreateInstance();

            KeyboardState newKeyboardState = Keyboard.GetState();

            if (newKeyboardState != oldKeyboardState)
            {
                if (Keyboard.GetState().IsKeyDown(Keys.Up))
                {
                    position += new Vector2(0, -1);
                }


                if (Keyboard.GetState().IsKeyDown(Keys.Down))
                {
                    position += new Vector2(0, 1);
                }
            }

            if (Keyboard.GetState().IsKeyDown(Keys.Space) && fuel > 0) //sound gets played in here
            {
                elapsedTime += gameTime.ElapsedGameTime;

                if (elapsedTime > TimeSpan.FromSeconds(1))
                {
                    elapsedTime -= TimeSpan.FromSeconds(1);

                    fuel -= 10;
                }

                if( instance.State != SoundState.Playing)
                {
                    instance.IsLooped = false;
                    instance.Play();
                }
            }

            if (Keyboard.GetState().IsKeyUp(Keys.Space) &&
                instance.State == SoundState.Playing)
            {
                instance.Stop();
            }

            oldKeyboardState = newKeyboardState;

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
      
            Font.WriteText(pb, 10, 10, 3, Color.White, string.Format("Fuel " + "{0:000}",(int)Fuel)); 

            DrawLander();

            base.Draw(gameTime);
        }

        public void DrawLander()
        {
            pb.Begin(PrimitiveType.LineList);

            pb.AddVertex(new Vector2(position.X * scale, position.Y * scale), Color.Green);
            pb.AddVertex(new Vector2((position.X + 5) * scale, position.Y * scale), Color.Green);

            pb.AddVertex(new Vector2((position.X + 5) * scale, position.Y * scale), Color.Green);
            pb.AddVertex(new Vector2((position.X + 5) * scale, (position.Y + 10) * scale), Color.Green);

            pb.AddVertex(new Vector2((position.X + 5) * scale, (position.Y + 10) * scale), Color.Green);
            pb.AddVertex(new Vector2(position.X * scale, (position.Y + 10) * scale), Color.Green);

            pb.AddVertex(new Vector2(position.X * scale, (position.Y + 10) * scale), Color.Green);
            pb.AddVertex(new Vector2(position.X * scale, position.Y * scale), Color.Green);

            pb.End();
        }

        //all draw methods go here such as velocity, score, etc
    }
}

