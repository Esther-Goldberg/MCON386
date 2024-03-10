namespace WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calculateButton = new Button();
            firstInputTextBox = new TextBox();
            secondInputTextBox = new TextBox();
            resultsLabel = new Label();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(364, 208);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // firstInputTextBox
            // 
            firstInputTextBox.Location = new Point(364, 90);
            firstInputTextBox.Name = "firstInputTextBox";
            firstInputTextBox.Size = new Size(100, 23);
            firstInputTextBox.TabIndex = 1;
            firstInputTextBox.Leave += TextBoxLeaveEvent;
            // 
            // secondInputTextBox
            // 
            secondInputTextBox.Location = new Point(364, 134);
            secondInputTextBox.Name = "secondInputTextBox";
            secondInputTextBox.Size = new Size(100, 23);
            secondInputTextBox.TabIndex = 2;
            secondInputTextBox.Leave += TextBoxLeaveEvent;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(364, 175);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(37, 15);
            resultsLabel.TabIndex = 3;
            resultsLabel.Text = "Unset";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resultsLabel);
            Controls.Add(secondInputTextBox);
            Controls.Add(firstInputTextBox);
            Controls.Add(calculateButton);
            Name = "MainForm";
            Text = "Main Form";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private TextBox firstInputTextBox;
        private TextBox secondInputTextBox;
        private Label resultsLabel;
    }
}
