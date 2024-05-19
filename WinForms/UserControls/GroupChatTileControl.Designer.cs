namespace MCON368.WinForms.UserControls
{
    partial class GroupChatTileControl
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
            membersLabel = new Label();
            messagesLabel = new Label();
            memberCountLabel = new Label();
            messageCountLabel = new Label();
            titleLabel = new Label();
            SuspendLayout();
            // 
            // membersLabel
            // 
            membersLabel.AutoSize = true;
            membersLabel.Location = new Point(0, 40);
            membersLabel.Name = "membersLabel";
            membersLabel.Size = new Size(60, 15);
            membersLabel.TabIndex = 0;
            membersLabel.Text = "Members:";
            membersLabel.Click += HandleTileClick;
            // 
            // messagesLabel
            // 
            messagesLabel.AutoSize = true;
            messagesLabel.Location = new Point(0, 55);
            messagesLabel.Name = "messagesLabel";
            messagesLabel.Size = new Size(61, 15);
            messagesLabel.TabIndex = 1;
            messagesLabel.Text = "Messages:";
            messagesLabel.Click += HandleTileClick;
            // 
            // memberCountLabel
            // 
            memberCountLabel.AutoSize = true;
            memberCountLabel.Location = new Point(66, 40);
            memberCountLabel.Name = "memberCountLabel";
            memberCountLabel.Size = new Size(19, 15);
            memberCountLabel.TabIndex = 2;
            memberCountLabel.Text = "99";
            memberCountLabel.Click += HandleTileClick;
            // 
            // messageCountLabel
            // 
            messageCountLabel.AutoSize = true;
            messageCountLabel.Location = new Point(66, 55);
            messageCountLabel.Name = "messageCountLabel";
            messageCountLabel.Size = new Size(19, 15);
            messageCountLabel.TabIndex = 3;
            messageCountLabel.Text = "99";
            messageCountLabel.Click += HandleTileClick;
            // 
            // titleLabel
            // 
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Font = new Font("Book Antiqua", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(0, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(140, 40);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Title";
            titleLabel.TextAlign = ContentAlignment.TopCenter;
            titleLabel.Click += HandleTileClick;
            // 
            // GroupChatTileControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(titleLabel);
            Controls.Add(messageCountLabel);
            Controls.Add(memberCountLabel);
            Controls.Add(messagesLabel);
            Controls.Add(membersLabel);
            Name = "GroupChatTileControl";
            Size = new Size(140, 70);
            Load += GroupChatTileControl_Load;
            Click += HandleTileClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label membersLabel;
        private Label messagesLabel;
        private Label memberCountLabel;
        private Label messageCountLabel;
        private Label titleLabel;
    }
}
