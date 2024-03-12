namespace MCON368.WinForms.WinForms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            loginPanel = new Panel();
            passwordLabel = new Label();
            loginButton = new Button();
            usernameTextbox = new TextBox();
            passwordTextbox = new TextBox();
            usernameLabel = new Label();
            headerLabel = new Label();
            closeButton = new Button();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = SystemColors.Control;
            loginPanel.Controls.Add(closeButton);
            loginPanel.Controls.Add(passwordLabel);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Controls.Add(usernameTextbox);
            loginPanel.Controls.Add(passwordTextbox);
            loginPanel.Controls.Add(usernameLabel);
            loginPanel.Controls.Add(headerLabel);
            loginPanel.Location = new Point(61, 25);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(345, 309);
            loginPanel.TabIndex = 0;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLabel.Location = new Point(42, 154);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(76, 21);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password";
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.SteelBlue;
            loginButton.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.ForeColor = Color.WhiteSmoke;
            loginButton.Location = new Point(42, 235);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(259, 42);
            loginButton.TabIndex = 3;
            loginButton.Text = "Log In";
            loginButton.UseVisualStyleBackColor = false;
            // 
            // usernameTextbox
            // 
            usernameTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextbox.Location = new Point(42, 111);
            usernameTextbox.Name = "usernameTextbox";
            usernameTextbox.Size = new Size(259, 29);
            usernameTextbox.TabIndex = 1;
            usernameTextbox.Text = "Username";
            // 
            // passwordTextbox
            // 
            passwordTextbox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextbox.Location = new Point(42, 178);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.Size = new Size(259, 29);
            passwordTextbox.TabIndex = 2;
            passwordTextbox.Text = "Password";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            usernameLabel.Location = new Point(42, 87);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(81, 21);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "Username";
            // 
            // headerLabel
            // 
            headerLabel.AutoSize = true;
            headerLabel.Font = new Font("Levenim MT", 16F, FontStyle.Bold, GraphicsUnit.Point);
            headerLabel.Location = new Point(42, 36);
            headerLabel.Name = "headerLabel";
            headerLabel.Size = new Size(252, 30);
            headerLabel.TabIndex = 0;
            headerLabel.Text = "Log Into Your Account";
            // 
            // closeButton
            // 
            closeButton.BackgroundImage = (Image)resources.GetObject("closeButton.BackgroundImage");
            closeButton.BackgroundImageLayout = ImageLayout.Zoom;
            closeButton.ForeColor = SystemColors.ActiveCaption;
            closeButton.Location = new Point(315, 0);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(30, 30);
            closeButton.TabIndex = 1;
            closeButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(640, 360);
            Controls.Add(loginPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Opacity = 0.95D;
            Text = "Login";
            WindowState = FormWindowState.Minimized;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Label usernameLabel;
        private Label headerLabel;
        private Button loginButton;
        private TextBox usernameTextbox;
        private TextBox passwordTextbox;
        private Label passwordLabel;
        private Button closeButton;
    }
}