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

        public static Color ToRgb(this HSVModel hsvColor)
        {
            RGBModel color = new RGBModel();
            int r = (int) (hsvColor.Hue / 60);
            float f = hsvColor.Hue / 60 - r;
            int a = (int)hsvColor.Value * (1 - (int)hsvColor.Saturation);
            int b = (int)hsvColor.Value * (int)(1 - hsvColor.Saturation * f);
            int c = (int)hsvColor.Value * (int)(1 - hsvColor.Saturation * (1 - f));

            switch (r)
            {
                case 0:
                    color = new RGBModel() { R = (int)hsvColor.Value, G = c, B = a};
                    break;
                case 1:
                    color = new RGBModel() { R = b, G = (int)hsvColor.Value, B = a};
                    break;
                case 2:
                    color = new RGBModel() { R = a, G = (int)hsvColor.Value, B = c };
                    break;
                case 3:
                    color = new RGBModel() { R = a, G = b, B = (int)hsvColor.Value };
                    break;
                case 4:
                    color = new RGBModel() { R = c, G = a, B = (int)hsvColor.Value };
                    break;
                case 5:
                    color = new RGBModel() { R = (int)hsvColor.Value, G = a, B = b };
                    break;
            }
            return Color.FromArgb(color.R, color.G, color.B);
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
