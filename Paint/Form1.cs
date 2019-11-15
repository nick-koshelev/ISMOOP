using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShapeLi;

namespace Paint
{
    public partial class Form1 : Form
    {
        protected int X, Y, X1, Y1, Radius, Width, Height;
        protected byte R, G, B;
        protected List<Shape_Point> Shapes;
        protected Mode Mode;

        public void AddShapes(Shape_Point shape)
        {
            Shapes.Add(shape);
            listBoxShapes.Items.Add(shape);
            pictureBox1.Refresh();
        }

        public void DeleteShapes(int number)
        {
            Shapes.RemoveAt(number);
            listBoxShapes.Items.RemoveAt(number);
            pictureBox1.Refresh();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonColor.BackColor = Color.Black;
            Shapes = new List<Shape_Point>();
            Mode = Mode.DrawPoint;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                buttonColor.BackColor = colorDialog.Color;
                R = buttonColor.BackColor.R;
                G = buttonColor.BackColor.G;
                B = buttonColor.BackColor.B;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxShapes.Items.Count; i++)
            {
                if (listBoxShapes.GetSelected(i))
                {
                    DeleteShapes(i);
                    i--;
                    listBoxShapes.SelectedIndex = i;
                }
            }
        }

        private void buttonRect_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawRectangle;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawEllipse;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawLine:
                    e.Graphics.DrawLine(new Pen(Color.FromArgb(R, G, B), 2), X, Y, X1, Y1);
                    break;
                case Mode.DrawCircle:
                    e.Graphics.DrawEllipse(new Pen(Color.FromArgb(R, G, B), 2), X - Radius / 2, Y - Radius / 2, Radius, Radius);
                    break;
                case Mode.DrawRectangle:
                    if (X > X1 && Y > Y1)
                    {
                        e.Graphics.DrawRectangle(new Pen(Color.FromArgb(R, G, B), 2), X - Width, Y - Height, Width, Height);
                    }
                    else if (X > X1 && Y < Y1)
                    {
                        e.Graphics.DrawRectangle(new Pen(Color.FromArgb(R, G, B), 2), X - Width, Y, Width, Height);
                    }
                    else if (X < X1 && Y > Y1)
                    {
                        e.Graphics.DrawRectangle(new Pen(Color.FromArgb(R, G, B), 2), X, Y - Height, Width, Height);
                    }
                    else if (X < X1 && Y < Y1)
                    {
                        e.Graphics.DrawRectangle(new Pen(Color.FromArgb(R, G, B), 2), X, Y, Width, Height);
                    }
                    break;
                case Mode.DrawEllipse:
                    e.Graphics.DrawEllipse(new Pen(Color.FromArgb(R, G, B), 2), X - Width / 2, Y - Height / 2, Width, Height);
                    break;
            }
            for (int i = 0; i < Shapes.Count; i++)
            {
                Shapes[i].Draw(e.Graphics);
            }
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawPoint;
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawLine;
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Mode = Mode.DrawCircle;
        }

        private void listBoxShapes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawPoint:
                    Shape_Point point = new ShapeLi.Point(e.X, e.Y, R, G, B, 2);
                    AddShapes(point);
                    break;
                case Mode.DrawLine:
                    X = e.X;
                    Y = e.Y;
                    break;
                case Mode.DrawCircle:
                    X = e.X;
                    Y = e.Y;
                    Radius = (int)Math.Sqrt(Math.Pow(X - e.X, 2) + Math.Pow(Y - e.Y, 2));
                    break;
                case Mode.DrawRectangle:
                    X = e.X;
                    Y = e.Y;
                    break;
                case Mode.DrawEllipse:
                    X = e.X;
                    Y = e.Y;
                    break;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawLine:
                    if (e.Button == MouseButtons.Left)
                    {
                        //pictureBox1.Refresh();
                        //Graphics graphics = pictureBox1.CreateGraphics();
                        //graphics.DrawLine(new Pen(Color.Black, 1), X, Y, e.X, e.Y);
                        ////Line line = new Line(X, Y, R, G, B, 2, e.X, e.Y);
                        X1 = e.X;
                        Y1 = e.Y;
                        pictureBox1.Refresh();
                    }
                    break;
                case Mode.DrawCircle:
                    if (e.Button == MouseButtons.Left)
                    {
                        Radius = (int)Math.Sqrt(Math.Pow(X - e.X, 2) + Math.Pow(Y - e.Y, 2));
                        pictureBox1.Refresh();
                    }
                    break;
                case Mode.DrawRectangle:
                    if (e.Button == MouseButtons.Left)
                    {
                        Width = Math.Abs(X - e.X);
                        Height = Math.Abs(Y - e.Y);
                        X1 = e.X;
                        Y1 = e.Y;
                        pictureBox1.Refresh();
                    }
                    break;
                case Mode.DrawEllipse:
                    if (e.Button == MouseButtons.Left)
                    {
                        Width = Math.Abs(X - e.X);
                        Height = Math.Abs(Y - e.Y);
                        pictureBox1.Refresh();
                    }
                    break;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (Mode)
            {
                case Mode.DrawLine:
                    Shape_Point line = new Line(X, Y, R, G, B, 2, e.X, e.Y);
                    AddShapes(line);
                    break;
                case Mode.DrawCircle:
                    Shape_Point circle = new Circle(X, Y, R, G, B, 2, Radius);
                    AddShapes(circle);
                    break;
                case Mode.DrawRectangle:
                    Width = Math.Abs(X - e.X);
                    Height = Math.Abs(Y - e.Y);
                    Shape_Point rect = new ShapeLi.Rectangle();
                    if (X > e.X && Y > e.Y)
                    {
                        rect = new ShapeLi.Rectangle(X - Width / 2, Y - Height / 2, R, G, B, 2, Width, Height);
                    }
                    else if (X > e.X && Y < e.Y)
                    {
                        rect = new ShapeLi.Rectangle(X - Width / 2, Y + Height / 2, R, G, B, 2, Width, Height);
                    }
                    else if (X < e.X && Y > e.Y)
                    {
                        rect = new ShapeLi.Rectangle(X + Width / 2, Y - Height / 2, R, G, B, 2, Width, Height);
                    }
                    else if (X < e.X && Y < e.Y)
                    {
                        rect = new ShapeLi.Rectangle(X + Width / 2, Y + Height / 2, R, G, B, 2, Width, Height);
                    }
                    AddShapes(rect);
                    break;
                case Mode.DrawEllipse:
                    Width = Math.Abs(X - e.X);
                    Height = Math.Abs(Y - e.Y);
                    Shape_Point ell = new Ellipse(X, Y, R, G, B, 2, Width, Height);
                    AddShapes(ell);
                    break;
            }
        }
    }
}
