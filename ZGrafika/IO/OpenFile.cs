using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ZGrafika.IO
{
    public static class OpenFile
    {
        private const string Extensions = "JPEG File|*.jpg|GIF File|*.gif|PNG File|*.png|BMP File|*.bmp";

        public static Bitmap AsBitmap()
        {
            return Image.FromFile(GetFilePath()) as Bitmap;
        }

        private static string GetFilePath()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog { Filter = Extensions };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                return openFileDialog1.FileName;
            throw new FileNotFoundException();
        }
    }
}
