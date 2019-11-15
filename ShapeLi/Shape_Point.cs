using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLi
{
    public abstract class Shape_Point 
    {
        protected Random Rand = new Random();
        public Shape_Point()
        {

        }

        public abstract void Draw(Graphics gr);
    }
}
