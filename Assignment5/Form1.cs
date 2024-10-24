using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment5
{
    public partial class Form1 : Form
    {
        int n;
        int number = new Random().Next(100);
        int unique = 0;
        int all = 0;
        List<int> tried = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            number = new Random().Next(100);
            MessageBox.Show($"A new random number picked.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out n))
            {
                all += 1;
                label4.Text = $"All tries: {all}";
       
                if (!tried.Contains(n))
                {
                    tried.Add(n);
                    unique += 1;
                    label3.Text = $"{unique}/100";
                }
                if (n == number)
                {
                    MessageBox.Show($"The correct number {n} guessed. It took {all} attempts.");
                }
                else if (n > number)
                {
                    MessageBox.Show($"The number {n} is too high.");
                }
                else
                {
                    MessageBox.Show($"The number {n} is too low.");
                }
            }
            else
            {
                MessageBox.Show("The value is not an integer.");
            }
        }
    }
}
