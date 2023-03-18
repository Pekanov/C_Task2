namespace Task2_number40
{
    partial class Form1
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
            DataMenu = new FlowLayoutPanel();
            File1TextBox = new TextBox();
            File2TextBox = new TextBox();
            File3TextBoxOutput = new TextBox();
            InfoMenu = new Panel();
            SaveNewFileButton = new Button();
            ReadFile2Button = new Button();
            ReadFile1Button = new Button();
            DataMenu.SuspendLayout();
            InfoMenu.SuspendLayout();
            SuspendLayout();
            // 
            // DataMenu
            // 
            DataMenu.BackColor = SystemColors.ActiveBorder;
            DataMenu.Controls.Add(File1TextBox);
            DataMenu.Controls.Add(File2TextBox);
            DataMenu.Controls.Add(File3TextBoxOutput);
            DataMenu.Dock = DockStyle.Bottom;
            DataMenu.Location = new Point(0, 150);
            DataMenu.Name = "DataMenu";
            DataMenu.Size = new Size(1524, 919);
            DataMenu.TabIndex = 1;
            // 
            // File1TextBox
            // 
            File1TextBox.Location = new Point(10, 10);
            File1TextBox.Margin = new Padding(10);
            File1TextBox.Multiline = true;
            File1TextBox.Name = "File1TextBox";
            File1TextBox.Size = new Size(488, 890);
            File1TextBox.TabIndex = 0;
            // 
            // File2TextBox
            // 
            File2TextBox.Location = new Point(518, 10);
            File2TextBox.Margin = new Padding(10);
            File2TextBox.Multiline = true;
            File2TextBox.Name = "File2TextBox";
            File2TextBox.Size = new Size(488, 890);
            File2TextBox.TabIndex = 1;
            // 
            // File3TextBoxOutput
            // 
            File3TextBoxOutput.Location = new Point(1026, 10);
            File3TextBoxOutput.Margin = new Padding(10);
            File3TextBoxOutput.Multiline = true;
            File3TextBoxOutput.Name = "File3TextBoxOutput";
            File3TextBoxOutput.Size = new Size(488, 890);
            File3TextBoxOutput.TabIndex = 2;
            // 
            // InfoMenu
            // 
            InfoMenu.BackColor = SystemColors.ButtonFace;
            InfoMenu.Controls.Add(SaveNewFileButton);
            InfoMenu.Controls.Add(ReadFile2Button);
            InfoMenu.Controls.Add(ReadFile1Button);
            InfoMenu.Dock = DockStyle.Top;
            InfoMenu.Location = new Point(0, 0);
            InfoMenu.Name = "InfoMenu";
            InfoMenu.Size = new Size(1524, 150);
            InfoMenu.TabIndex = 2;
            // 
            // SaveNewFileButton
            // 
            SaveNewFileButton.Location = new Point(1178, 31);
            SaveNewFileButton.Name = "SaveNewFileButton";
            SaveNewFileButton.Size = new Size(169, 34);
            SaveNewFileButton.TabIndex = 2;
            SaveNewFileButton.Text = "save 1 + 2 file";
            SaveNewFileButton.UseVisualStyleBackColor = true;
            SaveNewFileButton.Click += SaveNewFileButton_Click;
            // 
            // ReadFile2Button
            // 
            ReadFile2Button.Location = new Point(719, 31);
            ReadFile2Button.Name = "ReadFile2Button";
            ReadFile2Button.Size = new Size(112, 34);
            ReadFile2Button.TabIndex = 1;
            ReadFile2Button.Text = "open 2 file";
            ReadFile2Button.UseVisualStyleBackColor = true;
            ReadFile2Button.Click += ReadFile2Button_Click;
            // 
            // ReadFile1Button
            // 
            ReadFile1Button.Location = new Point(209, 31);
            ReadFile1Button.Name = "ReadFile1Button";
            ReadFile1Button.Size = new Size(112, 34);
            ReadFile1Button.TabIndex = 0;
            ReadFile1Button.Text = "open 1 file";
            ReadFile1Button.UseVisualStyleBackColor = true;
            ReadFile1Button.Click += ReadFile1Button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1524, 1069);
            Controls.Add(InfoMenu);
            Controls.Add(DataMenu);
            Name = "Form1";
            Text = "Form1";
            DataMenu.ResumeLayout(false);
            DataMenu.PerformLayout();
            InfoMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel DataMenu;
        private TextBox File1TextBox;
        private TextBox File2TextBox;
        private TextBox File3TextBoxOutput;
        private Panel InfoMenu;
        private Button SaveNewFileButton;
        private Button ReadFile2Button;
        private Button ReadFile1Button;
    }
}