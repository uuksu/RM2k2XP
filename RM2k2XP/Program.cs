using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RM2k2XP.Converters;
using RM2k2XP.Converters.Formats;

namespace RM2k2XP
{
    class Program
    {
        static void Main(string[] args)
        {
            RPGMaker2000CharsetConverter converter = new RPGMaker2000CharsetConverter();
            List<RPGMakerXPCharset> charsets = converter.ToRPGMakerXpCharset("hero1.png");

            for (int i = 0; i < charsets.Count; i++)
            {
                charsets[i].Save(i.ToString());
            }
        }
    }
}
