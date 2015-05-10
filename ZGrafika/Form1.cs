using System;
using System.Drawing;
using System.Windows.Forms;
using ZGrafika.IO;

namespace ZGrafika
{
    public partial class Form1 : Form
    {
        private Bitmap _bmp;
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Btn_Click(object sender, EventArgs e)
        {
            _bmp = OpenFile.AsBitmap();
            WorkArea.Width = _bmp.Width;
            WorkArea.Height = _bmp.Height;

            WorkArea.Image = _bmp;
        }

        private void Save_Btn_Click(object sender, EventArgs e)
        {
            SaveFile.SaveAs(WorkArea);
        }
    }
}
