using System.Drawing;

namespace Grafika.Interfaces
{
    interface IGraphicsOperation
    {
        Bitmap Process(Bitmap bmp);
    }
}
