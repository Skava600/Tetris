namespace TetrisGame
{
    public partial class Options : Form
    {
        const string EnvVarHeight = "field_height";
        const string EnvVarWidth = "field_width";
        public Options()
        {
            InitializeComponent();
            heightTrackBar.Value = Int32.Parse(Environment.GetEnvironmentVariable(EnvVarHeight) ?? "20");
            widthTrackBar.Value = Int32.Parse(Environment.GetEnvironmentVariable(EnvVarWidth) ?? "15");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Environment.SetEnvironmentVariable(EnvVarWidth, widthTrackBar.Value.ToString());
            Environment.SetEnvironmentVariable(EnvVarHeight, heightTrackBar.Value.ToString());
            MessageBox.Show("Settings saved.");
            this.Close();
        }

        private void heightTrackBar_ValueChanged(object sender, EventArgs e)
        {
            heightValueLabel.Text = heightTrackBar.Value.ToString();
        }

        private void widthTrackBar_ValueChanged(object sender, EventArgs e)
        {
            widthValueLabel.Text = widthTrackBar.Value.ToString();
        }
    }
}
