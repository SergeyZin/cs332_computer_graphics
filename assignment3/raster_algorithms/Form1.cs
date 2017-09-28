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

namespace raster_algorithms
{
    public partial class Form1 : Form
    {
        private Graphics g;
        Point lastPoint = Point.Empty;
        bool isMouseDown = false;
        Color floodColor;        
        Color borderColor;
        Pen pencil;
        private bool floodFlag = false;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            borderColor = Color.FromArgb(255, 0, 0, 0);
            g.DrawRectangle(new Pen(borderColor, 2), 5, 5, 50, 50);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)//check to see if the mouse button is down
            {
                if (lastPoint != null)//if our last point is not null, which in this case we have assigned above
                {
                    if (pictureBox1.Image == null)//if no available bitmap exists on the picturebox to draw on
                    {
                        //create a new bitmap
                        Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                        pictureBox1.Image = bmp; //assign the picturebox.Image property to the bitmap created
                    }

                    using (Graphics g = Graphics.FromImage(pictureBox1.Image))
                    {
                        g.DrawLine(pencil, lastPoint, e.Location);
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                        
                    }

                    pictureBox1.Invalidate(); //refreshes the picturebox
                    lastPoint = e.Location;//keep assigning the lastPoint to the current mouse position

                }            
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            lastPoint = Point.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (floodFlag)
            {
                MouseEventArgs m = (MouseEventArgs)e;
                Point p = m.Location;
                simpleFloodFill(p);
            }                
        }

        private void penBtn_Click(object sender, EventArgs e)
        {
            floodFlag = false;
            pencil = new Pen(borderColor, 2);
        }

        private void floodFIllBtn_Click(object sender, EventArgs e)
        {
            floodFlag = true;
            pencil = new Pen(floodColor, 2);
        }

        private void chooseColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                floodColor = colorDlg.Color;
            }
        }

        private void chooseImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter =
                "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {                    
                    // тут, вестимо, функция Гриши с обработкой файла
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void floodRedrawBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private Color getColorAt(Point point)
        {
            return ((Bitmap)pictureBox1.Image).GetPixel(point.X, point.Y);
        }

        
        //заливка выбранным цветом
        private void simpleFloodFill(Point p)
        {
            Color curr = getColorAt(p);
            Point leftPoint = p;
            Point rightPoint = p;
            if (curr != borderColor && curr != floodColor)
            {
                while (curr != borderColor)
                {
                    leftPoint.X -= 1;
                    curr = getColorAt(leftPoint);
                }
                leftPoint.X += 1;
                curr = getColorAt(leftPoint);
                while (curr != borderColor)
                {
                    rightPoint.X += 1;
                    curr = getColorAt(rightPoint);
                }
                rightPoint.X -= 1;
                g.DrawLine(new Pen(floodColor, 1), leftPoint, rightPoint);

                for (int i = leftPoint.X; i <= rightPoint.X; ++i)
                {
                    Point upPoint = new Point(i, p.Y + 1);
                    Color upC = getColorAt(upPoint);
                    if (upC.ToArgb() != borderColor.ToArgb() && upC.ToArgb() != floodColor.ToArgb())
                        simpleFloodFill(upPoint);
                }
                for (int i = leftPoint.X; i < rightPoint.X; ++i)
                {
                    Point downPoint = new Point(i, p.Y - 1);
                    Color downC = getColorAt(downPoint);
                    if (downC.ToArgb() != borderColor.ToArgb() && downC.ToArgb() != floodColor.ToArgb())
                        simpleFloodFill(downPoint);
                }
                return;
            }
        }
    }
}
