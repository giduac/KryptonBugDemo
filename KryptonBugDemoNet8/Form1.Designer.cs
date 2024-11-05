namespace KryptonBugDemoNet8
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
            textBox1 = new TextBox();
            kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            kryptonTextBox3 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonCustomPaletteBase1 = new Krypton.Toolkit.KryptonCustomPaletteBase(components);
            kryptonManager1 = new Krypton.Toolkit.KryptonManager(components);
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            textBox1.Location = new Point(590, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(184, 155);
            textBox1.TabIndex = 10;
            textBox1.Text = "The KryptonBasePallete has the InputControlStyles modified to have Content Padding set to 5\r\n\r\nThe difference in heights of the controls can be seen";
            // 
            // kryptonComboBox1
            // 
            kryptonComboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonComboBox1.DropDownWidth = 561;
            kryptonComboBox1.IntegralHeight = false;
            kryptonComboBox1.Location = new Point(12, 144);
            kryptonComboBox1.Name = "kryptonComboBox1";
            kryptonComboBox1.Size = new Size(561, 22);
            kryptonComboBox1.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            kryptonComboBox1.TabIndex = 9;
            kryptonComboBox1.Text = "kryptonComboBox1";
            // 
            // kryptonTextBox3
            // 
            kryptonTextBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonTextBox3.Location = new Point(12, 100);
            kryptonTextBox3.Name = "kryptonTextBox3";
            kryptonTextBox3.Size = new Size(561, 28);
            kryptonTextBox3.TabIndex = 8;
            kryptonTextBox3.Text = "kryptonTextBox3";
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonTextBox2.Location = new Point(12, 56);
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(561, 28);
            kryptonTextBox2.TabIndex = 7;
            kryptonTextBox2.Text = "kryptonTextBox2";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            kryptonTextBox1.Location = new Point(12, 12);
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(561, 28);
            kryptonTextBox1.TabIndex = 6;
            kryptonTextBox1.Text = "kryptonTextBox1";
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BasePaletteType = Krypton.Toolkit.BasePaletteType.Custom;
            kryptonCustomPaletteBase1.InputControlStyles.InputControlCommon.StateCommon.Content.Padding = new Padding(5);
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseThemeFormChromeBorderWidth = Krypton.Toolkit.InheritBool.True;
            // 
            // kryptonManager1
            // 
            kryptonManager1.GlobalCustomPalette = kryptonCustomPaletteBase1;
            kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Custom;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 179);
            Controls.Add(textBox1);
            Controls.Add(kryptonComboBox1);
            Controls.Add(kryptonTextBox3);
            Controls.Add(kryptonTextBox2);
            Controls.Add(kryptonTextBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)kryptonComboBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
    }
}
