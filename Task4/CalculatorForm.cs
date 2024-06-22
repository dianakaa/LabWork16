namespace Task4
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void DigitButton_Click(object sender, EventArgs e)
        {
            Button digitButton = (Button)sender;
            numberTextBox.Text += digitButton.Text;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            numberTextBox.Clear();
        }
    }
}
