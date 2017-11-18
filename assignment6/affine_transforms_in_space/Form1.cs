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
        private Polyhedron polyhedron;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            centerX = pictureBox1.Width / 2;
            centerY = pictureBox1.Height / 2;
            pen = new Pen(Color.Black);
            polyhedron = new Polyhedron();
        }

        private void drawFacet(Facet f)
        {
            foreach (Edge e in f.edges) {
                g.DrawLine(pen, (int)e.P1.X + centerX,
                    (int)e.P1.Y + centerY,
                    (int)e.P2.X + centerX,
                    (int)e.P2.Y + centerY);
            }

        }

        private void drawPolyhedron()
        {
            g.Clear(Color.White);
            foreach (Facet f in polyhedron.facets)
            {
                drawFacet(f);
            }
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

        private void phComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            polyhedron = new Polyhedron();
            if (phComboBox.SelectedItem.ToString() == "Tetrahedron")
            {
                polyhedron = initTetrahedron(100);
            }
            drawPolyhedron();
        }

        private void translate(int tx, int ty, int tz)
        {
            foreach (Facet f in polyhedron.facets)
            {
                foreach (Edge e in f.edges)
                {
                    e.P1.X += tx;
                    e.P1.Y += ty;
                    e.P1.Z += tz;
                    e.P2.X += tx;
                    e.P2.Y += ty;
                    e.P2.Z += tz;

                }
            }
        }

       private void rotateOX(Edge e, double angle)
        {
            double y1 = e.P1.Y;
            double z1 = e.P1.Z;
            double y2 = e.P2.Y;
            double z2 = e.P2.Z;

            e.P1.Y = y1 * Math.Cos(angle) - z1 * Math.Sin(angle);
            e.P1.Z = y1 * Math.Sin(angle) + z1 * Math.Cos(angle);

            e.P2.Y = y2 * Math.Cos(angle) - z2 * Math.Sin(angle);
            e.P2.Z = y2 * Math.Sin(angle) + z2 * Math.Cos(angle);
        }

       private void rotateOY(Edge e, double angle)
        {
            double x1 = e.P1.X;
            double z1 = e.P1.Z;
            double x2 = e.P2.X;
            double z2 = e.P2.Z;

            e.P1.X = x1 * Math.Cos(angle) + z1 * Math.Sin(angle);
            e.P1.Z = -x1 * Math.Sin(angle) + z1 * Math.Cos(angle);

            e.P2.X = x2 * Math.Cos(angle) + z2 * Math.Sin(angle);
            e.P2.Z = -x2 * Math.Sin(angle) + z2 * Math.Cos(angle);
        }

        private void rotateOZ(Edge e, double angle)
        {
            double x1 = e.P1.X;
            double y1 = e.P1.Y;
            double x2 = e.P2.X;
            double y2 = e.P2.Y;

            e.P1.X = x1 * Math.Cos(angle) - y1 * Math.Sin(angle);
            e.P1.Y = x1 * Math.Sin(angle) + y1 * Math.Cos(angle);

            e.P2.X = x2 * Math.Cos(angle) - y2 * Math.Sin(angle);
            e.P2.Y = x2 * Math.Sin(angle) + y2 * Math.Cos(angle);
        }

        private void rotate(double angleX, double angleY, double angleZ)
        {
            foreach (Facet f in polyhedron.facets)
            {
                foreach (Edge edge in f.edges)
                {
                    rotateOX(edge, angleX);
                    rotateOY(edge, angleY);
                    rotateOZ(edge, angleZ);
                }
            }
        } 


        private void scale(double mx, double my, double mz)
        {
            foreach (Facet f in polyhedron.facets)
            {
                foreach (Edge e in f.edges)
                {
                    e.P1.X *= mx;
                    e.P1.Y *= my;
                    e.P1.Z *= mz;
                    e.P2.X *= mx;
                    e.P2.Y *= my;
                    e.P2.Z *= mz;

                }
            }
        }

        private void reflectByX()
        {
            foreach (Facet f in polyhedron.facets)
            {
                foreach (Edge e in f.edges)
                {
                    e.P1.X = -e.P1.X;
                    e.P2.X = -e.P2.X;
                }
            }
        }

        private void reflectByY()
        {
            foreach (Facet f in polyhedron.facets)
            {
                foreach (Edge e in f.edges)
                {
                    e.P1.Y = -e.P1.Y;
                    e.P2.Y = -e.P2.Y;
                }
            }
        }

        private void reflectByZ()
        {
            foreach (Facet f in polyhedron.facets)
            {
                foreach (Edge e in f.edges)
                {
                    e.P1.Z = -e.P1.Z;
                    e.P2.Z = -e.P2.Z;
                }
            }
        }

        private void applyTransBtn_Click(object sender, EventArgs e)
        {
            int tx = (int)transXNUD.Value;
            int ty = (int)transYNUD.Value;
            int tz = (int)transZNUD.Value;

            translate(tx, ty, tz);
            drawPolyhedron();
        }

        private void applyRotBtn_Click(object sender, EventArgs e)
        {
            double angleX = ((double)rotXNUD.Value * Math.PI) / 180;
            double angleY = ((double)rotYNUD.Value * Math.PI) / 180;
            double angleZ = ((double)rotZNUD.Value * Math.PI) / 180;

            rotate(angleX, angleY, angleZ);
            drawPolyhedron();
        }

        private void reflectByXBtn_Click(object sender, EventArgs e)
        {
            reflectByX();
            drawPolyhedron();
        }

        private void reflectByYBtn_Click(object sender, EventArgs e)
        {
            reflectByY();
            drawPolyhedron();
        }

        private void reflectByZBtn_Click(object sender, EventArgs e)
        {
            reflectByZ();
            drawPolyhedron();
        }

        private void applyScaleBtn_Click(object sender, EventArgs e)
        {
            double mx = (double)scaleXNUD.Value;
            double my = (double)scaleYNUD.Value;
            double mz = (double)scaleZNUD.Value;

            scale(mx, my, mz);
            drawPolyhedron();
        }
    }   
}
