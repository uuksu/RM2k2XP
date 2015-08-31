using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RM2k2XP.Converters.Formats;

namespace RM2k2XP.Converters
{
    public class RPGMaker2000CharsetConverter
    {
        /// <summary>
        /// Describes how single characters are positioned in 2000 charset and in XP charset.
        /// Format: source index x, source index y, destination index x, destination index y.
        /// </summary>
        private static List<List<int>> RPGMaker2000CharPositionToXPMap = new List<List<int>>
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

        public RPGMakerXPCharset ToRPGMakerXpCharset(string inputPath)
        {
            throw new NotImplementedException();
        }
    }
}
