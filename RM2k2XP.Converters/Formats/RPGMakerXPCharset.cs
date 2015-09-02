using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM2k2XP.Converters.Formats
{
    public class RPGMakerXPCharset : IDisposable
    {
        public Bitmap Bitmap { get; set; }

        public void Save(string name)
        {
            Bitmap.Save(string.Format("{0}.png", name));
        }

        public void Dispose()
        {
            Bitmap.Dispose();
        }
    }
}
