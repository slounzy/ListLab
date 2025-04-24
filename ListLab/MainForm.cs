namespace ListLab
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void TaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            (new TaskForm()).ShowDialog(this);
            Show();
        }
        private void InfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            (new InfoForm()).ShowDialog(this);
            Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
