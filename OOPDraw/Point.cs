using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
{
    class Point : Shape_Point
    {
        protected int X;
        protected int Y;
        protected Pen Pen;
        protected Brush Brush;
        protected int Red;
        protected int Green;
        protected int Blue;
        protected int Size;

        public Point()
        {
            Pen = new Pen(Color.FromArgb(Rand.Next(0, 255), Rand.Next(0, 255), Rand.Next(0, 255)), 5);
            Brush = new SolidBrush(Color.FromArgb(Rand.Next(0, 255), Rand.Next(0, 255), Rand.Next(0, 255)));
            X = Rand.Next(0, 300);
            Y = Rand.Next(0, 200);
        }
        public Point(int x, int y, int red, int green, int blue, int size)
        {
            SetX(x);
            SetY(y);
            SetRed(red);
            SetGreen(green);
            SetBlue(blue);
            SetPen(red, green, blue, size);
        }

        public Point(Point obj)
        {
            X = obj.X;
            Y = obj.Y;
            Red = obj.Red;
            Green = obj.Green;
            Blue = obj.Blue;
            Pen = obj.Pen;
        }
        
        public void SetX(int x)
        {
            X = x;
        }

        public void SetY(int y)
        {
            Y = y;
        }

        public void SetPen(int red, int green, int blue, int size)
        {
            Pen = new Pen(Color.FromArgb(red, green, blue), size);
        }

        public void SetRed(int red)
        {
            Red = red;
        }

        public void SetGreen(int green)
        {
            Green = green;
        }

        public void SetBlue(int blue)
        {
            Blue = blue;
        }

        public void SetSize(int size)
        {
            Size = size;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY()
        {
            return Y;
        }

        public Pen GetPen()
        {
            return Pen;
        }

        public int GetRed()
        {
            return Red;
        }

        public int GetGreen()
        {
            return Green;
        }

        public int GetBlue()
        {
            return Blue;
        }

        public int GetSize()
        {
            return Size;
        }

        public override void Draw(Graphics gr)
        {
            gr.DrawEllipse(Pen, X, Y, 5, 5);
        }
    }
}
