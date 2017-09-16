﻿using System;
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
        PictureBox pictureBoxCurrent;

        public Form1()
        {
            InitializeComponent();
            DisableControls();
            btnMoveLeft.Enabled = false;
            btnMoveRight.Enabled = false;
            radioButton1.Checked = true;
            pictureBoxCurrent = pictureBox1;
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
                    pictureBoxCurrent.Image = bmp;
                    if (radioButton1.Checked)
                    {
                        btnMoveRight.Enabled = true;
                        g1 = Graphics.FromImage(pictureBox1.Image);
                    }
                    else
                    {
                        btnMoveLeft.Enabled = true;
                        g2 = Graphics.FromImage(pictureBox2.Image);
                    }
                }
            }
            catch (Exception)
            {
                throw new ApplicationException("Failed loading image");
            }
            EnableControls();
            refreshHistogramRGB();
        }

        private void refreshHistogramRGB()
        {
            chartRGB.Series[0].Points.Clear();
            chartRGB.Series[1].Points.Clear();
            chartRGB.Series[2].Points.Clear();
            if (pictureBoxCurrent.Image != null)
            {
                for (int i = 0; i < 256; i++)
                {
                    chartRGB.Series[0].Points.Add(0);
                    chartRGB.Series[1].Points.Add(0);
                    chartRGB.Series[2].Points.Add(0);
                }
            
                Bitmap bmp = pictureBoxCurrent.Image as Bitmap;

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
                    chartRGB.Series[0].Points[rgbValues[i + 2]].YValues[0] += 1;
                    chartRGB.Series[1].Points[rgbValues[i + 1]].YValues[0] += 1;
                    chartRGB.Series[2].Points[rgbValues[i + 0]].YValues[0] += 1;
                }
                chartRGB.Series[0].Points[0].YValues[0] = 0;
                chartRGB.Series[1].Points[0].YValues[0] = 0;
                chartRGB.Series[2].Points[0].YValues[0] = 0;

                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

                // Unlock the bits.
                bmp.UnlockBits(bmpData);

                pictureBoxCurrent.Refresh();
            }
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
            if (pictureBoxCurrent.Image != null)
            {
                Bitmap bmp = pictureBoxCurrent.Image as Bitmap;

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

                pictureBoxCurrent.Refresh();
                refreshHistogramRGB();
            }
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            if (pictureBoxCurrent.Image != null)
            {
                Bitmap bmp = pictureBoxCurrent.Image as Bitmap;

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

                pictureBoxCurrent.Refresh();
                refreshHistogramRGB();
            }
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            if (pictureBoxCurrent.Image != null)
            {
                Bitmap bmp = pictureBoxCurrent.Image as Bitmap;

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

                pictureBoxCurrent.Refresh();
                refreshHistogramRGB();
            }
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox2.Image = (Image)pictureBox1.Image.Clone();
                g2 = Graphics.FromImage(pictureBox2.Image);
                pictureBox2.Refresh();
                btnMoveLeft.Enabled = true;
            }
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image != null)
            {
                pictureBox1.Image = (Image)pictureBox2.Image.Clone();
                g1 = Graphics.FromImage(pictureBox1.Image);
                pictureBox1.Refresh();
                btnMoveRight.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBoxCurrent = pictureBox1;
                radioButton2.Checked = false;
                refreshHistogramRGB();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBoxCurrent = pictureBox2;
                radioButton1.Checked = false;
                refreshHistogramRGB();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = true;
        }
        



    }
}
