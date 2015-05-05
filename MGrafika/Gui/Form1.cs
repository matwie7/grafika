using System;
using System.Drawing;
using System.Windows.Forms;
using MGrafika.Common;

namespace MGrafika
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
            pictureBox1.Width = bmp.Width;
            pictureBox1.Height = bmp.Height;
            
            pictureBox1.Image = bmp;
        }
    }
}
