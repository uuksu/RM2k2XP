using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace RM2k2XP.Converters.Formats
{
    /// <summary>
    /// Represents RPG Maker XP style tileset with tileset and autotiles in separate files.
    /// </summary>
    public class RPGMakerXPTileset : IDisposable
    {
        public RPGMakerXPTileset()
        {
            AutotileBitmaps = new List<Bitmap>();
        }

        /// <summary>
        /// Main tileset bitmap.
        /// </summary>
        public Bitmap TilesetBitmap { get; set; }

        /// <summary>
        /// Different autotiles for tileset.
        /// </summary>
        public List<Bitmap> AutotileBitmaps { get; set; }

        public Bitmap AnimationBitmap { get; set; }
            
        public void SaveAll(string outputName, string outputPath)
        {
            TilesetBitmap.Save(Path.Combine(outputPath, String.Format("{0}-tileset.png", outputName)), ImageFormat.Png);

            for (int i = 0; i < AutotileBitmaps.Count; i++)
            {
                AutotileBitmaps[i].Save(Path.Combine(outputPath, String.Format("{0}-auto-{1}.png", outputName, i)), ImageFormat.Png);
            }

            AnimationBitmap.Save(Path.Combine(outputPath, String.Format("{0}-anim.png", outputName)), ImageFormat.Png);
        }

        public void Dispose()
        {
            TilesetBitmap.Dispose();

            foreach (Bitmap autotileBitmap in AutotileBitmaps)
            {
                autotileBitmap.Dispose();
            }
        }
    }
}
