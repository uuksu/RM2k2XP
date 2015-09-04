using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using RM2k2XP.Converters;
using RM2k2XP.Converters.Formats;

namespace RM2k2XP.Gui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void charsetSelectionButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "PNG-image (*.png)|*.png";

            var result = fileDialog.ShowDialog();

            if (result == DialogResult.Abort || result == DialogResult.Cancel)
            {
                return;
            }

            charsetPathTextBox.Text = fileDialog.FileName;
        }

        private void outputDirectorySelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            var result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.Abort || result == DialogResult.Cancel)
            {
                return;
            }

            outputDirectoryTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(charsetPathTextBox.Text) || String.IsNullOrEmpty(outputDirectoryTextBox.Text))
            {
                return;
            }

            if (!File.Exists(charsetPathTextBox.Text) || !Directory.Exists(outputDirectoryTextBox.Text))
            {
                return;
            }

            FileInfo inputFileInfo = new FileInfo(charsetPathTextBox.Text);

            RPGMaker2000CharsetConverter converter = new RPGMaker2000CharsetConverter();
            List<RPGMakerXPCharset> charsets = converter.ToRPGMakerXpCharset(charsetPathTextBox.Text);

            for (int i = 0; i < charsets.Count; i++)
            {
                string outputPath = Path.Combine(outputDirectoryTextBox.Text,
                    String.Format("{0}_{1}", Path.GetFileNameWithoutExtension(inputFileInfo.FullName), i));

                charsets[i].Save(outputPath);
            }

            MessageBox.Show("Conversion successful!", "Conversion successful!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void chipsetSelectionButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "PNG-image (*.png)|*.png";

            var result = fileDialog.ShowDialog();

            if (result == DialogResult.Abort || result == DialogResult.Cancel)
            {
                return;
            }

            chipsetPathTextBox.Text = fileDialog.FileName;
        }

        private void tilesetOutputDirectorySelectButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            var result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.Abort || result == DialogResult.Cancel)
            {
                return;
            }

            tilesetOutputDirectoryTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void chipsetConvertButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(chipsetPathTextBox.Text) || String.IsNullOrEmpty(tilesetOutputDirectoryTextBox.Text))
            {
                return;
            }

            if (!File.Exists(chipsetPathTextBox.Text) || !Directory.Exists(tilesetOutputDirectoryTextBox.Text))
            {
                return;
            }

            FileInfo inputFileInfo = new FileInfo(chipsetPathTextBox.Text);

            RPGMaker2000ChipsetConverter converter = new RPGMaker2000ChipsetConverter();
            RPGMakerXPTileset tileset = converter.ToRPGMakerXpTileset(chipsetPathTextBox.Text);

            tileset.SaveAll(Path.GetFileNameWithoutExtension(inputFileInfo.FullName), tilesetOutputDirectoryTextBox.Text);

            MessageBox.Show("Conversion successful!", "Conversion successful!", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }
    }
}
