namespace Task5
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
            replaceButton = new Button();
            mainTextBox = new TextBox();
            SuspendLayout();
            // 
            // replaceButton
            // 
            replaceButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            replaceButton.Location = new Point(24, 384);
            replaceButton.Name = "replaceButton";
            replaceButton.Size = new Size(115, 33);
            replaceButton.TabIndex = 1;
            replaceButton.Text = "Замена";
            replaceButton.UseVisualStyleBackColor = true;
            replaceButton.Click += ReplaceButton_Click;
            // 
            // mainTextBox
            // 
            mainTextBox.Location = new Point(24, 23);
            mainTextBox.Multiline = true;
            mainTextBox.Name = "mainTextBox";
            mainTextBox.Size = new Size(751, 355);
            mainTextBox.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 428);
            Controls.Add(mainTextBox);
            Controls.Add(replaceButton);
            Name = "MainForm";
            Text = "Текст";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button replaceButton;
        private TextBox mainTextBox;
    }
}
