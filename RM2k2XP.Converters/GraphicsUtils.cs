using System.Drawing;
using System.Drawing.Drawing2D;

namespace RM2k2XP.Converters
{
    static class GraphicsUtils
    {
        public static Graphics GetGraphicsForScaling(Bitmap bitmap)
        {
            Graphics graphics = Graphics.FromImage(bitmap);

            // GDI+ makes no sence: http://stackoverflow.com/a/10115502
            graphics.PixelOffsetMode = PixelOffsetMode.Half;

            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            graphics.SmoothingMode = SmoothingMode.None;

            return graphics;
        }
    }
}
