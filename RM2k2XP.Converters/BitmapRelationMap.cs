using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM2k2XP.Converters
{
    /// <summary>
    /// Represents mapping information between two bitmaps.
    /// </summary>
    class BitmapRelationMap
    {
        /// <summary>
        /// Rectangle in destination bitmap.
        /// </summary>
        public Rectangle DestinationRectangle { get; set; }

        /// <summary>
        /// Rectangle in source bitmap.
        /// </summary>
        public Rectangle SourceRectangle { get; set; }
    }
}
