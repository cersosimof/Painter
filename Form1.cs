using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setSize(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private class ArrayPoints
        {
            private int index = 0;
            private Point[] points;

            public ArrayPoints(int size)
            {
                if (size <= 0)
                {
                    size = 2;
                }

                points = new Point[size];
            }

            public void setPoint(int x, int y)
            {
                if (index >= points.Length)
                {
                    index = 0;
                }

                points[index] = new Point(x, y);
                index++;
            }

            public void ResetPoints()
            {
                index = 0;
            }

            public int getCountPoints()
            {
                return index;
            }

            public Point[] getPoints()
            {
                return points;
            }

        }

        private bool isMouse = false;
        private ArrayPoints arrayPoints = new ArrayPoints(2);

        private Bitmap map = new Bitmap(100, 100);
        private Graphics graphics;
        private Pen pen = new Pen(Color.Black, 3f);

        private void setSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            map = new Bitmap(rectangle.Width, rectangle.Height);
            graphics = Graphics.FromImage(map);

            // Agrega esto para que el trazo sea mas suave
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

        }

        private void pizarra_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
        }

        private void pizarra_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            arrayPoints.ResetPoints();  
        }

        private void pizarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse)
            {
                return;
            }

            arrayPoints.setPoint(e.X, e.Y);

                if (arrayPoints.getCountPoints() >= 2)
                {
                    graphics.DrawLines(pen, arrayPoints.getPoints());
                    pizarra.Image = map;
                    arrayPoints.setPoint(e.X, e.Y);
                }

        }

        private void Color1_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button) sender).BackColor;
        }

        private void Color7_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button) sender).BackColor = colorDialog1.Color;
            }
        }

        private void botonLimpiar_Click(object sender, EventArgs e)
        {
            graphics.Clear(pizarra.BackColor);
            pizarra.Image = map;
        }

        private void trackBarGrosor_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = trackBarGrosor.Value; 
        }
    }
}
