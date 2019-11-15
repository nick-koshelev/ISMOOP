using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLi
{
    public class Circle : Point
    {
        protected Brush Brush;
        protected int Radius1;

        public Circle()
        {
            Pen = new Pen(Color.FromArgb(Rand.Next(0, 255), Rand.Next(0, 255), Rand.Next(0, 255)), Rand.Next(0, 10));
            Brush = new SolidBrush(Color.FromArgb(Rand.Next(0, 255), Rand.Next(0, 255), Rand.Next(0, 255)));
            X = Rand.Next(0, 300);
            Y = Rand.Next(0, 200);
            Radius1 = Rand.Next(0, 50);
        }

        public Circle(int x, int y, int red, int green, int blue, int size, int radius1) : base(x, y, red, green, blue, size)
        {
            SetRadius1(radius1);
        }

        public void SetB(Brush brush)
        {
            Brush = brush;
        }

        public void SetRadius1(int radius1)
        {
            Radius1 = radius1;
        }

        public Brush GetBrush()
        {
            return Brush;
        }

        public int GetRadius1()
        {
            return Radius1;
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(Pen, X - Radius1 / 2, Y - Radius1 / 2, Radius1, Radius1);
        }
    }
}
