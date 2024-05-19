using MCON368.Data.Code;
using MCON368.Entity;
using MCON368.WinForms.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCON368.WinForms.WinForms
{
    public partial class ChatWindowForm : Form
    {
        public GroupChatEntity groupChatEntity = new();
        public List<ChatEntity> chatsList = new();
        public ChatWindowForm()
        {
            InitializeComponent();
        }

        private void ChatWindowForm_Load(object sender, EventArgs e)
        {
            this.Text = groupChatEntity.GroupName;
            chatTitleLabel.Text = groupChatEntity.GroupName;
            ColorConverter colorConverter = new ColorConverter();
            this.BackColor = (Color)colorConverter.ConvertFromString(groupChatEntity.ChatColor.HexNumber);
            this.Refresh();

            chatsList = ChatFactory.getChatsForGroup(groupChatEntity);
            foreach (ChatEntity chatMessage in chatsList)
            {
                panelLayout.Controls.Add(new ChatMessageUserControl { chatEntity = chatMessage });
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            string filename = "C:\\temp\\" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt";
            System.IO.FileStream oFileStr = default(System.IO.FileStream);
            string thePath = System.IO.Path.GetDirectoryName(filename);
            if (!System.IO.Directory.Exists(thePath))
            {
                System.IO .Directory.CreateDirectory(thePath);
            }

            if (!System.IO.File.Exists(filename))
            {
                oFileStr  = new System.IO.FileStream(filename, System.IO.FileMode.CreateNew);
                oFileStr.Close();
            }

            using (StreamWriter outputFile = new StreamWriter(filename, true)) {
                foreach (ChatEntity newItem in chatsList)
                {
                    string theLine = newItem.CreatedDateTime.ToString("yyyy-MM-dd hh:mm:ss") + Environment.NewLine;
                    theLine += newItem.DisplayName + Environment.NewLine;
                    theLine += newItem.ChatMessage + Environment.NewLine;
                    theLine += "-------------------------------------";
                    outputFile.WriteLine(theLine);
                }
            }
            Process.Start("notepad", filename);
        }

        private void onResize(object sender, EventArgs e)
        {
            panelLayout.SuspendLayout();
            foreach (ChatMessageUserControl message in panelLayout.Controls)
            {
                if (message.chatEntity.UserProfileKey == GlobalSettingsEntity.currentUser.UserProfileKey)
                {
                    message.Margin = new System.Windows.Forms.Padding(panelLayout.Width - message.Width - 30, 5, 10, 5);
                }
            }
            panelLayout.ResumeLayout();
        }
    }
}
