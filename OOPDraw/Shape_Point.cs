﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDraw
{
    abstract class Shape_Point : Form1
    {
        public Shape_Point()
        {

        }

        public abstract void Draw(Graphics gr);
    }
}
