using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MyLibrary
{
    public class Glyph
    {
        public static LinkedList<Vector2> GetGlyph(char ch)
        {
            LinkedList<Vector2> g = new LinkedList<Vector2>();

            switch (ch)
            {
                case 'a':
                case 'A':
                    {
                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(0, 1));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(1, 0));

                        g.AddLast(new Vector2(1, 0));
                        g.AddLast(new Vector2(2, 1));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(2, 1));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(2, 1));

                        break;
                    }
                case 'b':
                case 'B':
                    {
                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(0, 1));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(2, 2));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(0, 2));

                        break;
                    }
                case 'c':
                case 'C':
                    {
                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        break;
                    }
                case 'd':
                case 'D':
                    {
                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(1, 0));

                        g.AddLast(new Vector2(1, 0));
                        g.AddLast(new Vector2(2, 1));

                        g.AddLast(new Vector2(2, 1));
                        g.AddLast(new Vector2(2, 2));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(0, 2));

                        break;
                    }
                case 'e':
                case 'E':
                    {
                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(0, 1));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(1, 1));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        break;
                    }
                case 'f':
                case 'F':
                    {
                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(1, 1));

                        break;
                    }
                case 'g':
                case 'G':
                    {
                        g.AddLast(new Vector2(1, 1));
                        g.AddLast(new Vector2(2, 1));

                        g.AddLast(new Vector2(2, 1));
                        g.AddLast(new Vector2(2, 2));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        break;
                    }
                case 'h':
                case 'H':
                    {
                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(2, 1));

                        break;
                    }
                case 'i':
                case 'I':
                    {
                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(1, 2));
                        g.AddLast(new Vector2(1, 0));

                        break;
                    }
                case 'j':
                case 'J':
                    {
                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(1, 2));

                        g.AddLast(new Vector2(1, 2));
                        g.AddLast(new Vector2(1, 0));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(0, 0));

                        break;
                    }
                case 'k':
                case 'K':
                    {
                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(0, 1));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(2, 2));

                        break;
                    }
                case 'l':
                case 'L':
                    {
                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(0, 0));

                        break;
                    }
                case 'm':
                case 'M':
                    {
                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(1, 1));

                        g.AddLast(new Vector2(1, 1));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(2, 2));

                        break;
                    }
                case 'n':
                case 'N':
                    {
                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 2));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(2, 0));


                        break;
                    }
                case 'o':
                case 'O':
                    {
                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(2, 2));

                        break;
                    }
                case 'p':
                case 'P':
                    {
                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(2, 1));

                        g.AddLast(new Vector2(2, 1));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(0, 2));

                        break;
                    }
                case 'q':
                case 'Q':
                    {
                        g.AddLast(new Vector2(1, 2));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(2, 1));

                        g.AddLast(new Vector2(2, 1));
                        g.AddLast(new Vector2(1, 2));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(1, 1));

                        break;
                    }
                case 'r':
                case 'R':
                    {
                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(2, 1));

                        g.AddLast(new Vector2(2, 1));
                        g.AddLast(new Vector2(0, 1));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(2, 2));

                        break;
                    }
                case 's':
                case 'S':
                    {
                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(2, 2));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(2, 1));

                        g.AddLast(new Vector2(2, 1));
                        g.AddLast(new Vector2(0, 1));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        break;
                    }
                case 't':
                case 'T':
                    {
                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(1, 0));
                        g.AddLast(new Vector2(1, 2));

                        break;
                    }
                case 'u':
                case 'U':
                    {
                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(2, 2));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(2, 0));

                        break;
                    }
                case 'v':
                case 'V':
                    {
                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(1, 2));

                        g.AddLast(new Vector2(1, 2));
                        g.AddLast(new Vector2(2, 0));

                        break;
                    }
                case 'w':
                case 'W':
                    {
                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(1, 1));

                        g.AddLast(new Vector2(1, 1));
                        g.AddLast(new Vector2(2, 2));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(2, 0));

                        break;
                    }
                case 'x':
                case 'X':
                    {
                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 2));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(0, 2));

                        break;
                    }
                case 'y':
                case 'Y':
                    {
                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(1, 1));

                        g.AddLast(new Vector2(1, 1));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(1, 1));
                        g.AddLast(new Vector2(1, 2));

                        break;
                    }
                case 'z':
                case 'Z':
                    {
                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(2, 2));

                        break;
                    }
                case '0':
                    {
                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(2, 2));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(2, 0));

                        break;
                    }
                case '1':
                    {
                        g.AddLast(new Vector2(1, 0));
                        g.AddLast(new Vector2(1, 2));

                        break;
                    }
                case '2':
                    {
                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(2, 1));

                        g.AddLast(new Vector2(2, 1));
                        g.AddLast(new Vector2(0, 1));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(2, 2));

                        break;
                    }
                case '3':
                    {
                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(2, 2));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(2, 1));

                        break;
                    }
                case '4':
                    {
                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(0, 1));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(2, 1));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(2, 2));

                        break;
                    }
                case '5':
                    {
                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(2, 2));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(2, 1));

                        g.AddLast(new Vector2(2, 1));
                        g.AddLast(new Vector2(0, 1));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        break;
                    }
                case '6':
                    {
                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(2, 2));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(2, 1));

                        g.AddLast(new Vector2(2, 1));
                        g.AddLast(new Vector2(0, 1));

                        break;
                    }
                case '7':
                    {
                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(2, 2));

                        break;
                    }
                case '8':
                    {
                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(2, 1));

                        g.AddLast(new Vector2(2, 1));
                        g.AddLast(new Vector2(0, 1));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(0, 2));

                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(2, 2));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(2, 1));

                        g.AddLast(new Vector2(2, 1));
                        g.AddLast(new Vector2(0, 1));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(0, 0));

                        break;
                    }
                case '9':
                    {
                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(2, 0));

                        g.AddLast(new Vector2(2, 0));
                        g.AddLast(new Vector2(0, 0));

                        g.AddLast(new Vector2(0, 0));
                        g.AddLast(new Vector2(0, 1));

                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(2, 1));

                        break;
                    }
                case '.':
                    {
                        g.AddLast(new Vector2(1, 1));
                        g.AddLast(new Vector2(2, 1));

                        g.AddLast(new Vector2(2, 1));
                        g.AddLast(new Vector2(2, 2));

                        g.AddLast(new Vector2(2, 2));
                        g.AddLast(new Vector2(1, 2));

                        g.AddLast(new Vector2(1, 2));
                        g.AddLast(new Vector2(1, 1));

                        break;
                    }
                case '-':
                    {
                        g.AddLast(new Vector2(0, 1));
                        g.AddLast(new Vector2(2, 1));

                        break;
                    }
                case '/':
                    {
                        g.AddLast(new Vector2(0, 2));
                        g.AddLast(new Vector2(2, 0));

                        break;
                    }
            }

            return g;
        }
    }
}
