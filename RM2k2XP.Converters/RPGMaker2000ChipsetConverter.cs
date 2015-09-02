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
        // Original 16x16 sized autotile without scaling
        private const int Autotile2000Width = 144;
        private const int Autotile2000Height = 64;
        private const int TileSize = 16;

        #region Water autotiles bitmap relational maps
        private readonly List<BitmapRelationMap> waterAutotilesBitmapRelationMaps = new List<BitmapRelationMap>
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
        #endregion

        #region Deep water autotile bitmap relational maps
        private readonly List<BitmapRelationMap> deepWaterAutotileBitmapRelationMaps = new List<BitmapRelationMap>
        {
            // Top-left 16x16
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 96, 16, 16), DestinationRectangle = new Rectangle(0, 0, 16, 16) },

            // Top-right 16x16
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 112, 16, 16), DestinationRectangle = new Rectangle(32, 0, 16, 16) },

            // Border top-left 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 96, 8, 8), DestinationRectangle = new Rectangle(0, 16, 8, 8) },

            // Border top-right 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 96, 8, 8), DestinationRectangle = new Rectangle(40, 16, 8, 8) },

            // Border bottom-left 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 104, 8, 8), DestinationRectangle = new Rectangle(0, 56, 8, 8) },

            // Border bottom-right 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 104, 8, 8), DestinationRectangle = new Rectangle(40, 56, 8, 8) },

            // Border left 8x16
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 112, 8, 16), DestinationRectangle = new Rectangle(0, 32, 8, 16) },

            // Border left top 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 120, 8, 8), DestinationRectangle = new Rectangle(0, 24, 8, 8) },

            // Border left bottom 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 112, 8, 8), DestinationRectangle = new Rectangle(0, 48, 8, 8) },

            // Border right 8x16
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 112, 8, 16), DestinationRectangle = new Rectangle(40, 32, 8, 16) },

            // Border right top 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 120, 8, 8), DestinationRectangle = new Rectangle(40, 24, 8, 8) },

            // Border right bottom 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 112, 8, 8), DestinationRectangle = new Rectangle(40, 48, 8, 8) },

            // Border bottom 16x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 120, 16, 8), DestinationRectangle = new Rectangle(16, 56, 16, 8) },

            // Border bottom left 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 120, 8, 8), DestinationRectangle = new Rectangle(8, 56, 8, 8) },

            // Border bottom right 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 120, 8, 8), DestinationRectangle = new Rectangle(32, 56, 8, 8) },

            // Border top 16x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 112, 16, 8), DestinationRectangle = new Rectangle(16, 16, 16, 8) },
            
            // Border top left 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 112, 8, 8), DestinationRectangle = new Rectangle(8, 16, 8, 8) },

            // Border top right 8x8
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 112, 8, 8), DestinationRectangle = new Rectangle(32, 16, 8, 8) },

            // Center 16x16
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 112, 16, 16), DestinationRectangle = new Rectangle(16, 32, 16, 16) },

            // Around center
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 112, 8, 8), DestinationRectangle = new Rectangle(32, 32, 8, 8) },
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 112, 8, 8), DestinationRectangle = new Rectangle(32, 48, 8, 8) },
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 112, 8, 8), DestinationRectangle = new Rectangle(16, 48, 8, 8) },

            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 112, 8, 8), DestinationRectangle = new Rectangle(8, 48, 8, 8) },
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 112, 8, 8), DestinationRectangle = new Rectangle(24, 48, 8, 8) },
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 112, 8, 8), DestinationRectangle = new Rectangle(8, 32, 8, 8) },

            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 120, 8, 8), DestinationRectangle = new Rectangle(16, 24, 8, 8) },
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 120, 8, 8), DestinationRectangle = new Rectangle(32, 24, 8, 8) },
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 120, 8, 8), DestinationRectangle = new Rectangle(32, 40, 8, 8) },

            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 120, 8, 8), DestinationRectangle = new Rectangle(8, 24, 8, 8) },
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 120, 8, 8), DestinationRectangle = new Rectangle(24, 24, 8, 8) },
            new BitmapRelationMap { SourceRectangle = new Rectangle(8, 120, 8, 8), DestinationRectangle = new Rectangle(8, 40, 8, 8) }

        };
        #endregion

        #region Animation bitmap relational maps
        private readonly List<BitmapRelationMap> animationBitmapRelationMaps = new List<BitmapRelationMap>
        {
            new BitmapRelationMap { SourceRectangle = new Rectangle(48, 64, 16, 16), DestinationRectangle = new Rectangle(0, 0, 16, 16) },
            new BitmapRelationMap { SourceRectangle = new Rectangle(48, 80, 16, 16), DestinationRectangle = new Rectangle(16, 0, 16, 16) },
            new BitmapRelationMap { SourceRectangle = new Rectangle(48, 96, 16, 16), DestinationRectangle = new Rectangle(32, 0, 16, 16) },
            new BitmapRelationMap { SourceRectangle = new Rectangle(48, 112, 16, 16), DestinationRectangle = new Rectangle(48, 0, 16, 16) },
        }; 
        #endregion

        /// <summary>
        /// Convert RPG Maker 2000 chipset to RPG Maker XP format.
        /// </summary>
        /// <param name="inputPath">The input path.</param>
        /// <returns></returns>
        public RPGMakerXPTileset ToRPGMakerXpTileset(string inputPath)
        {
            Bitmap chipsetBitmap = new Bitmap(inputPath);

            RPGMakerXPTileset tileset = new RPGMakerXPTileset();
            tileset.AutotileBitmaps.AddRange(ExtractWaterAutotiles(chipsetBitmap));
            tileset.AutotileBitmaps.Add(ExtractDeepWaterAutotile(chipsetBitmap));
            tileset.AnimationBitmap = ExtractAnimationSheet(chipsetBitmap);

            chipsetBitmap.Dispose();

            return tileset;
        }

        /// <summary>
        /// Extracts the two water autotiles from provided chipset.
        /// </summary>
        /// <param name="chipsetBitmap">The chipset bitmap.</param>
        /// <returns>Autotile bitmaps in XP format.</returns>
        private List<Bitmap> ExtractWaterAutotiles(Bitmap chipsetBitmap)
        {
            List<Bitmap> waterAutotilesBitmaps = new List<Bitmap>();

            for (int waterAutotileIndex = 0; waterAutotileIndex < 2; waterAutotileIndex++)
            {
                Bitmap destinationBitmap = new Bitmap(Autotile2000Width, Autotile2000Height);

                using (Graphics graphics = GraphicsUtils.GetGraphicsForScaling(destinationBitmap))
                {
                    for (int frameIndex = 0; frameIndex < 3; frameIndex++)
                    {
                        foreach (BitmapRelationMap bitmapRelationMap in waterAutotilesBitmapRelationMaps)
                        {
                            Rectangle calculatedSourceRectangle = bitmapRelationMap.SourceRectangle;
                            calculatedSourceRectangle.X += (frameIndex * TileSize);

                            // If source is absolute it means that water autotile index should not be taken as part of calculations because it is in fixed location
                            if (!bitmapRelationMap.SourceAbsolute)
                            {
                                calculatedSourceRectangle = new Rectangle(
                                    bitmapRelationMap.SourceRectangle.X + (waterAutotileIndex * 48) + (frameIndex * TileSize),
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


                            Bitmap temporaryBitmap = chipsetBitmap.Clone(calculatedSourceRectangle, PixelFormat.DontCare);

                            graphics.DrawImage(temporaryBitmap, calculatedDestinationRectangle);

                            temporaryBitmap.Dispose();
                        }
                    }
                }

                // XP tiles are twice the size of 2000 tiles so they need to scaled up
                Bitmap scaledBitmap = new Bitmap(Autotile2000Width * 2, Autotile2000Height * 2);

                using (Graphics scaleGraphics = GraphicsUtils.GetGraphicsForScaling(scaledBitmap))
                {
                    scaleGraphics.DrawImage(destinationBitmap, new Rectangle(0, 0, Autotile2000Width * 2, Autotile2000Height * 2));
                }

                destinationBitmap.Dispose();

                waterAutotilesBitmaps.Add(scaledBitmap);
            }

            return waterAutotilesBitmaps;
        }

        /// <summary>
        /// Extracts the deep water autotile from chipset.
        /// </summary>
        /// <param name="chipsetBitmap">The chipset bitmap.</param>
        /// <returns></returns>
        private Bitmap ExtractDeepWaterAutotile(Bitmap chipsetBitmap)
        {
            Bitmap destinationBitmap = new Bitmap(Autotile2000Width, Autotile2000Height);

            using (Graphics graphics = GraphicsUtils.GetGraphicsForScaling(destinationBitmap))
            {
                for (int frameIndex = 0; frameIndex < 3; frameIndex++)
                {
                    foreach (BitmapRelationMap bitmapRelationMap in deepWaterAutotileBitmapRelationMaps)
                    {
                        Rectangle calculatedSourceRectangle = bitmapRelationMap.SourceRectangle;
                        calculatedSourceRectangle.X += (frameIndex * TileSize);

                        // Destination should change depending on frame
                        Rectangle calculatedDestinationRectangle =
                            new Rectangle(
                                bitmapRelationMap.DestinationRectangle.X + (frameIndex * 48),
                                bitmapRelationMap.DestinationRectangle.Y,
                                bitmapRelationMap.DestinationRectangle.Width,
                                bitmapRelationMap.DestinationRectangle.Height);


                        Bitmap temporaryBitmap = chipsetBitmap.Clone(calculatedSourceRectangle, PixelFormat.DontCare);

                        graphics.DrawImage(temporaryBitmap, calculatedDestinationRectangle);

                        temporaryBitmap.Dispose();
                    }
                }
            }

            // XP tiles are twice the size of 2000 tiles so they need to scaled up
            Bitmap scaledBitmap = new Bitmap(Autotile2000Width * 2, Autotile2000Height * 2);

            using (Graphics scaleGraphics = GraphicsUtils.GetGraphicsForScaling(scaledBitmap))
            {
                scaleGraphics.DrawImage(destinationBitmap, new Rectangle(0, 0, Autotile2000Width * 2, Autotile2000Height * 2));
            }

            destinationBitmap.Dispose();

            return scaledBitmap;
        }

        /// <summary>
        /// Extracts the animations from chipset and convert them to XP charset animation sheet.
        /// </summary>
        /// <param name="chipsetBitmap">The chipset bitmap.</param>
        /// <returns></returns>
        private Bitmap ExtractAnimationSheet(Bitmap chipsetBitmap)
        {
            // There is four frames per animation and animation sheet should be chipset sized
            Bitmap destinationBitmap = new Bitmap(TileSize * 4, TileSize * 4);

            using (Graphics graphics = GraphicsUtils.GetGraphicsForScaling(destinationBitmap))
            {
                // There is three animations in chipset
                for (int animationIndex = 0; animationIndex < 3; animationIndex++)
                {
                    foreach (BitmapRelationMap bitmapRelationMap in animationBitmapRelationMaps)
                    {
                        Rectangle calculatedSourceRectangle = bitmapRelationMap.SourceRectangle;
                        calculatedSourceRectangle.X += (animationIndex * TileSize);

                        // Destination should change depending on frame
                        Rectangle calculatedDestinationRectangle =
                            new Rectangle(
                                bitmapRelationMap.DestinationRectangle.X,
                                bitmapRelationMap.DestinationRectangle.Y + (animationIndex * TileSize),
                                bitmapRelationMap.DestinationRectangle.Width,
                                bitmapRelationMap.DestinationRectangle.Height);

                        Bitmap temporaryBitmap = chipsetBitmap.Clone(calculatedSourceRectangle, PixelFormat.DontCare);

                        graphics.DrawImage(temporaryBitmap, calculatedDestinationRectangle);

                        temporaryBitmap.Dispose();
                    }
                }
            }

            // XP tiles are twice the size of 2000 tiles so they need to scaled up
            Bitmap scaledBitmap = new Bitmap(TileSize * 4 * 2, TileSize * 4 * 2);

            using (Graphics scaleGraphics = GraphicsUtils.GetGraphicsForScaling(scaledBitmap))
            {
                scaleGraphics.DrawImage(destinationBitmap, new Rectangle(0, 0, TileSize * 4 * 2, TileSize * 4 * 2));
            }

            destinationBitmap.Dispose();

            return scaledBitmap;
        }
    }
}
