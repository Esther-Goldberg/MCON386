using MCON368.Entity;
using MCON368.Data.Code;

namespace MCON368.WinForms.WinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            loginPanel.BackColor = Color.FromArgb(30, Control.DefaultBackColor);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserFactory userFactory = new();
            UserProfileEntity userProfile = userFactory.GetUserInformation(usernameTextbox.Text, passwordTextbox.Text);

            if (userProfile == null || ! string.IsNullOrEmpty(userProfile.ErrorMessage))
            {
                this.Close(); 
            } else
            {
                GlobalSettingsEntity.currentUser = userProfile;
                this.Close();
            }
        }

        private void loginOnEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(null, null);
            }
        }
    }
}
