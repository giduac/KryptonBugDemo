namespace KryptonBugDemoNet6
{
    public partial class Form1 : Krypton.Toolkit.KryptonForm
    {
        public Form1()
        {
            InitializeComponent();

            kryptonComboBox1.Height = kryptonTextBox1.Height;
            kryptonComboBox1.Width = kryptonTextBox1.Width;
            kryptonComboBox1.IntegralHeight = true;
            kryptonComboBox1.ComboBox!.Dock = DockStyle.Fill;

            propertyGrid2.SelectedObject = kryptonComboBox1.ComboBox;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
