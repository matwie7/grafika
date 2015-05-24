using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZGrafika.Operations
{
    public static class Operations
    {
        public static Bitmap Brightness(this PictureBox pictureBox)
        {
            var bmp = new Bitmap(pictureBox.Image);

            return bmp;
        }
    }
}
