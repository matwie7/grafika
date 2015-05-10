using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ZGrafika.IO
{
    public static class SaveFile
    {
        private const string Extensions = "JPEG File|*.jpg|GIF File|*.gif|PNG File|*.png|BMP File|*.bmp";
        public static void SaveAs(PictureBox pictureBox)
        {
            SaveFileDialog dialog = new SaveFileDialog() {Filter = Extensions};
            dialog.ShowDialog();
            dialog.AddExtension = true;
            if (dialog.FileName == "") return;
            if (File.Exists(dialog.FileName))
                File.Delete(dialog.FileName);
            var temptosave = new Bitmap(pictureBox.Image);
            temptosave.Save(dialog.FileName);
        }
    }
}
