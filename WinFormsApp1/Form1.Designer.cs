namespace WinFormsApp1
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
            numberDisplay = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            randomNumberCount = new NumericUpDown();
            userInput = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)randomNumberCount).BeginInit();
            SuspendLayout();
            // 
            // numberDisplay
            // 
            numberDisplay.AutoSize = true;
            numberDisplay.Location = new Point(95, 256);
            numberDisplay.Name = "numberDisplay";
            numberDisplay.Size = new Size(253, 20);
            numberDisplay.TabIndex = 1;
            numberDisplay.Text = "Inputted numbers will be shown here";
            // 
            // button1
            // 
            button1.Location = new Point(89, 126);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Accept";
            button1.UseVisualStyleBackColor = true;
            button1.Click += UserInputButton;
            // 
            // button2
            // 
            button2.Location = new Point(623, 126);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "Randomize";
            button2.UseVisualStyleBackColor = true;
            button2.Click += RandomInputButton;
            // 
            // button3
            // 
            button3.Location = new Point(77, 360);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "BubbleSort";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(261, 363);
            button4.Name = "button4";
            button4.Size = new Size(111, 29);
            button4.TabIndex = 5;
            button4.Text = "InsertionSort";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(455, 360);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 6;
            button5.Text = "MergeSort";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(654, 361);
            button6.Name = "button6";
            button6.Size = new Size(107, 29);
            button6.TabIndex = 7;
            button6.Text = "CountingSort";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(859, 363);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 8;
            button7.Text = "QuickSort";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // randomNumberCount
            // 
            randomNumberCount.Location = new Point(623, 62);
            randomNumberCount.Name = "randomNumberCount";
            randomNumberCount.Size = new Size(150, 27);
            randomNumberCount.TabIndex = 10;
            // 
            // userInput
            // 
            userInput.Location = new Point(89, 62);
            userInput.Name = "userInput";
            userInput.Size = new Size(252, 27);
            userInput.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 513);
            label1.Name = "label1";
            label1.Size = new Size(247, 20);
            label1.TabIndex = 12;
            label1.Text = "Time elapsed will be displayed here";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 597);
            Controls.Add(label1);
            Controls.Add(userInput);
            Controls.Add(randomNumberCount);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numberDisplay);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)randomNumberCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label numberDisplay;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private NumericUpDown randomNumberCount;
        private TextBox userInput;
        private Label label1;
    }
}
