namespace hugo_easy_blog
{
    partial class HugoEasyBlog
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
            ControlsGroupBox = new GroupBox();
            StartServerButton = new Button();
            ControlsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ControlsGroupBox
            // 
            ControlsGroupBox.Controls.Add(StartServerButton);
            ControlsGroupBox.Location = new Point(12, 12);
            ControlsGroupBox.Name = "ControlsGroupBox";
            ControlsGroupBox.Size = new Size(300, 391);
            ControlsGroupBox.TabIndex = 0;
            ControlsGroupBox.TabStop = false;
            ControlsGroupBox.Text = "Controls";
            // 
            // StartServerButton
            // 
            StartServerButton.Location = new Point(6, 30);
            StartServerButton.Name = "StartServerButton";
            StartServerButton.Size = new Size(288, 34);
            StartServerButton.TabIndex = 0;
            StartServerButton.Text = "Start Server";
            StartServerButton.UseVisualStyleBackColor = true;
            StartServerButton.Click += StartServerButton_Click;
            // 
            // HugoEasyBlog
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1343, 782);
            Controls.Add(ControlsGroupBox);
            Name = "HugoEasyBlog";
            Text = "Hugo Easy Blog";
            ControlsGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ControlsGroupBox;
        private Button StartServerButton;
    }
}
