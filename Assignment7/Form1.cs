using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class Form1 : Form
    {

        string[] correct = { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D", "B", "C", "D", "A", "D", "C", "C", "B", "D", "A" };
        List<string> answers = new List<string>();
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)
            {
                MessageBox.Show("Specify the answers file.");
            }
            foreach (string line in File.ReadLines(textBox1.Text))
            {
                if (line.Contains("Answer:"))
                {
                    answers.Add(line.Split(' ')[1]);
                }
            }
            for (int i = 0; i < 20; i++)
            {
                if (correct[i] == answers[i])
                {
                    score += 1;
                }
            }
            label1.Text = $"Correct answers from 20: {score}";
            label2.Text = $"Correct answers percentage: {(float)score / 20 * 100}%";
            label3.Text = score > 15 ? "Passed: Yes" : "Passed: No";
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            if (file.ShowDialog() == DialogResult.OK)
            {
                string path = file.FileName;
                textBox1.Text = path;
            }
        }
    }
}
