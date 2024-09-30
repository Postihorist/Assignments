namespace Assignment2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(textBox1.Text) * 15;
                float b = float.Parse(textBox2.Text) * 12;
                float c = float.Parse(textBox3.Text) * 9;
                float total = a + b + c;
                textBox4.Text = "$" + a.ToString("0.00");
                textBox5.Text = "$" + b.ToString("0.00");
                textBox6.Text = "$" + c.ToString("0.00");
                textBox7.Text = "$" + total.ToString("0.00");
            }
            catch (FormatException eo)
            {
                MessageBox.Show(eo.Message);
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox6.Text = String.Empty;
            textBox7.Text = String.Empty;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
