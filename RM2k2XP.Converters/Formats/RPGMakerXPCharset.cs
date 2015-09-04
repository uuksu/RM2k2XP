using System;
using System.Drawing;

namespace RM2k2XP.Converters.Formats
{
    public class RPGMakerXPCharset : IDisposable
    {
        public Bitmap Bitmap { get; set; }

        public void Save(string name)
        {
            Bitmap.Save(String.Format("{0}.png", name));
        }

        public void Dispose()
        {
            Bitmap.Dispose();
        }
    }
}
