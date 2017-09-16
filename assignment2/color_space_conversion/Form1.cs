using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace color_space_conversion
{
    public partial class Form1 : Form
    {
        Graphics g1, g2;

        public Form1()
        {
            InitializeComponent();
            DisableControls();
            btnMoveLeft.Enabled = false;
            btnMoveRight.Enabled = false;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bmp = new Bitmap(open.FileName);
                    pictureBox1.Image = bmp;
                    g1 = Graphics.FromImage(pictureBox1.Image);
                    btnMoveRight.Enabled = true;
                }
                EnableControls();
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
        }

        private void moveRight()
        {
 
            pictureBox2.Image = (Image)pictureBox1.Image.Clone();
            g2 = Graphics.FromImage(pictureBox2.Image);
            pictureBox2.Refresh();
            btnMoveLeft.Enabled = true;
        }

        private void moveLeft()
        {
            pictureBox1.Image = (Image)pictureBox2.Image.Clone();
            g1 = Graphics.FromImage(pictureBox1.Image);
            pictureBox1.Refresh();
            btnMoveRight.Enabled = true;
        }

        private void EnableControls()
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;
        }

        private void DisableControls()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            moveRight();

            Bitmap bmp = pictureBox2.Image as Bitmap;

            // Lock the bitmap's bits. 
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                bmp.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            // Set every third value to 255. A 24bpp bitmap will look red.  
            for (int i = 0; i < rgbValues.Length; i += 3)
            {
                rgbValues[i + 0] = 0;
                rgbValues[i + 1] = 0;
            }
            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            // Unlock the bits.
            bmp.UnlockBits(bmpData);

            pictureBox1.Refresh();
            pictureBox2.Refresh();
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            moveRight();

            Bitmap bmp = pictureBox2.Image as Bitmap;

            // Lock the bitmap's bits. 
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                bmp.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            // Set every third value to 255. A 24bpp bitmap will look red.  
            for (int i = 0; i < rgbValues.Length; i += 3)
            {
                rgbValues[i + 0] = 0;
                rgbValues[i + 2] = 0;
            }
            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            // Unlock the bits.
            bmp.UnlockBits(bmpData);

            pictureBox2.Refresh();
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            moveRight();

            Bitmap bmp = pictureBox2.Image as Bitmap;

            // Lock the bitmap's bits. 
            Rectangle rect = new Rectangle(0, 0, bmp.Width, bmp.Height);
            System.Drawing.Imaging.BitmapData bmpData =
                bmp.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                bmp.PixelFormat);

            // Get the address of the first line.
            IntPtr ptr = bmpData.Scan0;

            // Declare an array to hold the bytes of the bitmap.
            int bytes = Math.Abs(bmpData.Stride) * bmp.Height;
            byte[] rgbValues = new byte[bytes];

            // Copy the RGB values into the array.
            System.Runtime.InteropServices.Marshal.Copy(ptr, rgbValues, 0, bytes);

            // Set every third value to 255. A 24bpp bitmap will look red.  
            for (int i = 0; i < rgbValues.Length; i += 3)
            {
                rgbValues[i + 1] = 0;
                rgbValues[i + 2] = 0;
            }
            // Copy the RGB values back to the bitmap
            System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

            // Unlock the bits.
            bmp.UnlockBits(bmpData);

            pictureBox2.Refresh();
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            moveRight();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            moveLeft();
        }



    }
}
