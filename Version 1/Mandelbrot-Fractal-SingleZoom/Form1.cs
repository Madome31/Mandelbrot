using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Mandelbrot_Fractal_SingleZoom
{
    public partial class Form1 : Form
    {
        private int _iterations = 1000;
        private ushort _colorRed = 2, _colorGreen = 3, _colorBlue = 195;

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.DefaultExt = ".png";


            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fractalBox.Image.Save(sfd.FileName);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateStartImage_Click(object sender, EventArgs e)
        {
            Bitmap bit = generateRawImage();
            fractalBox.Image = drawStartImage(bit);
            fractalBox.Refresh();

        }

        private Bitmap drawStartImage(Bitmap b)
        {

            Stopwatch w = new Stopwatch();
            w.Start();

            if (datatypeBox.Text == "Float")
            {
                #region float
                float x, y, x1, y1, xx, xmin, xmax, ymin, ymax = (float)0.0;

                int looper, s, z = 0;
                float intigralX, intigralY = (float)0.0;

                Rectangle rect = new Rectangle(0, 0, b.Width, b.Height);
                var data = b.LockBits(rect, ImageLockMode.WriteOnly, b.PixelFormat);

                byte[] buffer = new byte[data.Height * data.Width * 3];//3, because of three colors per pixel

                xmin = (float)-2.1; // Start x value, normally -2.1
                ymin = (float)-1.3; // Start y value, normally -1.3
                xmax = 1; // Finish x value, normally 1
                ymax = (float)1.3; // Finish y value, normally 1.3
                intigralX = (xmax - xmin) / b.Width; // Make it fill the whole window
                intigralY = (ymax - ymin) / b.Height;
                x = xmin;

                for (s = 1; s < data.Width; s++)
                {
                    y = ymin;
                    for (z = 1; z < data.Height; z++)
                    {
                        x1 = 0;
                        y1 = 0;
                        looper = 0;
                        while (looper < _iterations && (x1 * x1) + (y1 * y1) < 4)
                        {
                            looper++;
                            xx = (x1 * x1) - (y1 * y1) + x;
                            y1 = 2 * x1 * y1 + y;
                            x1 = xx;
                        }

                        // Get the percent of where the looper stopped
                        double perc = looper / ((double)_iterations);
                        // Get that part of a 255 scale
                        int val = ((int)(perc * 255));

                        // Use that number to set the color
                        int offset = ((z * data.Height) + s) * 3;

                        buffer[offset + 0] = Convert.ToByte(val * _colorBlue % 255);
                        buffer[offset + 1] = Convert.ToByte(val * _colorGreen % 255);
                        buffer[offset + 2] = Convert.ToByte(val * _colorRed % 255);
                        y += intigralY;
                    }
                    x += intigralX;
                }
                Marshal.Copy(buffer, 0, data.Scan0, buffer.Length);
                b.UnlockBits(data);

                #endregion
            }

            else if (datatypeBox.Text == "Double")
            {
                #region double

                double x, y, x1, y1, xx, xmin, xmax, ymin, ymax = 0.0;

                int looper, s, z = 0;
                double intigralX, intigralY = 0.0;

                Rectangle rect = new Rectangle(0, 0, b.Width, b.Height);
                var data = b.LockBits(rect, ImageLockMode.WriteOnly, b.PixelFormat);

                byte[] buffer = new byte[data.Height * data.Width * 3];//3, because of three colors per pixel

                xmin = -2.1; // Start x value, normally -2.1
                ymin = -1.3; // Start y value, normally -1.3
                xmax = 1; // Finish x value, normally 1
                ymax = 1.3; // Finish y value, normally 1.3
                intigralX = (xmax - xmin) / b.Width; // Make it fill the whole window
                intigralY = (ymax - ymin) / b.Height;
                x = xmin;

                for (s = 1; s < data.Width; s++)
                {
                    y = ymin;
                    for (z = 1; z < data.Height; z++)
                    {
                        x1 = 0;
                        y1 = 0;
                        looper = 0;
                        while (looper < _iterations && (x1 * x1) + (y1 * y1) < 4)
                        {
                            looper++;
                            xx = (x1 * x1) - (y1 * y1) + x;
                            y1 = 2 * x1 * y1 + y;
                            x1 = xx;
                        }

                        // Get the percent of where the looper stopped
                        double perc = looper / ((double)_iterations);
                        // Get that part of a 255 scale
                        int val = ((int)(perc * 255));

                        // Use that number to set the color
                        int offset = ((z * data.Height) + s) * 3;

                        buffer[offset + 0] = Convert.ToByte(val * _colorBlue % 255);
                        buffer[offset + 1] = Convert.ToByte(val * _colorGreen % 255);
                        buffer[offset + 2] = Convert.ToByte(val * _colorRed % 255);
                        y += intigralY;
                    }
                    x += intigralX;
                }
                Marshal.Copy(buffer, 0, data.Scan0, buffer.Length);
                b.UnlockBits(data);
                #endregion
            }
            else if (datatypeBox.Text == "Decimal")
            {
                #region decimal
                decimal x, y, x1, y1, xx, xmin, xmax, ymin, ymax = (decimal)0.0;

                int looper, s, z = 0;
                decimal intigralX, intigralY = (decimal)0.0;

                Rectangle rect = new Rectangle(0, 0, b.Width, b.Height);
                var data = b.LockBits(rect, ImageLockMode.WriteOnly, b.PixelFormat);

                byte[] buffer = new byte[data.Height * data.Width * 3];//3, because of three colors per pixel

                xmin = (decimal)-2.1; // Start x value, normally -2.1
                ymin = (decimal)-1.3; // Start y value, normally -1.3
                xmax = 1; // Finish x value, normally 1
                ymax = (decimal)1.3; // Finish y value, normally 1.3
                intigralX = (xmax - xmin) / b.Width; // Make it fill the whole window
                intigralY = (ymax - ymin) / b.Height;
                x = xmin;

                for (s = 1; s < data.Width; s++)
                {
                    y = ymin;
                    for (z = 1; z < data.Height; z++)
                    {
                        x1 = 0;
                        y1 = 0;
                        looper = 0;
                        while (looper < _iterations && (x1 * x1) + (y1 * y1) < 4)
                        {
                            looper++;
                            xx = (x1 * x1) - (y1 * y1) + x;
                            y1 = 2 * x1 * y1 + y;
                            x1 = xx;
                        }

                        // Get the percent of where the looper stopped
                        double perc = looper / ((double)_iterations);
                        // Get that part of a 255 scale
                        int val = ((int)(perc * 255));

                        // Use that number to set the color
                        int offset = ((z * data.Height) + s) * 3;

                        buffer[offset + 0] = Convert.ToByte(val * _colorBlue % 255);
                        buffer[offset + 1] = Convert.ToByte(val * _colorGreen % 255);
                        buffer[offset + 2] = Convert.ToByte(val * _colorRed % 255);
                        y += intigralY;
                    }
                    x += intigralX;
                }
                Marshal.Copy(buffer, 0, data.Scan0, buffer.Length);
                b.UnlockBits(data);
                #endregion
            }
            else//Really slow, don´t even think about using it.
            {
                #region SqlDecimal

                SqlDecimal x, y, x1, y1, xx, xmin, xmax, ymin, ymax = (SqlDecimal)0.0;

                int looper, s, z = 0;
                SqlDecimal intigralX, intigralY = (SqlDecimal)0.0;

                Rectangle rect = new Rectangle(0, 0, b.Width, b.Height);
                var data = b.LockBits(rect, ImageLockMode.WriteOnly, b.PixelFormat);

                byte[] buffer = new byte[data.Height * data.Width * 3];//3, because of three colors per pixel

                xmin = (decimal)-2.1; // Start x value, normally -2.1
                ymin = (decimal)-1.3; // Start y value, normally -1.3
                xmax = 1; // Finish x value, normally 1
                ymax = (SqlDecimal)1.3; // Finish y value, normally 1.3
                intigralX = (xmax - xmin) / b.Width; // Make it fill the whole window
                intigralY = (ymax - ymin) / b.Height;
                x = xmin;

                for (s = 1; s < data.Width; s++)
                {
                    y = ymin;
                    for (z = 1; z < data.Height; z++)
                    {
                        x1 = 0;
                        y1 = 0;
                        looper = 0;
                        while (looper < _iterations && (x1 * x1) + (y1 * y1) < 4)
                        {
                            looper++;
                            xx = (x1 * x1) - (y1 * y1) + x;
                            y1 = 2 * x1 * y1 + y;
                            x1 = xx;
                        }

                        // Get the percent of where the looper stopped
                        double perc = looper / ((double)_iterations);
                        // Get that part of a 255 scale
                        int val = ((int)(perc * 255));

                        // Use that number to set the color
                        int offset = ((z * data.Height) + s) * 3;

                        buffer[offset + 0] = Convert.ToByte(val * _colorBlue % 255);
                        buffer[offset + 1] = Convert.ToByte(val * _colorGreen % 255);
                        buffer[offset + 2] = Convert.ToByte(val * _colorRed % 255);
                        y += intigralY;
                    }
                    x += intigralX;
                }
                Marshal.Copy(buffer, 0, data.Scan0, buffer.Length);
                b.UnlockBits(data);

                #endregion 
            }

            w.Stop();
            timeLabel.Text = w.ElapsedMilliseconds.ToString() + " ms";

            return b;
        }
        //These are squares!!!
        private Bitmap generateRawImage()
        {
            Bitmap b = null;

            if (resulutionBox.Text == "HD")
            {
                b = new Bitmap(1280, 1280, PixelFormat.Format24bppRgb);
            }
            else if (resulutionBox.Text == "FullHD")
            {
                b = new Bitmap(1920, 1920, PixelFormat.Format24bppRgb);
            }
            else if (resulutionBox.Text == "4k")
            {
                b = new Bitmap(3840, 3840, PixelFormat.Format24bppRgb);
            }
            else if (resulutionBox.Text == "8k")
            {
                b = new Bitmap(7680, 7680, PixelFormat.Format24bppRgb);
            }
            else if (resulutionBox.Text == "16k")
            {
                b = new Bitmap(15360, 15360, PixelFormat.Format24bppRgb);
            }
            return b;
        }
    }
}
