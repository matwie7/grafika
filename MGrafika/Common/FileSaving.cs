using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MGrafika.Common
{
    public static class FileSaving
    {
        private const string Mask = "JPEG File|*.jpg|GIF File|*.gif|PNG File|*.png|BMP File|*.bmp";
        public static void SaveFile(PictureBox pictureBox)
        {
            SaveFileDialog dialog = new SaveFileDialog() { Filter = Mask };
            dialog.ShowDialog();
            dialog.AddExtension = true;
            if (dialog.FileName.Equals(String.Empty)) return;
            if (File.Exists(dialog.FileName))
                File.Delete(dialog.FileName);
            var temptosave = new Bitmap(pictureBox.Image);
            temptosave.Save(dialog.FileName);
        }
    }
}
