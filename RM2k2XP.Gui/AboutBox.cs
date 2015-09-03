using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using RM2k2XP.Converters;

namespace RM2k2XP.Gui
{
    partial class AboutBox : Form
    {
        public AboutBox()
        {
            InitializeComponent();
        }

        private void AboutBox_Load(object sender, EventArgs e)
        {
            Assembly guiAssembly = Assembly.GetEntryAssembly();
            Assembly libraryAssembly = Assembly.GetAssembly(typeof (RPGMaker2000CharsetConverter));

            FileVersionInfo guiAssemblyFileVersionInfo = FileVersionInfo.GetVersionInfo(guiAssembly.Location);
            FileVersionInfo libraryAssemblyFileVersionInfo = FileVersionInfo.GetVersionInfo(libraryAssembly.Location);


            versionLabel.Text = String.Format("Version: GUI: {0}, Library: {1}", 
                guiAssemblyFileVersionInfo.FileVersion,
                libraryAssemblyFileVersionInfo.FileVersion);
        }
    }
}
