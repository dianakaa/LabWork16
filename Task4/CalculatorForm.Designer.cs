namespace Task4
{
    partial class CalculatorForm
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            numberTextBox = new TextBox();
            clearButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(101, 100);
            button1.Name = "button1";
            button1.Size = new Size(70, 70);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += DigitButton_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(177, 100);
            button2.Name = "button2";
            button2.Size = new Size(70, 70);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += DigitButton_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(253, 100);
            button3.Name = "button3";
            button3.Size = new Size(70, 70);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += DigitButton_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button4.Location = new Point(101, 176);
            button4.Name = "button4";
            button4.Size = new Size(70, 70);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += DigitButton_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button5.Location = new Point(177, 176);
            button5.Name = "button5";
            button5.Size = new Size(70, 70);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += DigitButton_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button6.Location = new Point(253, 176);
            button6.Name = "button6";
            button6.Size = new Size(70, 70);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += DigitButton_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button7.Location = new Point(101, 252);
            button7.Name = "button7";
            button7.Size = new Size(70, 70);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += DigitButton_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button8.Location = new Point(177, 252);
            button8.Name = "button8";
            button8.Size = new Size(70, 70);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += DigitButton_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button9.Location = new Point(253, 252);
            button9.Name = "button9";
            button9.Size = new Size(70, 70);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += DigitButton_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button0.Location = new Point(101, 328);
            button0.Name = "button0";
            button0.Size = new Size(70, 70);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += DigitButton_Click;
            // 
            // numberTextBox
            // 
            numberTextBox.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberTextBox.Location = new Point(12, 12);
            numberTextBox.Multiline = true;
            numberTextBox.Name = "numberTextBox";
            numberTextBox.Size = new Size(401, 53);
            numberTextBox.TabIndex = 10;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            clearButton.Location = new Point(177, 328);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(146, 70);
            clearButton.TabIndex = 11;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += ClearButton_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 475);
            Controls.Add(clearButton);
            Controls.Add(numberTextBox);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "CalculatorForm";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private TextBox numberTextBox;
        private Button clearButton;
    }
}
