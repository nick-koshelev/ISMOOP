using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
{
    class Line : Point
    {
        protected int X1;
        protected int Y1;

        public Line()
        {
            Pen = new Pen(Color.FromArgb(Rand.Next(0, 255), Rand.Next(0, 255), Rand.Next(0, 255)), Rand.Next(0, 10));
            X = Rand.Next(0, 300);
            Y = Rand.Next(0, 200);
            X1 = Rand.Next(0, 300);
            Y1 = Rand.Next(0, 200);
        }

        public Line(int x, int y, int red, int green, int blue, int size, int x1, int y1) : base (x, y, red, green, blue, size)
        {
            SetX1(x1);
            SetY1(y1);
        }

        public void SetX1(int x1)
        {
            X1 = x1;
        }

        public void SetY1(int y1)
        {
            Y1 = y1;
        }

        public int GetX1()
        {
            return X1;
        }

        public int GetY1()
        {
            return Y1;
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawLine(Pen, X, Y, X1, Y1);
        }
    }
}
