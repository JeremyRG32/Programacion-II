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
            label1 = new Label();
            checkedListBox1 = new CheckedListBox();
            checkedListBox2 = new CheckedListBox();
            label2 = new Label();
            checkedListBox3 = new CheckedListBox();
            label3 = new Label();
            checkedListBox4 = new CheckedListBox();
            label4 = new Label();
            checkedListBox5 = new CheckedListBox();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            checkedListBox6 = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(22, 9);
            label1.Name = "label1";
            label1.Size = new Size(159, 38);
            label1.TabIndex = 0;
            label1.Text = "Family Font";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Times", "Helvetica", "Courier", "Sans serif" });
            checkedListBox1.Location = new Point(12, 50);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(180, 116);
            checkedListBox1.TabIndex = 3;
            // 
            // checkedListBox2
            // 
            checkedListBox2.FormattingEnabled = true;
            checkedListBox2.Items.AddRange(new object[] { "Small", "Medium", "Large" });
            checkedListBox2.Location = new Point(320, 50);
            checkedListBox2.Name = "checkedListBox2";
            checkedListBox2.Size = new Size(180, 116);
            checkedListBox2.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(366, 9);
            label2.Name = "label2";
            label2.Size = new Size(67, 38);
            label2.TabIndex = 4;
            label2.Text = "Size";
            // 
            // checkedListBox3
            // 
            checkedListBox3.FormattingEnabled = true;
            checkedListBox3.Items.AddRange(new object[] { "Underline", "Bold", "Italic" });
            checkedListBox3.Location = new Point(607, 50);
            checkedListBox3.Name = "checkedListBox3";
            checkedListBox3.Size = new Size(180, 116);
            checkedListBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(653, 9);
            label3.Name = "label3";
            label3.Size = new Size(76, 38);
            label3.TabIndex = 6;
            label3.Text = "Style";
            // 
            // checkedListBox4
            // 
            checkedListBox4.FormattingEnabled = true;
            checkedListBox4.Items.AddRange(new object[] { "10 CPI", "12 CPI", "15 CPI", "Proportional" });
            checkedListBox4.Location = new Point(12, 224);
            checkedListBox4.Name = "checkedListBox4";
            checkedListBox4.Size = new Size(180, 116);
            checkedListBox4.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(49, 183);
            label4.Name = "label4";
            label4.Size = new Size(78, 38);
            label4.TabIndex = 8;
            label4.Text = "Pitch";
            // 
            // checkedListBox5
            // 
            checkedListBox5.FormattingEnabled = true;
            checkedListBox5.Items.AddRange(new object[] { "Black", "Blue", "Red", "Green" });
            checkedListBox5.Location = new Point(316, 224);
            checkedListBox5.Name = "checkedListBox5";
            checkedListBox5.Size = new Size(180, 116);
            checkedListBox5.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(366, 183);
            label5.Name = "label5";
            label5.Size = new Size(83, 38);
            label5.TabIndex = 10;
            label5.Text = "Color";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(644, 183);
            label6.Name = "label6";
            label6.Size = new Size(100, 38);
            label6.TabIndex = 12;
            label6.Text = "Border";
            // 
            // button1
            // 
            button1.Location = new Point(80, 395);
            button1.Name = "button1";
            button1.Size = new Size(112, 43);
            button1.TabIndex = 14;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(252, 395);
            button2.Name = "button2";
            button2.Size = new Size(112, 43);
            button2.TabIndex = 15;
            button2.Text = "Apply";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(441, 395);
            button3.Name = "button3";
            button3.Size = new Size(112, 43);
            button3.TabIndex = 16;
            button3.Text = "Cancel";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(617, 395);
            button4.Name = "button4";
            button4.Size = new Size(112, 43);
            button4.TabIndex = 17;
            button4.Text = "Help";
            button4.UseVisualStyleBackColor = true;
            // 
            // checkedListBox6
            // 
            checkedListBox6.FormattingEnabled = true;
            checkedListBox6.Location = new Point(608, 224);
            checkedListBox6.Name = "checkedListBox6";
            checkedListBox6.Size = new Size(180, 116);
            checkedListBox6.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkedListBox6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(checkedListBox5);
            Controls.Add(label5);
            Controls.Add(checkedListBox4);
            Controls.Add(label4);
            Controls.Add(checkedListBox3);
            Controls.Add(label3);
            Controls.Add(checkedListBox2);
            Controls.Add(label2);
            Controls.Add(checkedListBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Text Properties";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckedListBox checkedListBox1;
        private CheckedListBox checkedListBox2;
        private Label label2;
        private CheckedListBox checkedListBox3;
        private Label label3;
        private CheckedListBox checkedListBox4;
        private Label label4;
        private CheckedListBox checkedListBox5;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private CheckedListBox checkedListBox6;
    }
}
