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
                for (decimal i = 1; i <= n; i++)
                {
                    f *= i;
                    textBox2.AppendText($"Iteration: {f}\r\n");
                }
                textBox2.AppendText($"Result: {f}\r\n");
            }
            else
            {
                MessageBox.Show("The value is not an integer.");
            }
            
        }
    }
}
