using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RM2k2XP.Converters.Formats;

namespace RM2k2XP.Converters
{
    public class RPGMaker2000ChipsetConverter
    {
        private List<BitmapRelationMap> bitmapRelationMaps = new List<BitmapRelationMap>
        {
            // Top-left 16x16
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 0, 16, 16), DestinationRectangle = new Rectangle(0, 0, 16, 16) },

            // Top-right 16x16
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 48, 16, 16), DestinationRectangle = new Rectangle(32, 0, 16, 16) },

            // Border top-left 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 0, 8, 8), DestinationRectangle = new Rectangle(0, 16, 8, 8) },

            // Border top-right 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 0, 8, 8), DestinationRectangle = new Rectangle(40, 16, 8, 8) },

            // Border bottom-left 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 8, 8, 8), DestinationRectangle = new Rectangle(0, 56, 8, 8) },

            // Border bottom-right 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 8, 8, 8), DestinationRectangle = new Rectangle(40, 56, 8, 8) },

            // Border left 8x16
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 16, 8, 16), DestinationRectangle = new Rectangle(0, 32, 8, 16) },

            // Border left top 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 24, 8, 8), DestinationRectangle = new Rectangle(0, 24, 8, 8) },

            // Border left bottom 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 16, 8, 8), DestinationRectangle = new Rectangle(0, 48, 8, 8) },

            // Border right 8x16
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 16, 8, 16), DestinationRectangle = new Rectangle(40, 32, 8, 16) },

            // Border right top 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 24, 8, 8), DestinationRectangle = new Rectangle(40, 24, 8, 8) },

            // Border right bottom 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 16, 8, 8), DestinationRectangle = new Rectangle(40, 48, 8, 8) },

            // Border bottom 16x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 40, 16, 8), DestinationRectangle = new Rectangle(16, 56, 16, 8) },

            // Border bottom left 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 40, 8, 8), DestinationRectangle = new Rectangle(8, 56, 8, 8) },

            // Border bottom right 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 40, 8, 8), DestinationRectangle = new Rectangle(32, 56, 8, 8) },

            // Border top 16x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 32, 16, 8), DestinationRectangle = new Rectangle(16, 16, 16, 8) },
            
            // Border top left 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 32, 8, 8), DestinationRectangle = new Rectangle(8, 16, 8, 8) },

            // Border top right 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 32, 8, 8), DestinationRectangle = new Rectangle(32, 16, 8, 8) },

            // Center 16x16
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 64, 16, 16), DestinationRectangle = new Rectangle(16, 32, 16, 16), SourceAbsolute = true },

            // Around center
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 64, 8, 8), DestinationRectangle = new Rectangle(32, 32, 8, 8), SourceAbsolute = true },
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 64, 8, 8), DestinationRectangle = new Rectangle(32, 48, 8, 8), SourceAbsolute = true },
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 64, 8, 8), DestinationRectangle = new Rectangle(16, 48, 8, 8), SourceAbsolute = true },

            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 64, 8, 8), DestinationRectangle = new Rectangle(8, 32, 8, 8), SourceAbsolute = true },
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 64, 8, 8), DestinationRectangle = new Rectangle(24, 32, 8, 8), SourceAbsolute = true },
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 64, 8, 8), DestinationRectangle = new Rectangle(24, 48, 8, 8), SourceAbsolute = true },
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 64, 8, 8), DestinationRectangle = new Rectangle(8, 48, 8, 8), SourceAbsolute = true },

            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 72, 8, 8), DestinationRectangle = new Rectangle(16, 24, 8, 8), SourceAbsolute = true },
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 72, 8, 8), DestinationRectangle = new Rectangle(16, 40, 8, 8), SourceAbsolute = true },
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 72, 8, 8), DestinationRectangle = new Rectangle(32, 40, 8, 8), SourceAbsolute = true },

            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 72, 8, 8), DestinationRectangle = new Rectangle(8, 24, 8, 8), SourceAbsolute = true },
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 72, 8, 8), DestinationRectangle = new Rectangle(24, 24, 8, 8), SourceAbsolute = true },
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 72, 8, 8), DestinationRectangle = new Rectangle(32, 24, 8, 8), SourceAbsolute = true },
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 72, 8, 8), DestinationRectangle = new Rectangle(24, 40, 8, 8), SourceAbsolute = true },
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 72, 8, 8), DestinationRectangle = new Rectangle(8, 40, 8, 8), SourceAbsolute = true },
        };

        public RPGMakerXPTileset ToRPGMakerXpTileset(string inputPath)
        {
            Bitmap sourceBitmap = new Bitmap("outline2.png");

            for (int waterAutotileIndex = 0; waterAutotileIndex < 2; waterAutotileIndex++)
            {
                Bitmap destinationBitmap = new Bitmap(144, 64);

                using (Graphics graphics = GraphicsUtils.GetGraphicsForScaling(destinationBitmap))
                {
                    for (int frameIndex = 0; frameIndex < 3; frameIndex++)
                    {
                        foreach (BitmapRelationMap bitmapRelationMap in bitmapRelationMaps)
                        {
                            Rectangle calculatedSourceRectangle = bitmapRelationMap.SourceRectangle;
                            calculatedSourceRectangle.X += (frameIndex * 16);

                            // If source is absolute it means that water autotile index should not be taken as part of calculations because it is in fixed location
                            if (!bitmapRelationMap.SourceAbsolute)
                            {
                                calculatedSourceRectangle = new Rectangle(
                                    bitmapRelationMap.SourceRectangle.X + (waterAutotileIndex * 48) + (frameIndex * 16),
                                    bitmapRelationMap.SourceRectangle.Y, 
                                    bitmapRelationMap.SourceRectangle.Width,
                                    bitmapRelationMap.SourceRectangle.Height);
                            }

                            // Destination should change depending on frame
                            Rectangle calculatedDestinationRectangle =
                                new Rectangle(
                                    bitmapRelationMap.DestinationRectangle.X + (frameIndex * 48),
                                    bitmapRelationMap.DestinationRectangle.Y,
                                    bitmapRelationMap.DestinationRectangle.Width,
                                    bitmapRelationMap.DestinationRectangle.Height);
                            

                            Bitmap temporaryBitmap = sourceBitmap.Clone(calculatedSourceRectangle, PixelFormat.DontCare);

                            graphics.DrawImage(temporaryBitmap, calculatedDestinationRectangle);

                            temporaryBitmap.Dispose();
                        }
                    }
                }

                Bitmap scaledBitmap = new Bitmap(288, 128);

                using (Graphics scaleGraphics = GraphicsUtils.GetGraphicsForScaling(scaledBitmap))
                {
                    scaleGraphics.DrawImage(destinationBitmap, new Rectangle(0, 0, 288, 128));
                }

                destinationBitmap.Dispose();

                scaledBitmap.Save(String.Format("test-{0}.png", waterAutotileIndex));
                scaledBitmap.Dispose();
            }

            return null;
        }
    }
}
