namespace MCON368.WinForms.UserControls
{
    partial class ChatMessageUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chatMessage = new Label();
            chatBubblePanel = new Panel();
            userName = new Label();
            timestamp = new Label();
            chatBubblePanel.SuspendLayout();
            SuspendLayout();
            // 
            // chatMessage
            // 
            chatMessage.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            chatMessage.AutoSize = true;
            chatMessage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            chatMessage.ForeColor = SystemColors.ControlLight;
            chatMessage.Location = new Point(16, 38);
            chatMessage.Name = "chatMessage";
            chatMessage.Size = new Size(107, 21);
            chatMessage.TabIndex = 0;
            chatMessage.Text = "Chat Message";
            chatMessage.TextAlign = ContentAlignment.TopRight;
            // 
            // chatBubblePanel
            // 
            chatBubblePanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            chatBubblePanel.BackColor = SystemColors.HotTrack;
            chatBubblePanel.Controls.Add(userName);
            chatBubblePanel.Controls.Add(timestamp);
            chatBubblePanel.Controls.Add(chatMessage);
            chatBubblePanel.Location = new Point(0, 0);
            chatBubblePanel.Name = "chatBubblePanel";
            chatBubblePanel.Size = new Size(582, 91);
            chatBubblePanel.TabIndex = 1;
            // 
            // userName
            // 
            userName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userName.AutoSize = true;
            userName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            userName.ForeColor = SystemColors.ControlLight;
            userName.Location = new Point(14, 13);
            userName.Name = "userName";
            userName.Size = new Size(109, 25);
            userName.TabIndex = 2;
            userName.Text = "User Name";
            userName.TextAlign = ContentAlignment.TopRight;
            // 
            // timestamp
            // 
            timestamp.AutoSize = true;
            timestamp.Dock = DockStyle.Right;
            timestamp.Font = new Font("Segoe UI Light", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            timestamp.ForeColor = SystemColors.ControlLightLight;
            timestamp.Location = new Point(496, 0);
            timestamp.Margin = new Padding(0, 0, 0, 0);
            timestamp.Name = "timestamp";
            timestamp.Padding = new Padding(10);
            timestamp.Size = new Size(86, 37);
            timestamp.TabIndex = 1;
            timestamp.Text = "timestamp";
            timestamp.TextAlign = ContentAlignment.TopRight;
            // 
            // ChatMessageUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chatBubblePanel);
            Name = "ChatMessageUserControl";
            Size = new Size(582, 91);
            Load += GroupChatTileControl_Load;
            chatBubblePanel.ResumeLayout(false);
            chatBubblePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label chatMessage;
        private Panel chatBubblePanel;
        private Label userName;
        private Label timestamp;
    }
}
