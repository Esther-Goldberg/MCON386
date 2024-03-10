using MCON368.WinForms.Code;

namespace WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            doCalculations();
        }

        private void doCalculations()
        {
            if (!LocalFunctions.isNumeric(firstInputTextBox.Text)) { resultsLabel.Text = "Please ensure first number is numeric"; }
            else if (!LocalFunctions.isNumeric(secondInputTextBox.Text)) { resultsLabel.Text = "Please ensure second number is numeric"; }
            else { resultsLabel.Text = (Convert.ToInt32(firstInputTextBox.Text) * Convert.ToInt32(secondInputTextBox.Text)).ToString(); }
        }

        private void TextBoxLeaveEvent(object sender, EventArgs e)
        {
            doCalculations();
        }
    }
}
