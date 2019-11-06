using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
{
    class Ellipse : Circle
    {
        protected int Radius2;

        public Ellipse()
        {
            Pen = new Pen(Color.FromArgb(Rand.Next(0, 255), Rand.Next(0, 255), Rand.Next(0, 255)), Rand.Next(0, 10));
            Brush = new SolidBrush(Color.FromArgb(Rand.Next(0, 255), Rand.Next(0, 255), Rand.Next(0, 255)));
            X = Rand.Next(0, 300);
            Y = Rand.Next(0, 200);
            Radius1 = Rand.Next(0, 50);
            Radius2 = Rand.Next(0, 50);
        }

        public Ellipse(int x, int y, int red, int green, int blue, int size, int radius1, int radius2) : base(x, y, red, green, blue, size, radius1)
        {
            SetRadius2(radius2);
        }

        public void SetRadius2(int radius2)
        {
            Radius2 = radius2;
        }

        public int GetRadius2()
        {
            return Radius2;
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(Pen, X - Radius1 / 2, Y - Radius2 / 2, Radius1, Radius2);
        }
    }
}
