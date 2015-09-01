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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(506, 256);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(498, 230);
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Original charset:";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 256);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "RM2k2XP";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
    }
}

