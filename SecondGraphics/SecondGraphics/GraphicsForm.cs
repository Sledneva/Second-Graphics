using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondGraphics
{
    public partial class GraphicsForm : Form
    {
        Graphics g;
        PointF[] points1;
        bool drawing = false;
        int minIndex = 0;
        public GraphicsForm()
        {
            InitializeComponent();
            g = drawingPanel.CreateGraphics();
        }

        private void DrawPolygon(int vertexes, float radius)
        {
            double angle = Math.PI * 2 / vertexes;
            points1 = new PointF[vertexes];

            for (int i = 0; i < points1.Length; i++)
            {
                points1[i] = PointF.Add(new PointF(drawingPanel.Width / 2, drawingPanel.Height / 2), new SizeF((float)Math.Sin(i * angle) * radius, (float)Math.Cos(i * angle) * radius));
            }

        }
        private void drawingButton_Click(object sender, EventArgs e)
        {
            g.Clear(DefaultBackColor);
            DrawPolygon(Convert.ToInt32(vertexesNumericUpDown.Value), sizeTrackBar.Value);
            g.DrawPolygon(new Pen(Color.DarkMagenta, 6), points1);

        }

        private void drawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void drawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                g.Clear(DefaultBackColor);
                float dx = (float)e.X - points1[minIndex].X;
                float dy = (float)e.Y - points1[minIndex].Y;
                for (int i = 0; i < points1.Length; i++)
                {
                    points1[i].X += dx;
                    points1[i].Y += dy;
                }
                g.DrawPolygon(new Pen(Color.DarkMagenta, 6), points1);
            }
        }

        private void drawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            drawing = true;
            float[] coords = new float[Convert.ToInt32(vertexesNumericUpDown.Value)];
            for (int i = 0; i < coords.Length; i++)
            {
                coords[i] = e.X - points1[i].X;
            }
            float min = 1000000;
            for (int i = 0; i < coords.Length; i++)
            {
                if (coords[i] < min) { min = coords[i]; minIndex = i; }
            }
        }

        private void sizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            g.Clear(DefaultBackColor);
            DrawPolygon(Convert.ToInt32(vertexesNumericUpDown.Value), sizeTrackBar.Value);
            g.DrawPolygon(new Pen(Color.DarkMagenta, 6), points1);
        }

        private void vertexesNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            g.Clear(DefaultBackColor);
            DrawPolygon(Convert.ToInt32(vertexesNumericUpDown.Value), sizeTrackBar.Value);
            g.DrawPolygon(new Pen(Color.DarkMagenta, 6), points1);
        }
    }
}
