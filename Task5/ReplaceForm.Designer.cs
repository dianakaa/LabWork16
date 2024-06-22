namespace Task5
{
    partial class ReplaceForm
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
            searchTextBox = new TextBox();
            replaceTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            replaceButton = new Button();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(82, 13);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(528, 23);
            searchTextBox.TabIndex = 0;
            // 
            // replaceTextBox
            // 
            replaceTextBox.Location = new Point(82, 51);
            replaceTextBox.Name = "replaceTextBox";
            replaceTextBox.Size = new Size(528, 23);
            replaceTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 16);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Найти:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 54);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 3;
            label2.Text = "Заменить:";
            // 
            // replaceButton
            // 
            replaceButton.Location = new Point(85, 88);
            replaceButton.Name = "replaceButton";
            replaceButton.Size = new Size(75, 23);
            replaceButton.TabIndex = 4;
            replaceButton.Text = "Заменить";
            replaceButton.UseVisualStyleBackColor = true;
            replaceButton.Click += ReplaceButton_Click;
            // 
            // ReplaceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 123);
            Controls.Add(replaceButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(replaceTextBox);
            Controls.Add(searchTextBox);
            Name = "ReplaceForm";
            Text = "Замена";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextBox;
        private TextBox replaceTextBox;
        private Label label1;
        private Label label2;
        private Button replaceButton;
    }
}