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
        Color floodColor = Color.Wheat;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
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
                        g.DrawLine(new Pen(Color.Black, 2), lastPoint, e.Location);
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
                    image = new Bitmap(openDialog.FileName);
                    sourcePictureBox.Image = image;
                    sourcePictureBox.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
