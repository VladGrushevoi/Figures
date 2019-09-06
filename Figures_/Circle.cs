using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_
{
    class Circle : Figure
    {
        protected int radius;

        public Circle(int radius, int xCentr, int yCentr, Pen color, Form1 form1) : base(xCentr, yCentr, color, form1)
        {
            this.radius = radius;
        }

        protected int GetRadius()
        {
            return radius;
        }

        public override void Draw()
        {
            Graphics g = form1.CreateGraphics();
            g.DrawEllipse(color, xCentr, yCentr, radius * 2, radius * 2);
        }

        public override Pen GetColor()
        {
            return color;
        }

        public override double GetSquare()
        {
            square = Math.PI * radius * radius;
            return Math.Round(square,2);
        }

        public override string ToString()
        {
            return "Фигура: круг, площадь: " + GetSquare().ToString()
                + " кв. ед., длина радиуса: " +
                radius.ToString() + "ед., цвет: " + color.Color.ToString() + "\n";
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawEllipse(new Pen(form1.BackColor, 5), xCentr, yCentr, radius * 2, radius * 2);
        }
    }
}
