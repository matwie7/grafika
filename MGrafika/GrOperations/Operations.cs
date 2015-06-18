using System.Drawing;
using System.Windows.Forms;

namespace MGrafika.GrOperations
{
    public static class Operations
    {
        public static Bitmap Negate(this PictureBox pictureBox)
        {
            Bitmap bmp = new Bitmap(pictureBox.Image);

            for (int i = 0; i < bmp.Height; i++)
                for (int j = 0; j < bmp.Width; j++)
                {
                    Color kolor = bmp.GetPixel(j, i);
                    kolor = Color.FromArgb(255-kolor.R, 255-kolor.G, 255-kolor.B);
                    bmp.SetPixel(j, i, kolor);
                }
            
            return bmp;
        }
    }
}
