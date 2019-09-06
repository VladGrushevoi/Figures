using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_
{
    class Trapeze : Figure
    {
        protected int UpperBase, DownBase, height;

        public Trapeze(int UpperBase, int DownBase, int heidht, int xCentr, int yCentr, Pen color, Form1 form1) : base(xCentr, yCentr, color, form1)
        {
            this.UpperBase = UpperBase;
            this.DownBase = DownBase;
            this.height = heidht;
        }
        private Point[] GetCurrPoints()
        {
            int halfHeight = height / 2;
            int halfUpBase = UpperBase / 2;
            int halfDowmBase = DownBase / 2;

            return new Point[] {
                new Point(Math.Abs(halfDowmBase - xCentr),  Math.Abs(yCentr + halfHeight)),
                new Point(Math.Abs(halfUpBase - xCentr),  Math.Abs(yCentr - halfHeight)),
                new Point(Math.Abs(xCentr + halfHeight), Math.Abs(halfUpBase - yCentr) ),
                new Point(Math.Abs(xCentr + halfDowmBase),  Math.Abs(halfHeight + yCentr))
            };
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
            square = 0.5 * (UpperBase + DownBase) * height;
            return Math.Round(square,2);
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawPolygon(new Pen(form1.BackColor,5), GetCurrPoints());
        }

        public override string ToString()
        {
            return "Фигура: трапеция, площадь: " + GetSquare().ToString()
                + " кв. ед., длина верхней основы: " + UpperBase.ToString() + 
                "ед., длина нижней основы: " + DownBase.ToString() + 
                "ед., цвет: "+color.Color.ToString();
        }
    }
}
