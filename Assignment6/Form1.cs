using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        private int num = new Random().Next(3);
        private int score1 = 0;
        private int score2 = 0;
        private List<System.Drawing.Bitmap> list = new List<System.Drawing.Bitmap>() 
        { Assignment6.Properties.Resources.r, Assignment6.Properties.Resources.p, Assignment6.Properties.Resources.s };
        public Form1()
        {
            InitializeComponent();
        }
        private bool win(int p1, int p2)
        {
            if ((p1 == 0 && p2 == 2) || (p1 == 1 && p2 == 0) || (p1 == 2 && p2 == 1))
            {
                return true;
            }
            return false;
        }
        private void newFigure()
        {
            num = new Random().Next(3);
            pictureBox1.BackgroundImage = list[num];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            newFigure();
            if (win(0, num))
            {
                score1 += 1; 
            }
            if (win(num, 0))
            {
                score2 += 1;
            }
            textBox1.Text = $"{score1}:{score2}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newFigure();
            if (win(1, num))
            {
                score1 += 1;
            }
            if (win(num, 1))
            {
                score2 += 1;
            }
            textBox1.Text = $"{score1}:{score2}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            newFigure();
            if (win(2, num))
            {
                score1 += 1;
            }
            if (win(num, 2))
            {
                score2 += 1;
            }
            textBox1.Text = $"{score1}:{score2}";
        }
    }
}
