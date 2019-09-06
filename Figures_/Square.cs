using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_
{
    class Square : Figure
    {
        protected int LengthHide = 0;
        public Square(int xCentr, int yCentr, int lengthhide, Pen color, Form1 form1): base(xCentr, yCentr, color, form1)
        { 
            this.LengthHide = lengthhide;
        }

        private Point[] GetCurrPoints()
        {
            return new Point[] {
                new Point(xCentr - LengthHide,  yCentr - LengthHide),
                new Point(xCentr - LengthHide,  yCentr + LengthHide),
                new Point(xCentr + LengthHide,  yCentr + LengthHide),
                new Point(xCentr + LengthHide,  yCentr - LengthHide),
            };
        }

        private int GetHide()
        {
            return LengthHide;
        }

        public override void Draw()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawPolygon(color, GetCurrPoints());
        }

        public override Pen GetColor()
        {
            return color;
        }

        public override double GetSquare()
        {
            square = LengthHide * LengthHide;
            return Math.Round(square,2);
        }

        public override string ToString()
        {
            return "Фигура: квадарат, площадь: " + GetSquare().ToString()
                + " кв. ед., длина стороны: " +
                LengthHide.ToString() + "ед., цвет: " + color.Color.ToString() + "\n";
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawPolygon(new Pen(form1.BackColor,5), GetCurrPoints());
        }
    }
}
