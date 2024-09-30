namespace Assignment2
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            groupBox2 = new GroupBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(12, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 129);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tickets Sold";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 87);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Class C";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 58);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 2;
            label2.Text = "Class B";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(57, 84);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(57, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Class A";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(57, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(202, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(168, 182);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Revenue Generated";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(57, 113);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 2;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(57, 84);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 8;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(57, 55);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 7;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(57, 26);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 87);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 5;
            label4.Text = "Class C";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 58);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 2;
            label5.Text = "Class B";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 29);
            label6.Name = "label6";
            label6.Size = new Size(45, 15);
            label6.TabIndex = 1;
            label6.Text = "Class A";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.Location = new Point(12, 142);
            button1.Name = "button1";
            button1.Size = new Size(168, 23);
            button1.TabIndex = 9;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.Location = new Point(12, 171);
            button2.Name = "button2";
            button2.Size = new Size(168, 23);
            button2.TabIndex = 10;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 211);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MaximumSize = new Size(398, 250);
            MinimumSize = new Size(398, 250);
            Name = "Form1";
            Text = "Assignment 2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
    }
}
