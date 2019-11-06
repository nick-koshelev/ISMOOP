using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
{
    class Rectangle : Line
    {
        
        public Rectangle()
        {
            Pen = new Pen(Color.FromArgb(Rand.Next(0, 255), Rand.Next(0, 255), Rand.Next(0, 255)), Rand.Next(0, 10));
            Brush = new SolidBrush(Color.FromArgb(Rand.Next(0, 255), Rand.Next(0, 255), Rand.Next(0, 255)));
            X = Rand.Next(0, 300);
            Y = Rand.Next(0, 200);
            X1 = Rand.Next(0, 100);
            Y1 = Rand.Next(0, 100);
        }

        public Rectangle(int x, int y, int red, int green, int blue, int size, int width, int height) : base(x, y, red, green, blue, size, width, height)
        {

        }

        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(Pen, X - X1 / 2, Y - Y1 / 2, X1, Y1);
        }
    }
}
