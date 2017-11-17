using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace affine_transforms_in_space
{
    public partial class Form1 : Form
    {
        private Graphics g;
        private int centerX, centerY;
        private Pen pen;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            centerX = pictureBox1.Width / 2;
            centerY = pictureBox1.Height / 2;
            pen = new Pen(Color.Blue);
        }

        private void drawFacet(Facet f)
        {
            foreach (Edge e in f.edges) {
                g.DrawLine(pen, (int)e.P1.X + centerX,
                    (int)-e.P1.Y + centerY,
                    (int)e.P2.X + centerX,
                    (int)-e.P2.Y + centerY);
                pictureBox1.Invalidate();
            }

        }

        private void drawPolyhedron(Polyhedron p)
        {
            foreach (Facet f in p.facets)
            {
                drawFacet(f);
            }
            pictureBox1.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Polyhedron p = initTetrahedron(100);
            drawPolyhedron(p);
            pictureBox1.Invalidate();
        }

        private Polyhedron initTetrahedron(int size)
        {
            double h = size * Math.Sqrt(3);

            Point3D p1 = new Point3D(-size, -h / 2, 0);
            Point3D p2 = new Point3D(0, -h / 2, -h);
            Point3D p3 = new Point3D(size, -h / 2, 0);
            Point3D p4 = new Point3D(0, h / 2, 0);

            Edge e1 = new Edge(p1, p2);
            Edge e2 = new Edge(p2, p3);
            Edge e3 = new Edge(p3, p1);
            Edge e4 = new Edge(p1, p4);
            Edge e5 = new Edge(p2, p4);
            Edge e6 = new Edge(p3, p4);

            Facet f1 = new Facet();
            f1.edges.Add(e1);
            f1.edges.Add(e2);
            f1.edges.Add(e3);

            Facet f2 = new Facet();
            f2.edges.Add(e1);
            f2.edges.Add(e4);
            f2.edges.Add(e5);

            Facet f3 = new Facet();
            f3.edges.Add(e2);
            f3.edges.Add(e5);
            f3.edges.Add(e6);

            Facet f4 = new Facet();
            f4.edges.Add(e3);
            f4.edges.Add(e4);
            f4.edges.Add(e6);

            Polyhedron polyhedron = new Polyhedron(); 
            polyhedron.facets.Add(f1);
            polyhedron.facets.Add(f2);
            polyhedron.facets.Add(f3);
            polyhedron.facets.Add(f4);

            return polyhedron;
        }
    }
}
