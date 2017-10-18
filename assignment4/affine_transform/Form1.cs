﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace affine_transform
{

    public partial class Form1 : Form
    {

        private Graphics g;
        private Point startPoint, endPoint = Point.Empty;
        private bool isMouseDown = false;
        private Point[] edge = new Point[2];
		private Point[] polygon = new Point[0];
		private Pen penColor = Pens.BlueViolet;
        private PointF clickedPosition = new PointF(0, 0);
        private Point minPolyCoordinates, maxPolyCoordinates;

        //private int edgeLen = 0;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "0";
            chosenPointTb.Text = string.Format("X: {0} Y: {1}", clickedPosition.X, clickedPosition.Y);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (lineChk.Checked)
                {
                    startPoint = e.Location;
                    isMouseDown = true;
                }
                else if (polyChk.Checked)
                {
                    isMouseDown = true;
                    if (polygon.Length == 0)
                    {
                        startPoint = e.Location;
                        minPolyCoordinates = e.Location;
                        maxPolyCoordinates = e.Location;
                        Array.Resize(ref polygon, 1);
                        polygon[polygon.Length - 1] = startPoint;                        
                    }
                }
            }
        }
		

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (isMouseDown)
                {
                    if (lineChk.Checked)
                    {
                        endPoint = e.Location;
                        pictureBox1.Invalidate();
                    }
                    else if (polyChk.Checked)
                    {
                        endPoint = e.Location;
                        pictureBox1.Invalidate();
                    }

                }
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;

                if (lineChk.Checked)
                {
                    edge[edge.Length - 2] = new Point(startPoint.X, startPoint.Y);
                    edge[edge.Length - 1] = new Point(endPoint.X, endPoint.Y);
                    Array.Resize(ref edge, edge.Length + 2);
                }
                else if (polyChk.Checked)
                {
                    Array.Resize(ref polygon, polygon.Length + 1);
                    polygon[polygon.Length - 1] = endPoint;
                    if (endPoint.X < minPolyCoordinates.X)
                        minPolyCoordinates.X = endPoint.X;
                    if (endPoint.Y < minPolyCoordinates.Y)
                        minPolyCoordinates.Y = endPoint.Y;
                    if (endPoint.X > maxPolyCoordinates.X)
                        maxPolyCoordinates.X = endPoint.X;
                    if (endPoint.Y > maxPolyCoordinates.Y)
                        maxPolyCoordinates.Y = endPoint.Y;
                    startPoint = endPoint;
                   // chosenPointTb.Text = string.Format("X: {0} Y: {1}", (minPolyCoordinates.X + maxPolyCoordinates.X) / 2, (minPolyCoordinates.Y + maxPolyCoordinates.Y) / 2);
                    pictureBox1.Invalidate();
                }
            }
            else
            {
                clickedPosition.X = e.Location.X;
                clickedPosition.Y = e.Location.Y;
                chosenPointTb.Text = string.Format("X: {0} Y: {1}", e.Location.X, e.Location.Y);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Invalidate();
            Array.Clear(edge, 0, edge.Length);
            Array.Clear(polygon, 0, polygon.Length);
            Array.Resize(ref edge, 2);
            Array.Resize(ref polygon, 0);
            startPoint = endPoint = Point.Empty;
        }

		private void lineChk_CheckedChanged(object sender, EventArgs e)
		{
			if (lineChk.Checked)
			{
				polyChk.Checked = false;

			}
			else
			{

			}
		}

		private void polyChk_CheckedChanged(object sender, EventArgs e)
		{
			if (polyChk.Checked)
			{
				lineChk.Checked = false;

			}
			else
			{
                g.DrawLine(penColor, polygon[0], polygon[polygon.Length - 1]);
                pictureBox1.Invalidate();

            }
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            float x = 0;
            float y = 0;
            float angle = 0;
            float scaleX = 0;
            float scaleY = 0;

            if (!string.IsNullOrWhiteSpace(textBox1.Text)) 
                x = (float)Convert.ToDouble(textBox1.Text);
            if (!string.IsNullOrWhiteSpace(textBox2.Text))
                y = (float)Convert.ToDouble(textBox2.Text);
            if (!string.IsNullOrWhiteSpace(textBox3.Text))
                scaleX = (float)Convert.ToDouble(textBox3.Text);
            if (!string.IsNullOrWhiteSpace(textBox4.Text))
                scaleY = (float)Convert.ToDouble(textBox4.Text);
            if (!string.IsNullOrWhiteSpace(textBox5.Text))
                angle = (float)Convert.ToDouble(textBox5.Text);

            Matrix matr = new Matrix();

            PointF rotationPoint;

            if (lineChk.Checked)
            {
                rotationPoint = rotateAroundPointCb.Checked ? new PointF(clickedPosition.X, clickedPosition.Y): new PointF((edge[0].X + edge[1].X) / 2, (edge[0].Y + edge[1].Y) / 2);
                matr.RotateAt(angle, rotationPoint, MatrixOrder.Append);
                matr.Translate(x, y, MatrixOrder.Append);
                matr.TransformPoints(edge);
            }
            else if (polyChk.Checked)
            {
                rotationPoint = rotateAroundPointCb.Checked ? new PointF(clickedPosition.X, clickedPosition.Y) : new PointF((minPolyCoordinates.X + maxPolyCoordinates.X) / 2, (minPolyCoordinates.Y + maxPolyCoordinates.Y) / 2);
                matr.RotateAt(angle, rotationPoint, MatrixOrder.Append);
                matr.Translate(x, y, MatrixOrder.Append);
                //matr.Scale(scaleX, scaleY);
                matr.TransformPoints(polygon);
            }

            startPoint = endPoint = Point.Empty;
            pictureBox1.Invalidate();

        }

        private void ninetyDegBtn_Click(object sender, EventArgs e)
        {
            if (lineChk.Checked)
            {
                Matrix matr = new Matrix();
                matr.RotateAt(90, new PointF((edge[0].X + edge[1].X) / 2, (edge[0].Y + edge[1].Y) / 2), MatrixOrder.Append);
                matr.TransformPoints(edge);
                startPoint = endPoint = Point.Empty;
                pictureBox1.Invalidate();
            }
        }
    
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < edge.Length; i += 2)
            {
                e.Graphics.DrawLine(penColor, edge[i], edge[i + 1]);
            }

            for (int i = 1; i < polygon.Length; ++i)
            {
                e.Graphics.DrawLine(penColor, polygon[i - 1], polygon[i]);
            }
            e.Graphics.DrawLine(penColor, startPoint, endPoint);
        }
    }



}
