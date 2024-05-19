using MCON368.Entity;
using MCON368.WinForms.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCON368.WinForms.UserControls
{
    public partial class GroupChatTileControl : UserControl
    {
        public GroupChatEntity CurrentChat = new();

        public GroupChatTileControl()
        {
            InitializeComponent();
        }

        private void GroupChatTileControl_Load(object sender, EventArgs e)
        {
            ColorConverter colorConverter = new ColorConverter();
            titleLabel.Text = CurrentChat.GroupName;
            memberCountLabel.Text = CurrentChat.NumberOfUsers.ToString();
            messageCountLabel.Text = CurrentChat.NumberOfChats.ToString();
            this.Tag = CurrentChat;
            this.BackColor = (Color)colorConverter.ConvertFromString(CurrentChat.ChatColor.HexNumber);
            this.Refresh();
        }

        private void HandleTileClick(object? sender, EventArgs e)
        {
            ChatWindowForm newChat = new();
            newChat.groupChatEntity = CurrentChat;
            newChat.Show();
        }
    }
}
