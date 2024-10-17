using System;
using System.Windows.Forms;

namespace Assignment4
{
    public partial class Form1 : Form
    {
        private decimal n;
        private decimal f = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != String.Empty)
            {
                n = 0;
                f = 1;
                textBox2.Text = String.Empty;
            }
            if (decimal.TryParse(textBox1.Text, out n))
            {
                if (n >= 28)
                {
                    MessageBox.Show("The value overflows the methaphysical limits of the universe. Use calculator instead.");
                } else
                {
                    textBox2.AppendText($"{n}! = ");
                    for (decimal i = 1; i <= n; i++)
                    {
                        f *= i;
                        textBox2.AppendText(i < n ? $"{i} * " : $"{i}");
                    }
                    MessageBox.Show($"The Factorial for {n} is: {f}");
                }
            }
            else
            {
                MessageBox.Show("The value is not an integer.");
            }
            
        }
    }
}
