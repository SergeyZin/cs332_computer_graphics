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
        int penThickness = 1;
        Color borderColor = Color.FromArgb(255, 0, 0, 0);
        Color fillColor = Color.Green;        
        Pen borderPen;
        Pen fillPen;
        Image fillImage;

        public Form1()
        {
            InitializeComponent();

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            borderColorPan.BackColor = borderColor;
            fillColorPan.BackColor = fillColor;
            update_pens();

            radioPen.Checked = true;

            g.DrawRectangle(new Pen(borderColor, 2), 5, 5, 50, 50);
        }

        private void update_pens()
        {
            borderPen = new Pen(borderColor, penThickness);
            fillPen = new Pen(fillColor, 1);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown && radioPen.Checked && lastPoint != null)
            {
                    g.DrawLine(borderPen, lastPoint, e.Location);
                    lastPoint = e.Location; //keep assigning the lastPoint to the current mouse position
                    pictureBox1.Invalidate();    
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            lastPoint = Point.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (radioFillColor.Checked)
            {
                MouseEventArgs m = (MouseEventArgs)e;
                Point p = m.Location;
                simpleFloodFill(p);
                pictureBox1.Invalidate();
            }
            if (radioFillTexture.Checked)
            {
                MouseEventArgs m = (MouseEventArgs)e;
                Point p = m.Location;
                textureFill(p);
                pictureBox1.Invalidate();
            }
        }

        private void chooseBorderColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                borderColor = colorDlg.Color;
                borderColorPan.BackColor = colorDlg.Color;
                update_pens();
            }
        }

        private void chooseColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                fillColor = colorDlg.Color;
                fillColorPan.BackColor = colorDlg.Color;
                update_pens();
            }
        }

        private void loadFillImage()
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter =
                "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    fillImage = Image.FromFile(openDialog.FileName);
                    pictureBox2.Image = fillImage;
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void chooseImageBtn_Click(object sender, EventArgs e)
        {
            loadFillImage();
        }

        private void floodRedrawBtn_Click(object sender, EventArgs e)
        {
            
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
            if (curr != borderColor && curr != fillColor)
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
                g.DrawLine(fillPen, leftPoint, rightPoint);

                for (int i = leftPoint.X; i <= rightPoint.X; ++i)
                {
                    Point upPoint = new Point(i, p.Y + 1);
                    Color upC = getColorAt(upPoint);
                    if (upC.ToArgb() != borderColor.ToArgb() && upC.ToArgb() != fillColor.ToArgb())
                        simpleFloodFill(upPoint);
                }
                for (int i = leftPoint.X; i < rightPoint.X; ++i)
                {
                    Point downPoint = new Point(i, p.Y - 1);
                    Color downC = getColorAt(downPoint);
                    if (downC.ToArgb() != borderColor.ToArgb() && downC.ToArgb() != fillColor.ToArgb())
                        simpleFloodFill(downPoint);
                }
                return;
            }
        }

        private void textureFill(Point p)
        {

        }

        private void radioPen_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {

            }
        }

        private void radioFillColor_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {

            }
        }

        private void radioFillTexture_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {

            }
        }


    }
}
