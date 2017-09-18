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
            refreshHistogram();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxCurrent.Image != null)
            {
                SaveFileDialog savedialog = new SaveFileDialog();
                savedialog.Title = "Сохранить как...";
                //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.OverwritePrompt = true;
                //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.CheckPathExists = true;
                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
                //отображается ли кнопка "Справка" в диалоговом окне
                savedialog.ShowHelp = true;
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        pictureBoxCurrent.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        private void refreshHistogram()
        {
            chartRGB.Series[0].Points.Clear();
            chartRGB.Series[1].Points.Clear();
            chartRGB.Series[2].Points.Clear();
            chartRGB.Series[3].Points.Clear();

            if (pictureBoxCurrent.Image != null)
            {
                for (int i = 0; i < 256; i++)
                {
                    chartRGB.Series[0].Points.Add(0);
                    chartRGB.Series[1].Points.Add(0);
                    chartRGB.Series[2].Points.Add(0);
                    chartRGB.Series[3].Points.Add(0);
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
                    int avg = (rgbValues[i + 0] + rgbValues[i + 1] + rgbValues[i + 2]) / 3;
                    chartRGB.Series[0].Points[avg].YValues[0] += 1;
                    chartRGB.Series[1].Points[rgbValues[i + 2]].YValues[0] += 1;
                    chartRGB.Series[2].Points[rgbValues[i + 1]].YValues[0] += 1;
                    chartRGB.Series[3].Points[rgbValues[i + 0]].YValues[0] += 1;
                }
                chartRGB.Series[1].Points[0].YValues[0] = 0;
                chartRGB.Series[2].Points[0].YValues[0] = 0;
                chartRGB.Series[3].Points[0].YValues[0] = 0;

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
        }

        private void DisableControls()
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
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
                refreshHistogram();
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
                refreshHistogram();
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
                refreshHistogram();
            }
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox2.Image = (Image)pictureBox1.Image.Clone();
                g2 = Graphics.FromImage(pictureBox2.Image);
                pictureBox2.Refresh();
                refreshHistogram();
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
                refreshHistogram();
                btnMoveRight.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBoxCurrent = pictureBox1;
                radioButton2.Checked = false;
                refreshHistogram();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                pictureBoxCurrent = pictureBox2;
                radioButton1.Checked = false;
                refreshHistogram();
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

        private void btnBW1_Click(object sender, EventArgs e)
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
                    int avg = (rgbValues[i + 0] + rgbValues[i + 1] + rgbValues[i + 2]) / 3;
                    rgbValues[i + 0] = (byte)avg;
                    rgbValues[i + 1] = (byte)avg;
                    rgbValues[i + 2] = (byte)avg;
                }
                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

                // Unlock the bits.
                bmp.UnlockBits(bmpData);

                pictureBoxCurrent.Refresh();
                refreshHistogram();
            }
        }

        private void btnBW2_Click(object sender, EventArgs e)
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
                    int gray = Convert.ToInt32(0.0722 * rgbValues[i + 0] + 0.7152 * rgbValues[i + 1] + 0.2126 * rgbValues[i + 2]);
                    rgbValues[i + 0] = (byte)gray;
                    rgbValues[i + 1] = (byte)gray;
                    rgbValues[i + 2] = (byte)gray;
                }
                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(rgbValues, 0, ptr, bytes);

                // Unlock the bits.
                bmp.UnlockBits(bmpData);

                pictureBoxCurrent.Refresh();
                refreshHistogram();
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null && pictureBox2.Image != null && 
                pictureBox1.Image.Width == pictureBox2.Image.Width &&
                pictureBox1.Image.Height == pictureBox2.Image.Height)
            {
                Bitmap bmp1 = pictureBoxCurrent.Image as Bitmap;
                Bitmap bmp2;
                if (pictureBoxCurrent.Name.Equals("pictureBox1"))
                    bmp2 = pictureBox2.Image as Bitmap;
                else
                    bmp2 = pictureBox1.Image as Bitmap;

                // Lock the bitmap's bits. 
                Rectangle rect1 = new Rectangle(0, 0, bmp1.Width, bmp1.Height);
                System.Drawing.Imaging.BitmapData bmpData1 =
                    bmp1.LockBits(rect1, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    bmp1.PixelFormat);

                Rectangle rect2 = new Rectangle(0, 0, bmp2.Width, bmp2.Height);
                System.Drawing.Imaging.BitmapData bmpData2 =
                    bmp2.LockBits(rect2, System.Drawing.Imaging.ImageLockMode.ReadWrite,
                    bmp2.PixelFormat);

                // Get the address of the first line.
                IntPtr ptr1 = bmpData1.Scan0;
                IntPtr ptr2 = bmpData2.Scan0;

                // Declare an array to hold the bytes of the bitmap.
                int bytes1 = Math.Abs(bmpData1.Stride) * bmp1.Height;
                byte[] rgbValues1 = new byte[bytes1];

                int bytes2 = Math.Abs(bmpData2.Stride) * bmp2.Height;
                byte[] rgbValues2 = new byte[bytes2];

                // Copy the RGB values into the array.
                System.Runtime.InteropServices.Marshal.Copy(ptr1, rgbValues1, 0, bytes1);
                System.Runtime.InteropServices.Marshal.Copy(ptr2, rgbValues2, 0, bytes2);

                // Set every third value to 255. A 24bpp bitmap will look red.  
                for (int i = 0; i < rgbValues1.Length; i += 3)
                {
                    int bDiff = Math.Abs(rgbValues1[i + 0] - rgbValues2[i + 0]);
                    int gDiff = Math.Abs(rgbValues1[i + 1] - rgbValues2[i + 1]);
                    int rDiff = Math.Abs(rgbValues1[i + 2] - rgbValues2[i + 2]);

                    rgbValues1[i + 0] = (byte)bDiff;
                    rgbValues1[i + 1] = (byte)gDiff;
                    rgbValues1[i + 2] = (byte)rDiff;
                }
                // Copy the RGB values back to the bitmap
                System.Runtime.InteropServices.Marshal.Copy(rgbValues1, 0, ptr1, bytes1);
                System.Runtime.InteropServices.Marshal.Copy(rgbValues2, 0, ptr2, bytes2);

                // Unlock the bits.
                bmp1.UnlockBits(bmpData1);
                bmp2.UnlockBits(bmpData2);

                pictureBox1.Refresh();
                pictureBox2.Refresh();
                refreshHistogram();
            }
        }


        



    }
}
