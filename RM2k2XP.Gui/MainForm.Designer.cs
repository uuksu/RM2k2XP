namespace RM2k2XP.Gui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.charsetPathTextBox = new System.Windows.Forms.TextBox();
            this.outputDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.charsetSelectionButton = new System.Windows.Forms.Button();
            this.outputDirectorySelectButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chipsetPathTextBox = new System.Windows.Forms.TextBox();
            this.tilesetOutputDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.chipsetSelectionButton = new System.Windows.Forms.Button();
            this.tilesetOutputDirectorySelectButton = new System.Windows.Forms.Button();
            this.chipsetConvertButton = new System.Windows.Forms.Button();
            this.tabIconImageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ImageList = this.tabIconImageList;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(506, 232);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(498, 205);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Charset";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.58537F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.41463F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.charsetPathTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputDirectoryTextBox, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.charsetSelectionButton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputDirectorySelectButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.convertButton, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(492, 224);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RPG Maker 2000/2003 charset:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output directory:";
            // 
            // charsetPathTextBox
            // 
            this.charsetPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charsetPathTextBox.Location = new System.Drawing.Point(3, 23);
            this.charsetPathTextBox.Name = "charsetPathTextBox";
            this.charsetPathTextBox.Size = new System.Drawing.Size(420, 20);
            this.charsetPathTextBox.TabIndex = 2;
            // 
            // outputDirectoryTextBox
            // 
            this.outputDirectoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputDirectoryTextBox.Location = new System.Drawing.Point(3, 83);
            this.outputDirectoryTextBox.Name = "outputDirectoryTextBox";
            this.outputDirectoryTextBox.Size = new System.Drawing.Size(420, 20);
            this.outputDirectoryTextBox.TabIndex = 3;
            // 
            // charsetSelectionButton
            // 
            this.charsetSelectionButton.Location = new System.Drawing.Point(429, 23);
            this.charsetSelectionButton.Name = "charsetSelectionButton";
            this.charsetSelectionButton.Size = new System.Drawing.Size(60, 23);
            this.charsetSelectionButton.TabIndex = 4;
            this.charsetSelectionButton.Text = "...";
            this.charsetSelectionButton.UseVisualStyleBackColor = true;
            this.charsetSelectionButton.Click += new System.EventHandler(this.charsetSelectionButton_Click);
            // 
            // outputDirectorySelectButton
            // 
            this.outputDirectorySelectButton.Location = new System.Drawing.Point(429, 83);
            this.outputDirectorySelectButton.Name = "outputDirectorySelectButton";
            this.outputDirectorySelectButton.Size = new System.Drawing.Size(60, 23);
            this.outputDirectorySelectButton.TabIndex = 5;
            this.outputDirectorySelectButton.Text = "...";
            this.outputDirectorySelectButton.UseVisualStyleBackColor = true;
            this.outputDirectorySelectButton.Click += new System.EventHandler(this.outputDirectorySelectButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(429, 123);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(60, 23);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(498, 205);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chipset";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.58537F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.41463F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.chipsetPathTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tilesetOutputDirectoryTextBox, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.chipsetSelectionButton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tilesetOutputDirectorySelectButton, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.chipsetConvertButton, 1, 4);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(492, 224);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "RPG Maker 2000/2003 chipset:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Output directory:";
            // 
            // chipsetPathTextBox
            // 
            this.chipsetPathTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chipsetPathTextBox.Location = new System.Drawing.Point(3, 23);
            this.chipsetPathTextBox.Name = "chipsetPathTextBox";
            this.chipsetPathTextBox.Size = new System.Drawing.Size(420, 20);
            this.chipsetPathTextBox.TabIndex = 2;
            // 
            // tilesetOutputDirectoryTextBox
            // 
            this.tilesetOutputDirectoryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tilesetOutputDirectoryTextBox.Location = new System.Drawing.Point(3, 83);
            this.tilesetOutputDirectoryTextBox.Name = "tilesetOutputDirectoryTextBox";
            this.tilesetOutputDirectoryTextBox.Size = new System.Drawing.Size(420, 20);
            this.tilesetOutputDirectoryTextBox.TabIndex = 3;
            // 
            // chipsetSelectionButton
            // 
            this.chipsetSelectionButton.Location = new System.Drawing.Point(429, 23);
            this.chipsetSelectionButton.Name = "chipsetSelectionButton";
            this.chipsetSelectionButton.Size = new System.Drawing.Size(60, 23);
            this.chipsetSelectionButton.TabIndex = 4;
            this.chipsetSelectionButton.Text = "...";
            this.chipsetSelectionButton.UseVisualStyleBackColor = true;
            this.chipsetSelectionButton.Click += new System.EventHandler(this.chipsetSelectionButton_Click);
            // 
            // tilesetOutputDirectorySelectButton
            // 
            this.tilesetOutputDirectorySelectButton.Location = new System.Drawing.Point(429, 83);
            this.tilesetOutputDirectorySelectButton.Name = "tilesetOutputDirectorySelectButton";
            this.tilesetOutputDirectorySelectButton.Size = new System.Drawing.Size(60, 23);
            this.tilesetOutputDirectorySelectButton.TabIndex = 5;
            this.tilesetOutputDirectorySelectButton.Text = "...";
            this.tilesetOutputDirectorySelectButton.UseVisualStyleBackColor = true;
            this.tilesetOutputDirectorySelectButton.Click += new System.EventHandler(this.tilesetOutputDirectorySelectButton_Click);
            // 
            // chipsetConvertButton
            // 
            this.chipsetConvertButton.Location = new System.Drawing.Point(429, 123);
            this.chipsetConvertButton.Name = "chipsetConvertButton";
            this.chipsetConvertButton.Size = new System.Drawing.Size(60, 23);
            this.chipsetConvertButton.TabIndex = 6;
            this.chipsetConvertButton.Text = "Convert";
            this.chipsetConvertButton.UseVisualStyleBackColor = true;
            this.chipsetConvertButton.Click += new System.EventHandler(this.chipsetConvertButton_Click);
            // 
            // tabIconImageList
            // 
            this.tabIconImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("tabIconImageList.ImageStream")));
            this.tabIconImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.tabIconImageList.Images.SetKeyName(0, "charset_icon.png");
            this.tabIconImageList.Images.SetKeyName(1, "chipset_icon.png");
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(506, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(506, 256);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "RM2k2XP";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox charsetPathTextBox;
        private System.Windows.Forms.TextBox outputDirectoryTextBox;
        private System.Windows.Forms.Button charsetSelectionButton;
        private System.Windows.Forms.Button outputDirectorySelectButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox chipsetPathTextBox;
        private System.Windows.Forms.TextBox tilesetOutputDirectoryTextBox;
        private System.Windows.Forms.Button chipsetSelectionButton;
        private System.Windows.Forms.Button tilesetOutputDirectorySelectButton;
        private System.Windows.Forms.Button chipsetConvertButton;
        private System.Windows.Forms.ImageList tabIconImageList;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

