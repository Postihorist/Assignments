namespace Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            float w = float.Parse(textBox1.Text);
            float h = float.Parse(textBox2.Text);
            float bmi = (w / (h * h)) * 703;
            string status;
            if (bmi > 25)
            {
                status = "overweight";
            } else if (bmi < 18.5)
            {
                status = "underweight";
            } else
            {
                status = "optimal";
            }
            textBox3.Text = $"BMI: {bmi.ToString("0.00")}\r\nStatus: {status}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;   
            textBox3.Text = String.Empty;
        }
    }
}
