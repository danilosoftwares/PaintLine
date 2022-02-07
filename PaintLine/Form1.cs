using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintLine
{
    enum ImageDrawing
    {
        Line,
        Circle,
        Rectangle,
        RectangleArround,
    }

    struct HistoryImage
    {
        public int X;
        public int Y;
        public ImageDrawing Tipo;
        public Color Cor;
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            pnlColorSelected.BackColor = selected;

            MakePaletteColors();
        }

        Color selected = Color.Black;
        ImageDrawing tipo = ImageDrawing.Line;
        List<HistoryImage[]> pontos = new List<HistoryImage[]>();
        bool drw;
        int beginX, beginY;

        Graphics g;

        private void MakePaletteColors()
        {
            List<Color> palette = new List<Color>();
            palette.Add(Color.Black);
            palette.Add(Color.FromArgb(127, 127, 127));
            palette.Add(Color.FromArgb(136, 0, 21));
            palette.Add(Color.FromArgb(237, 28, 36));
            palette.Add(Color.FromArgb(255, 127, 39));
            palette.Add(Color.FromArgb(255, 242, 0));
            palette.Add(Color.FromArgb(34, 177, 76));
            palette.Add(Color.FromArgb(0, 162, 232));
            palette.Add(Color.FromArgb(63, 72, 204));
            palette.Add(Color.FromArgb(163, 73, 164));
            palette.Add(Color.White);
            palette.Add(Color.FromArgb(195, 195, 195));
            palette.Add(Color.FromArgb(185, 122, 87));
            palette.Add(Color.FromArgb(255, 174, 201));
            palette.Add(Color.FromArgb(255, 201, 14));
            palette.Add(Color.FromArgb(239, 228, 176));
            palette.Add(Color.FromArgb(181, 230, 29));
            palette.Add(Color.FromArgb(153, 217, 234));
            palette.Add(Color.FromArgb(112, 146, 190));
            palette.Add(Color.FromArgb(200, 191, 231));
            int p = 0;
            int y = 0;
            while(y != 2)
            { 
                int x = 0;
                while (x != 10)
                {
                    pnlTitle.Controls.Add(new Panel());
                    (pnlTitle.Controls[pnlTitle.Controls.Count - 1] as Panel).Location = new System.Drawing.Point(867 + (22 * x), 31 + (22 * y));
                    (pnlTitle.Controls[pnlTitle.Controls.Count - 1] as Panel).Name = "panel_" + this.Controls.Count.ToString();
                    (pnlTitle.Controls[pnlTitle.Controls.Count - 1] as Panel).Size = new System.Drawing.Size(16, 16);
                    (pnlTitle.Controls[pnlTitle.Controls.Count - 1] as Panel).BackColor = p < palette.Count ? palette[p] : Color.Aqua;
                    (pnlTitle.Controls[pnlTitle.Controls.Count - 1] as Panel).Click += new System.EventHandler(this.setColorPen_Click);
                    (pnlTitle.Controls[pnlTitle.Controls.Count - 1] as Panel).BringToFront();
                    x++;
                    p++;
                }
                y++;
            }
        }

        private void setColorPen_Click(object sender, EventArgs e)
        {
            selected = (sender as Panel).BackColor;
            pnlColorSelected.BackColor = selected;
        }

        public static GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);
            GraphicsPath path = new GraphicsPath();

            if (radius == 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            // top left arc  
            path.AddArc(arc, 180, 90);

            // top right arc  
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // bottom right arc  
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // bottom left arc 
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        private void processImage(Color color,HistoryImage pt1, HistoryImage pt2)
        {
            Pen p = new Pen(color, 4);
            if (pt1.Tipo == ImageDrawing.Line)
            {
                g.DrawLine(p, new Point(pt1.X, pt1.Y), new Point(pt2.X, pt2.Y));
            }
            else if (pt1.Tipo == ImageDrawing.Circle)
            {
                g.DrawEllipse(p, new Rectangle(pt1.X, pt1.Y, pt2.X - pt1.X, pt2.Y - pt1.Y));
            }
            else if (pt1.Tipo == ImageDrawing.Rectangle)
            {
                g.DrawRectangle(p, new Rectangle(pt1.X, pt1.Y, pt2.X - pt1.X, pt2.Y - pt1.Y));
            }
            else if (pt1.Tipo == ImageDrawing.RectangleArround)
            {
                g.DrawPath(p, RoundedRect(new Rectangle(pt1.X, pt1.Y, pt2.X - pt1.X, pt2.Y - pt1.Y), 5));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "exemplo de paint em c#";
            //this.BackColor = Color.White;
            //g = this.CreateGraphics();
            g = boxImage.CreateGraphics();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drw == true)
            {
                g.Clear(Color.White);            
                HistoryImage point1 = new HistoryImage();
                point1.Tipo = tipo;
                point1.Cor = selected;
                point1.X = beginX;
                point1.Y = beginY;
                HistoryImage point2 = new HistoryImage();
                point2.X = e.X;
                point2.Y = e.Y;
                processImage(point1.Cor, point1, point2);

                pontos[pontos.Count - 1][1] = new HistoryImage();
                pontos[pontos.Count - 1][1].X = e.X;
                pontos[pontos.Count - 1][1].Y = e.Y;
                int i = 0;
                while (i != pontos.Count)
                {
                    processImage(pontos[i][0].Cor, pontos[i][0], pontos[i][1]);
                    i++;
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            drw = false;
        }

        private void picSelectLine_Click(object sender, EventArgs e)
        {
            tipo = ImageDrawing.Line;
            processImageSelected();
        }

        private void picSelectCircle_Click(object sender, EventArgs e)
        {
            tipo = ImageDrawing.Circle;
            processImageSelected();
        }

        private void picSelectRectangle_Click(object sender, EventArgs e)
        {
            tipo = ImageDrawing.Rectangle;
            processImageSelected();
        }

        private void picSelectRectangleRound_Click(object sender, EventArgs e)
        {
            tipo = ImageDrawing.RectangleArround;
            processImageSelected();
        }

        private void processImageSelected()
        {
            picSelectLine.Image = tipo == ImageDrawing.Line ? global::PaintLine.Properties.Resources.selected_line : global::PaintLine.Properties.Resources.no_selected_line;
            picSelectCircle.Image = tipo == ImageDrawing.Circle ? global::PaintLine.Properties.Resources.selected_circle : global::PaintLine.Properties.Resources.no_selected_circle;
            picSelectRectangle.Image = tipo == ImageDrawing.Rectangle ? global::PaintLine.Properties.Resources.selected_rectangle : global::PaintLine.Properties.Resources.no_selected_rectangle;
            picSelectRectangleRound.Image = tipo == ImageDrawing.RectangleArround ? global::PaintLine.Properties.Resources.selected_rectangle_round : global::PaintLine.Properties.Resources.no_selected_rectangle_round;


            switch (tipo)
            {
                case ImageDrawing.Line: picSelectLine.BringToFront(); break;
                case ImageDrawing.Circle: picSelectCircle.BringToFront(); break;
                case ImageDrawing.Rectangle: picSelectRectangle.BringToFront(); break;
                case ImageDrawing.RectangleArround: picSelectRectangleRound.BringToFront(); break;
            }
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            drw = true;
            beginX = e.X;
            beginY = e.Y;
            HistoryImage[] p = { new HistoryImage(), new HistoryImage() };
            p[0].X = e.X;
            p[0].Y = e.Y;
            p[0].Tipo = tipo;
            p[0].Cor = selected;
            pontos.Add(p);
        }
        
    }
}
