using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CommandLine.Text;

namespace RM2k2XP.Cli
{
    class CommandLineOptions
    {
        [ValueList(typeof(List<string>), MaximumElements = 1)]
        public IList<string> InputPaths { get; set; }

        [Option('t', "type", Required = true, HelpText = "Source resource type")]
        public string Type { get; set; }

        [HelpOption]
        public string GetUsage()
        {
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(entryAssembly.Location);

            HelpText help = new HelpText
            {
                Heading = new HeadingInfo("RM2k2XP", fvi.FileVersion),
                Copyright = new CopyrightInfo("Mikko Uuksulainen", 2015),
                AdditionalNewLineAfterOption = true,
                AddDashesToOption = true
            };

            help.AddPreOptionsLine(Environment.NewLine);
            help.AddPreOptionsLine("Usage: RM2k2XP <inputPath> [options]");
            help.AddOptions(this);

            return help;
        }
    }
}
