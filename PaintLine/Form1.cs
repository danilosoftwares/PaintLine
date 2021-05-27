using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintLine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Point[]> pontos = new List<Point[]>();
        bool drw;
        int beginX, beginY;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            drw = true;
            beginX = e.X;
            beginY = e.Y;
            Point[] p = { new Point(e.X, e.Y), new Point() };
            pontos.Add(p);
        }

        Graphics g;
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            drw = false;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "exemplo de linhas ponto a ponto";
            this.BackColor = Color.White;
            g = this.CreateGraphics();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drw == true)
            {
                g.Clear(Color.White);
                Pen p = new Pen(Color.Blue, 4);
                Point point1 = new Point(beginX, beginY);
                Point point2 = new Point(e.X, e.Y);
                g.DrawLine(p, point1, point2);
                pontos[pontos.Count - 1][1] = new Point(e.X, e.Y);
                int i = 0;
                while(i != pontos.Count)
                {
                    g.DrawLine(p, pontos[i][0], pontos[i][1]);
                    i++;
                }
   
            }
        }
    }
}
