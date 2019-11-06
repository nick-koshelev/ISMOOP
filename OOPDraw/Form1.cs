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
        Bitmap canvas;
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
            canvas = new Bitmap(pB1.Width, pB1.Height);
            int n = 20;
            Shape_Point[] shape = new Shape_Point[100];
            Graphics g = Graphics.FromImage(canvas);
            /*  line.Draw(g);
            point.Draw(g);
            circle.Draw(g);
            rect.Draw(g);
            ell.Draw(g);  */
            for (int i = 0; i < n + 1; i++)
            {
                switch (Rand.Next(1, 6))
                {
                    case 1:
                        shape[i] = new Point();
                        shape[i].Draw(g);
                        break;
                    case 2:
                        shape[i] = new Line();
                        shape[i].Draw(g);
                        break;
                    case 3:
                        shape[i] = new Circle();
                        shape[i].Draw(g);
                        break;
                    case 4:
                        shape[i] = new Rectangle();
                        shape[i].Draw(g);
                        break;
                    case 5:
                        shape[i] = new Ellipse();
                        shape[i].Draw(g);
                        break;
                }
            }
            pB1.Image = canvas;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(canvas);
            g.FillRectangle(new SolidBrush(DefaultBackColor), 0, 0, pB1.Width, pB1.Height);
            pB1.Image = canvas;
        }
    }
}
