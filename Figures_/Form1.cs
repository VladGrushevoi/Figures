using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures_
{
    public partial class Form1 : Form
    {

        private List<Figure> listFigures = new List<Figure>();

        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
            {
                Colors col = (Colors)rnd.Next(0, 9);
                Color c = Color.FromName(col.ToString());
                Pen p = new Pen(c, 5);
                int r = rnd.Next(1, 5);
                switch (r)
                {
                    case 1:
                        Figure sq = new Square(900, 220, rnd.Next(50, 100), p, this);
                        listFigures.Add(sq);
                        break;


                    case 2:
                        Figure circle = new Circle(rnd.Next(50, 100), 900, 220, p, this);
                        listFigures.Add(circle);
                        break;

                    case 3:
                        Figure tr = new Triangle(rnd.Next(900, 1000), rnd.Next(220, 270),
                                                rnd.Next(900, 1100), rnd.Next(150, 220),
                                                rnd.Next(900, 1200), rnd.Next(200, 260),
                                                p, this);
                        listFigures.Add(tr);
                        break;
                    case 4:
                        Figure trpz = new Trapeze(rnd.Next(100, 150), rnd.Next(200, 250), rnd.Next(100, 150), 900, 220, p, this);
                        listFigures.Add(trpz);
                        break;
                }
            }
        }

        private void Discover_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listFigures.Count; i++)
            {
                listBox1.Items.Add(listFigures[i]);
            }
        }

        private void Draw_btn_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listFigures[index].Draw();
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listFigures[index].HideDrawingBackGround();
        }
    }
}
