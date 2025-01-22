namespace KryptonBugDemoNet6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            kryptonManager1 = new Krypton.Toolkit.KryptonManager(components);
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            textBox1 = new TextBox();
            kryptonThemeListBox1 = new Krypton.Toolkit.KryptonThemeListBox();
            propertyGrid1 = new PropertyGrid();
            propertyGrid2 = new PropertyGrid();
            propertyGrid3 = new PropertyGrid();
            comboBox1 = new ComboBox();
            propertyGrid4 = new PropertyGrid();
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).BeginInit();
            SuspendLayout();
            // 
            // kryptonManager1
            // 
            kryptonManager1.GlobalPalette = kryptonCustomPaletteBase1;
            kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Content.Padding = new Padding(5);
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonTextBox1.Location = new Point(12, 12);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(1394, 28);
            kryptonTextBox1.TabIndex = 0;
            kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonTextBox2.Location = new Point(12, 56);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(1394, 28);
            kryptonTextBox2.TabIndex = 1;
            kryptonTextBox2.Text = "kryptonTextBox2";
            // 
            // kryptonTextBox3
            // 
            kryptonTextBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonTextBox3.Location = new Point(12, 100);
            kryptonTextBox3.Name = "kryptonTextBox3";
            kryptonTextBox3.Size = new Size(1394, 28);
            kryptonTextBox3.TabIndex = 2;
            kryptonTextBox3.Text = "kryptonTextBox3";
            // 
            // kryptonComboBox1
            // 
            kryptonComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonComboBox1.DropDownWidth = 561;
            kryptonComboBox1.IntegralHeight = false;
            kryptonComboBox1.Location = new Point(12, 144);
            kryptonComboBox1.MinimumSize = new Size(0, 28);
            kryptonComboBox1.Name = "kryptonComboBox1";
            kryptonComboBox1.Size = new Size(1394, 28);
            kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBox1.TabIndex = 4;
            kryptonComboBox1.Text = "kryptonComboBox1";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Location = new Point(1423, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(184, 154);
            textBox1.TabIndex = 5;
            textBox1.Text = "The KryptonBasePallete has the InputControlStyles modified to have Content Padding set to 5\r\n\r\nThe difference in heights of the controls can be seen";
            // 
            // kryptonThemeListBox1
            // 
            kryptonThemeListBox1.Location = new Point(3, 255);
            kryptonThemeListBox1.Name = "kryptonThemeListBox1";
            kryptonThemeListBox1.Size = new Size(216, 574);
            kryptonThemeListBox1.TabIndex = 6;
            kryptonThemeListBox1.ThemeSelectedIndex = -1;
            // 
            // propertyGrid1
            // 
            propertyGrid1.Location = new Point(225, 255);
            propertyGrid1.Name = "propertyGrid1";
            propertyGrid1.PropertySort = PropertySort.Alphabetical;
            propertyGrid1.SelectedObject = kryptonComboBox1;
            propertyGrid1.Size = new Size(375, 574);
            propertyGrid1.TabIndex = 7;
            // 
            // propertyGrid2
            // 
            propertyGrid2.Location = new Point(606, 255);
            propertyGrid2.Name = "propertyGrid2";
            propertyGrid2.PropertySort = PropertySort.Alphabetical;
            propertyGrid2.SelectedObject = kryptonComboBox1;
            propertyGrid2.Size = new Size(351, 574);
            propertyGrid2.TabIndex = 8;
            // 
            // propertyGrid3
            // 
            propertyGrid3.Location = new Point(963, 255);
            propertyGrid3.Name = "propertyGrid3";
            propertyGrid3.PropertySort = PropertySort.Alphabetical;
            propertyGrid3.SelectedObject = kryptonCustomPaletteBase1;
            propertyGrid3.Size = new Size(314, 574);
            propertyGrid3.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 187);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(1394, 23);
            comboBox1.TabIndex = 10;
            // 
            // propertyGrid4
            // 
            propertyGrid4.Location = new Point(1293, 255);
            propertyGrid4.Name = "propertyGrid4";
            propertyGrid4.PropertySort = PropertySort.Alphabetical;
            propertyGrid4.SelectedObject = comboBox1;
            propertyGrid4.Size = new Size(314, 574);
            propertyGrid4.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1619, 862);
            Controls.Add(propertyGrid4);
            Controls.Add(comboBox1);
            Controls.Add(propertyGrid3);
            Controls.Add(propertyGrid2);
            Controls.Add(propertyGrid1);
            Controls.Add(kryptonThemeListBox1);
            Controls.Add(textBox1);
            Controls.Add(kryptonComboBox1);
            Controls.Add(kryptonTextBox3);
            Controls.Add(kryptonTextBox2);
            Controls.Add(kryptonTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private TextBox textBox1;
        private Krypton.Toolkit.KryptonThemeListBox kryptonThemeListBox1;
        private PropertyGrid propertyGrid1;
        private PropertyGrid propertyGrid2;
        private PropertyGrid propertyGrid3;
        private ComboBox comboBox1;
        private PropertyGrid propertyGrid4;
    }
}
