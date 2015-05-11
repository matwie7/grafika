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
            SetBitmap(Operations.Negate(pictureBox1));
        }
    }
}
