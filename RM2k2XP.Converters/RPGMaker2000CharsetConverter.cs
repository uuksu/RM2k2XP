using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using RM2k2XP.Converters.Formats;

namespace RM2k2XP.Converters
{
    public class RPGMaker2000CharsetConverter
    {
        /// <summary>
        /// Describes how single characters are positioned in 2000 charset and in XP charset.
        /// Format: source index x, source index y, destination index x, destination index y.
        /// </summary>
        private static readonly List<List<int>> rpgMaker2000CharPositionToXPMap = new List<List<int>>
        {
            new List<int> {0, 0, 1, 3},
            new List<int> {1, 0, 0, 3},
            new List<int> {1, 0, 2, 3},
            new List<int> {2, 0, 3, 3},
            new List<int> {0, 1, 3, 2},
            new List<int> {1, 1, 0, 2},
            new List<int> {1, 1, 2, 2},
            new List<int> {2, 1, 1, 2},
            new List<int> {0, 2, 1, 0},
            new List<int> {1, 2, 0, 0},
            new List<int> {1, 2, 2, 0},
            new List<int> {2, 2, 3, 0},
            new List<int> {0, 3, 1, 1},
            new List<int> {1, 3, 0, 1},
            new List<int> {1, 3, 2, 1},
            new List<int> {2, 3, 3, 1}

        };

        /// <summary>
        /// Converts RPG Maker 2000 chipset to list of XP charsets.
        /// </summary>
        /// <param name="inputPath">The input path.</param>
        /// <returns></returns>
        /// <exception cref="System.Exception">Charset out of proportions</exception>
        public List<RPGMakerXPCharset> ToRPGMakerXpCharset(string inputPath)
        {
            Bitmap charsetBitmap = new Bitmap(inputPath);

            if (charsetBitmap.Width % 12 != 0 || charsetBitmap.Height % 8 != 0)
            {
                throw new Exception("Charset out of proportions");
            }

            int frameWidth = charsetBitmap.Width / 12;
            int frameHeight = charsetBitmap.Height/8;
 
            List<RPGMakerXPCharset> charsets = new List<RPGMakerXPCharset>();

            for (int y = 0; y < charsetBitmap.Height; y += (frameHeight * 4)) {
                for (int x = 0; x < charsetBitmap.Width; x += (frameWidth * 3)) {
                    Bitmap singleCharacterBitmap = charsetBitmap.Clone(new Rectangle(x, y, (frameWidth * 3), (frameHeight * 4)), PixelFormat.DontCare);
                    RPGMakerXPCharset charset = Convert2000ToXpFormat(singleCharacterBitmap, frameWidth, frameHeight);
                    charsets.Add(charset);
                    singleCharacterBitmap.Dispose();
                }
            }

            charsetBitmap.Dispose();

            return charsets;
        }

        /// <summary>
        /// Convert single RPG Maker 2000 character set bitmap to xp format.
        /// </summary>
        /// <param name="singleCharacterBitmap">The single character bitmap.</param>
        /// <param name="frameWidth">Width of the frame.</param>
        /// <param name="frameHeight">Height of the frame.</param>
        private RPGMakerXPCharset Convert2000ToXpFormat(Bitmap singleCharacterBitmap, int frameWidth, int frameHeight)
        {
            // XP characters sets are 4x4 frames and twice as big in resolution
            int xpCharsetHeight = frameHeight * 4 * 2;
            int xpCharsetWidth = frameWidth * 4 * 2;

            Color topLeftColor = singleCharacterBitmap.GetPixel(0, 0);

            RPGMakerXPCharset xpCharset = new RPGMakerXPCharset {Bitmap = new Bitmap(xpCharsetWidth, xpCharsetHeight) };

            using (Graphics graphics = GraphicsUtils.GetGraphicsForScaling(xpCharset.Bitmap))
            {
                // Looping through every frame of the character set
                for (int y = 0; y < 4; y++)
                {
                    for (int x = 0; x < 3; x++)
                    {
                        // Checking where in the XP character set frame should be positioned
                        foreach (List<int> mapValue in rpgMaker2000CharPositionToXPMap)
                        {
                            if (mapValue[0] != x || mapValue[1] != y)
                            {
                                continue;
                            }

                            Bitmap originalFrameBitmap = singleCharacterBitmap.Clone(new Rectangle(x * frameWidth, y * frameHeight, frameWidth, frameHeight),
                                    PixelFormat.DontCare);

                            originalFrameBitmap.MakeTransparent(topLeftColor);

                            // Calculating position and size for where frame should be drawn
                            int destinationX = mapValue[2]*(frameWidth*2);
                            int destinationY = mapValue[3]*(frameHeight*2);
                            int scaledFrameWidth = frameWidth*2;
                            int scaledFrameHeight = frameHeight*2;

                            // Draw to new bitmap and scale twice as big
                            graphics.DrawImage(originalFrameBitmap, new Rectangle(
                                destinationX,
                                destinationY, 
                                scaledFrameWidth,
                                scaledFrameHeight)
                            );

                            originalFrameBitmap.Dispose();
                        }
                    }
                }
            }

            return xpCharset;
        }


    }
}
