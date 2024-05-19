namespace MCON368.WinForms.WinForms
{
    partial class ChatWindowForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatWindowForm));
            mainPanel = new Panel();
            panelLayout = new FlowLayoutPanel();
            titlePanel = new Panel();
            chatTitleLabel = new Label();
            bottomBarPanel = new Panel();
            exportButton = new Button();
            mainPanel.SuspendLayout();
            titlePanel.SuspendLayout();
            bottomBarPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.AutoSize = true;
            mainPanel.Controls.Add(panelLayout);
            mainPanel.Controls.Add(titlePanel);
            mainPanel.Controls.Add(bottomBarPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(800, 450);
            mainPanel.TabIndex = 0;
            // 
            // panelLayout
            // 
            panelLayout.AutoScroll = true;
            panelLayout.Dock = DockStyle.Fill;
            panelLayout.Location = new Point(0, 35);
            panelLayout.Name = "panelLayout";
            panelLayout.Size = new Size(800, 367);
            panelLayout.TabIndex = 4;
            // 
            // titlePanel
            // 
            titlePanel.Controls.Add(chatTitleLabel);
            titlePanel.Dock = DockStyle.Top;
            titlePanel.Location = new Point(0, 0);
            titlePanel.Name = "titlePanel";
            titlePanel.Size = new Size(800, 35);
            titlePanel.TabIndex = 3;
            // 
            // chatTitleLabel
            // 
            chatTitleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            chatTitleLabel.AutoSize = true;
            chatTitleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            chatTitleLabel.Location = new Point(356, 7);
            chatTitleLabel.Name = "chatTitleLabel";
            chatTitleLabel.Size = new Size(95, 25);
            chatTitleLabel.TabIndex = 1;
            chatTitleLabel.Text = "Chat Title";
            // 
            // bottomBarPanel
            // 
            bottomBarPanel.Controls.Add(exportButton);
            bottomBarPanel.Dock = DockStyle.Bottom;
            bottomBarPanel.Location = new Point(0, 402);
            bottomBarPanel.Name = "bottomBarPanel";
            bottomBarPanel.Size = new Size(800, 48);
            bottomBarPanel.TabIndex = 0;
            // 
            // exportButton
            // 
            exportButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exportButton.Location = new Point(713, 13);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(75, 23);
            exportButton.TabIndex = 0;
            exportButton.Text = "&Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += exportButton_Click;
            // 
            // ChatWindowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChatWindowForm";
            Text = "ChatWindowForm";
            Load += ChatWindowForm_Load;
            Resize += onResize;
            mainPanel.ResumeLayout(false);
            titlePanel.ResumeLayout(false);
            titlePanel.PerformLayout();
            bottomBarPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel mainPanel;
        private Label chatTitleLabel;
        private Panel bottomBarPanel;
        private Panel titlePanel;
        private FlowLayoutPanel panelLayout;
        private Button exportButton;
    }
}