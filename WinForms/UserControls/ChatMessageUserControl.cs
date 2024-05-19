using MCON368.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCON368.WinForms.UserControls
{
    public partial class ChatMessageUserControl : UserControl
    {
        public ChatEntity chatEntity = new();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
);
        public ChatMessageUserControl()
        {
            InitializeComponent();
        }

        private void GroupChatTileControl_Load(object sender, EventArgs e)
        {

            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 30, 30));
            chatMessage.Text = chatEntity.ChatMessage.ToString();
            timestamp.Text = chatEntity.CreatedDateTime.ToString();
            userName.Text = chatEntity.DisplayName.ToString();
            
            if (chatEntity.UserProfileKey == GlobalSettingsEntity.currentUser.UserProfileKey)
            {
                chatBubblePanel.BackColor = Color.DarkGray;
                this.Margin = new System.Windows.Forms.Padding(this.Parent.Width - this.Width - 30, 5, 10, 5);
            }
            else
            {
                chatBubblePanel.BackColor = Color.Black;
                this.Margin = new System.Windows.Forms.Padding(10, 5, 10, 5);
            }
            FlowLayoutPanel parent = (FlowLayoutPanel)Parent;
            parent.SetFlowBreak(this, true);
            this.Refresh();
        }

    }
}
