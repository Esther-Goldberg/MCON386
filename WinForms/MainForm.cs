using MCON368.Data.Code;
using MCON368.Entity;
using MCON368.WinForms.Code;
using MCON368.WinForms.UserControls;
using MCON368.WinForms.WinForms;

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
            PopLoginForm();
        }

        private void PopLoginForm()
        {
            LoginForm loginForm = new();
            loginForm.FormClosed += FormClosed;
            loginForm.ShowDialog();
        }

        private void FormClosed(object? sender, FormClosedEventArgs e)
        {
            List<GroupChatEntity> groupList = new();
            if (GlobalSettingsEntity.currentUser == null || GlobalSettingsEntity.currentUser.UserProfileKey <= 0)
            {
                Environment.Exit(0);
            } else
            {
                this.Text = "MCON 368 ChatBot - Welcome Back, " + GlobalSettingsEntity.currentUser.DisplayName;
                this.Refresh();

                groupList = GroupChatFactory.GetGroupChats();

                foreach (GroupChatEntity chat in groupList)
                {
                    panelLayout.Controls.Add(new GroupChatTileControl {  CurrentChat = chat });
                }

            }
        }

    }
}

public static class Extensions
{
    public static string MixedCase(this string theString, bool makeUpperCase)
    {
        string returnData = string.Empty;
        if (!string.IsNullOrEmpty(theString))
        {
            for (int i = 0; i < theString.Length; i++)
            {
                returnData += i % 2 != 0 ? theString.Substring(i, 1).ToLower() : theString.Substring(i, 1).ToUpper();
            }
        }
        return returnData;
    }
}
