using System.Drawing;

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

        /// <summary>
        /// Source rectangle is absolute and it should not be used in relative calculations.
        /// </summary>
        public bool SourceAbsolute { get; set; }
    }
}
