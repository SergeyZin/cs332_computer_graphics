using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace affine_transform
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private Point startPoint, endPoint = Point.Empty;
        private bool isMouseDown = false;
        private bool edgeSelected = false;
        private List<TwoPoints> points = new List<TwoPoints>();
        private Pen penColor = Pens.LimeGreen;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);

        }

        private void edgeButton_Click(object sender, EventArgs e)
        {
            if (!edgeSelected)
            {
                pictureBox1.Cursor = Cursors.Cross;
                edgeSelected = true;
                edgeButton.BackColor = Color.LightBlue;
            }
            else
            {
                pictureBox1.Cursor = Cursors.Default;
                edgeSelected = false;
                edgeButton.BackColor = SystemColors.Control;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (edgeSelected)
            {
                startPoint = e.Location;
                isMouseDown = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && edgeSelected && startPoint != null)
            {
                endPoint = e.Location;
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            points.Add(new TwoPoints(startPoint, endPoint));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Invalidate();
            points.Clear();
            startPoint = endPoint = Point.Empty;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (TwoPoints tp in points)
            {
                e.Graphics.DrawLine(penColor, tp.p1, tp.p2);
            }
            e.Graphics.DrawLine(penColor, startPoint, endPoint);
        }
    }

}
