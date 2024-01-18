using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using static Microsoft.Xna.Framework.Graphics.SpriteFont;

namespace MyLibrary
{
    public class Font
    {
        public static Color color;

        private static LinkedList<Vector2> GetChar(char ch)
        {
            LinkedList<Vector2> g = Glyph.GetGlyph(ch);

            return g;
        }

        public static void WriteText(PrimitiveBatch pb, float x, float y, float scale,
            Color color, string text)
        {
            LinkedList<Vector2> lineList = new LinkedList<Vector2>();
            LinkedList<Vector2> charLines = null;

            float charWidth = 16.0f * scale;
            float lineWidth = 4.0f * scale;
            float lineHeight = 3.0f * scale;
            float dx = 0.0f;
            float dy = 0.0f;
            float xPos = 0.0f;
            float yPos = 0.0f;
            int i = 0;

            for (i = 0; i < text.Length; i++)
            {
                charLines = Glyph.GetGlyph(text.ToCharArray()[i]);

                foreach (Vector2 v in charLines)
                {
                    dx = v.X;
                    dy = v.Y;
                    xPos = x + i * charWidth;
                    yPos = y;
                    lineList.AddLast(new Vector2(
                        xPos + dx * lineWidth,
                        yPos + dy * lineHeight));
                }
            }

            pb.Begin(PrimitiveType.LineList);

            foreach (Vector2 v in lineList)
            {
                pb.AddVertex(v, color);
            }

            pb.End();
        }
    }
}
