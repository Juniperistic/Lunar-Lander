using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using MyLibrary;
using Microsoft.Xna.Framework.Input;

namespace LunarLander
{
    public class Terrain : DrawableGameComponent
    {
        public LinkedList<Vector2> terrain;
        public LinkedList<Vector2> pads;

        PrimitiveBatch pb;

        public Terrain(Game game) : base(game)
        {
            terrain = new LinkedList<Vector2>();
            pads = new LinkedList<Vector2>();

            LoadTerrain();
            LoadPads();

        }

        public override void Initialize()
        {
            pb = new PrimitiveBatch(Game.GraphicsDevice);

            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            pb.Begin(PrimitiveType.LineList);

            foreach (Vector2 v2 in terrain)
            {
                pb.AddVertex(v2, Color.White);
            }

            foreach (Vector2 p2 in pads)
            {
                pb.AddVertex(p2, Color.GreenYellow);
            }

            pb.End();

        }

        public void LoadTerrain()
        {
            StreamReader reader = File.OpenText(@".\Content\terrain.txt");

            string line = null;

            while((line = reader.ReadLine()) != null) 
            {
                line = line.Trim();

                if (!line.StartsWith("#"))
                {
                    string[] s = line.Split(',');

                    Vector2 p1 = new Vector2(int.Parse(s[0]), int.Parse(s[1])); //System.FormatException: 'Input string was not in a correct format.'
                    terrain.AddLast(p1);

                    Vector2 p2 = new Vector2(int.Parse(s[2]), int.Parse(s[3]));
                    terrain.AddLast(p2);
                }
            }

            reader.Close();
        }

        public void LoadPads()
        {
            StreamReader reader = File.OpenText(@".\Content\pads.txt");

            string line = null;

            while ((line = reader.ReadLine()) != null)
            {
                line = line.Trim();

                if (!line.StartsWith("#"))
                {
                    string[] s = line.Split(',');

                    Vector2 p1 = new Vector2(int.Parse(s[0]), int.Parse(s[1]));
                    pads.AddLast(p1);

                    Vector2 p2 = new Vector2(int.Parse(s[2]), int.Parse(s[3]));
                    pads.AddLast(p2);
                }
            }

            reader.Close();
        }
    }
}



