using System;
using System.Drawing;
using MGrafika.Common;

namespace MGrafika.GrOperations
{
    public static class ColorOperations
    {
        public static HSVModel ToHsv(this Color color)
        {
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));
            int r = max - min;

            return new HSVModel {Hue = color.GetH(),
                Saturation = ((max == 0) ? 0 : (r/(float)max)),
                Value = max};
        }

        private static float GetH(this Color color)
        {
            float hue = 0;
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));
            var r = max - min;

            if (max == color.G)
                hue = 60*(color.B - color.R)/(float)r + 120;
            else if (max == color.B)
                hue = 60*(color.R - color.G)/(float)r + 240;
            else if (max == color.R)
                hue = 60*(color.G - color.B)/(float)r;
            return hue;
        }
    }
}
