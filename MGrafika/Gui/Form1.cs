using System;
using System.Drawing;
using System.Windows.Forms;
using MGrafika.Common;
using MGrafika.GrOperations;

namespace MGrafika.Gui
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            bmp = FileOpening.GetBitmapFromFile();
            if (bmp == null) return;

            pictureBox1.Width = bmp.Width;
            pictureBox1.Height = bmp.Height;
            
            SetBitmap(bmp);
            btnSaveFile.Enabled = true;
        }

        private void SetBitmap(Bitmap bmp)
        {
            pictureBox1.Image = bmp;
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            FileSaving.SaveFile(pictureBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetBitmap(pictureBox1.Negate());
        }

        private void drawHistogram(Bitmap bmp)
        {
            int[] histogramArray = new int[256];
            for(int i = 0; i < bmp.Width; i++)
            {
                for(int j = 0; j < bmp.Height; j++)
                {
                    HSVModel hsv = bmp.GetPixel(i, j).ToHsv();
                    histogramArray[(int)hsv.Value]++;
                }
            }

            Pen pen = new Pen(Color.Black);

            Graphics formGraphics = pictureBoxHistogram.CreateGraphics();

            for(int i = 0; i < 256; i++)
                formGraphics.DrawLine(pen, i, 128, i, 128 - (histogramArray[i] / 40));
            pen.Dispose();
            formGraphics.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bmp != null)
            {
                Graphics formGraphics = pictureBoxHistogram.CreateGraphics();
                Pen pen = new Pen(Color.White);
                for (int i = 0; i < 256; i++)
                    formGraphics.DrawLine(pen, i, 0, i, 128);
                pen.Dispose();
                formGraphics.Dispose();

                drawHistogram(bmp);
            }
        }
    }
}
