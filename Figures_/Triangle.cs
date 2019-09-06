using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_
{
    class Triangle : Figure
    {
        protected int aX, aY, bX, bY, cX, cY;
        protected double A, B, C;
        protected double P;

        public Triangle(int aX, int aY, int bX, int bY, int cX, int cY, Pen color, Form1 form1) : base(color, form1)
        {
            this.aX = aX;
            this.aY = aY;
            this.bX = bX;
            this.bY = bY;
            this.cX = cX;
            this.cY = cY;
            A = Math.Round(Math.Sqrt(Math.Abs(((aX - bX) * (aX - bX))) + Math.Abs(((aY - bY) * (aY - bY)))),2);
            B = Math.Round(Math.Sqrt(Math.Abs(((bX - cX) * (bX - cX))) + Math.Abs(((bY - cY) * (bY - cY)))),2);
            C = Math.Round(Math.Sqrt(Math.Abs(((aX - cX) * (aX - cX))) + Math.Abs(((aY - cY) * (aY - cY)))),2);
        }

        private Point[] GetCurrPoints()
        {
            return new Point[] {
                new Point(aX, aY),
                new Point(bX, bY),
                new Point(cX, cY),
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

        public virtual double Perimetr()
        {
            P = A + B + C;
            return Math.Round(P,2);
        }

        public override double GetSquare()
        {
            Perimetr();
            double square = Math.Sqrt(P * (P - A) * (P -B) * (P - C));
            return Math.Round(square,2);
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = form1.CreateGraphics();
            graphics.DrawPolygon(new Pen(form1.BackColor, 5), GetCurrPoints());
        }

        public override string ToString()
        {
            return "Фигура: треугольник, площадь : " + GetSquare().ToString()
                + " кв. ед., сторона А : " +A.ToString() +
                " ед., сторона B : " + B.ToString() +
                " ед., сторона B : " + C.ToString() +
                ", цвет: " + color.Color.ToString() + "\n";
        }
    }
}
