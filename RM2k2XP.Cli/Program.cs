using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using RM2k2XP.Converters;
using RM2k2XP.Converters.Formats;

namespace RM2k2XP.Cli
{
    class Program
    {
        private static CommandLineOptions _commandLineOptions;

        static void Main(string[] args)
        {
            _commandLineOptions = new CommandLineOptions();

            if (Parser.Default.ParseArguments(args, _commandLineOptions) == false)
            {
                Environment.Exit(1);
            }

            if (_commandLineOptions.InputPaths.Count == 0)
            {
                Console.WriteLine("Please provide input path.");
                Environment.Exit(1);
            }

            switch (_commandLineOptions.Type)
            {
                case "charset":
                    ProcessCharsetConversion();
                    break;
                case "chipset":
                    ProcessChipsetConversion();
                    break;
                default:
                    Console.WriteLine("Unknown resource type.");
                    Environment.Exit(1);
                    break;
            }
        }

        private static void ProcessCharsetConversion()
        {
            FileInfo inputFileInfo = new FileInfo(_commandLineOptions.InputPaths.First());

            if (!inputFileInfo.Exists)
            {
                Console.WriteLine("Input file does not exists.");
                Environment.Exit(1);
            }

            RPGMaker2000CharsetConverter converter = new RPGMaker2000CharsetConverter();
            List<RPGMakerXPCharset> charsets = converter.ToRPGMakerXpCharset(inputFileInfo.FullName);

            for (int i = 0; i < charsets.Count; i++)
            {
                charsets[i].Save(String.Format("{0}_{1}", Path.GetFileNameWithoutExtension(inputFileInfo.FullName), i));
            }
        }

        private static void ProcessChipsetConversion()
        {
            FileInfo inputFileInfo = new FileInfo(_commandLineOptions.InputPaths.First());

            if (!inputFileInfo.Exists)
            {
                Console.WriteLine("Input file does not exists.");
                Environment.Exit(1);
            }

            RPGMaker2000ChipsetConverter converter = new RPGMaker2000ChipsetConverter();
            RPGMakerXPTileset tileset = converter.ToRPGMakerXpTileset(inputFileInfo.FullName);

            tileset.SaveAll(Path.GetFileNameWithoutExtension(inputFileInfo.FullName), ".");
        }
    }
}
