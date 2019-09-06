using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_
{
    abstract class Figure
    {
        public int xCentr;
        public int yCentr;
        public double square;
        public Pen color;

        public Form1 form1;

        public Figure(int xCentr, int yCentr, Pen color, Form1 form1)
        {
            this.xCentr = xCentr;
            this.yCentr = yCentr;
            this.color = color;
            this.form1 = form1;
        }
        public Figure(Pen color, Form1 form1)
        {
            this.color = color;
            this.form1 = form1;
        }

        abstract public void Draw();

        abstract public double GetSquare();

        public abstract void HideDrawingBackGround();

        abstract public Pen GetColor();
    }
}
