using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDraw
{
    public partial class Form1 : Form
    {
        //Bitmap canvas;
        List<Shape_Point> shapes;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pB1_Click(object sender, EventArgs e)
        {

        }


        protected Random Rand = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            //canvas = new Bitmap(pB1.Width, pB1.Height);
            shapes = new List<Shape_Point>();
            //Graphics g = Graphics.FromImage(canvas);
            Graphics g = pB1.CreateGraphics();
            for (int i = 0; i < trackBar1.Value; i++)
            {
                switch (Rand.Next(1, 6))
                {
                    case 1:
                        shapes.Add(new Point(Rand.Next(0, pB1.Width), Rand.Next(0, pB1.Height), Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 5)));
                        break;
                    case 2:
                        shapes.Add(new Line(Rand.Next(0, pB1.Width), Rand.Next(0, pB1.Height), Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 5), Rand.Next(0, pB1.Height), Rand.Next(0, pB1.Width)));
                        break;
                    case 3:
                        shapes.Add(new Circle(Rand.Next(0, pB1.Width), Rand.Next(0, pB1.Height), Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 5), Rand.Next(0, pB1.Height / 2)));
                        break;
                    case 4:
                        shapes.Add(new Rectangle(Rand.Next(0, pB1.Width), Rand.Next(0, pB1.Height), Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 5), Rand.Next(0, pB1.Height / 2), Rand.Next(0, pB1.Height)));
                        break;
                    case 5:
                        shapes.Add(new Ellipse(Rand.Next(0, pB1.Width), Rand.Next(0, pB1.Height), Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 256), Rand.Next(0, 5), Rand.Next(0, pB1.Height / 2), Rand.Next(0, pB1.Height)));
                        break;
                }
            }
            pB1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Graphics g = Graphics.FromImage(canvas);
            //g.FillRectangle(new SolidBrush(DefaultBackColor), 0, 0, pB1.Width, pB1.Height);
            //pB1.Image = canvas;
            //pB1.Image = null;
            shapes.Clear();
            pB1.Refresh();
        }

        private void pB1_Paint(object sender, PaintEventArgs e)
        {
            if(shapes != null)
            {
                for(int i = 0; i < trackBar1.Value; i++)
                {
                    shapes[i].Draw(e.Graphics);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            shapes.RemoveAt((int)numericUpDown1.Value);
            pB1.Refresh();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
