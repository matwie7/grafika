using System;
using System.Drawing;
using System.Windows.Forms;

namespace MGrafika.Common
{
    public static class FileOpening
    {
        private const string Mask = "Image(*.jpg, *.gif, *.png, *.bmp)|*.jpg;*.gif;*.png;*.bmp";

        public static Bitmap GetBitmapFromFile()
        {
            string filePath = GetFilePath();
            if (!filePath.Equals(String.Empty))
                return Image.FromFile(filePath) as Bitmap;
            else
                return null;
        }

        public static string GetFilePath()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog {Filter = Mask};
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                return openFileDialog1.FileName;
            return String.Empty;

        }


    }
}
