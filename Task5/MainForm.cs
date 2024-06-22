namespace Task5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ReplaceForm replaceForm = new ReplaceForm();
            replaceForm.ReplaceText += ReplaceForm_ReplaceText;
        }

        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            ReplaceForm replaceForm = new ReplaceForm();
            replaceForm.ShowDialog();
        }

        private void ReplaceForm_ReplaceText(string searchText, string replaceText)
        {
            mainTextBox.Text = mainTextBox.Text.Replace(searchText, replaceText);
        }
    }
}
