using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MGrafika.Common
{
    public static class FileOpening
    {
        private const string Mask = "JPEG File|*.jpg|GIF File|*.gif|PNG File|*.png|BMP File|*.bmp";

        public static Bitmap GetBitmapFromFile()
        {
            return Image.FromFile(GetFilePath()) as Bitmap;
        }

        public static string GetFilePath()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog {Filter = Mask};
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                return openFileDialog1.FileName;
            throw new FileNotFoundException();
        }


    }
}
