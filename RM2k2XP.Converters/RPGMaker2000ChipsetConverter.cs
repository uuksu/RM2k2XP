using System;
using System.Collections.Generic;
using System.Drawing;
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
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 0, 16, 16), DestinationRectangle = new Rectangle(0, 0, 16, 16) },
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 48, 16, 16), DestinationRectangle = new Rectangle(32, 0, 16, 16) },
            new BitmapRelationMap { SourceRectangle = new Rectangle(0, 0, 8, 8), DestinationRectangle = new Rectangle(0, 16, 8, 8) }
        };

        public RPGMakerXPTileset ToRPGMakerXpTileset(string inputPath)
        {
            throw new NotImplementedException();
        }
    }
}
