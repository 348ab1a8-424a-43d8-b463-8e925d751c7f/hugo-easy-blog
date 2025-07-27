namespace hugo_easy_blog
{
    public partial class HugoEasyBlog : Form
    {
        public HugoEasyBlog()
        {
            InitializeComponent();
        }

        private void StartServerButton_Click(object sender, EventArgs e)
        {
            string projectPath = @"R:\jto-website";

            System.Diagnostics.Process.Start("cmd.exe");
        }
    }
}
