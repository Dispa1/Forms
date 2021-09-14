using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
            double a, b, n;
            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            n = Convert.ToInt32(textBox3.Text);
            var h = (b - a) / (n * 1);
            double sum = 0.0;
            for (var i = 0; i<= n - 1; i++)
            {
                var x = a + i * h;
                sum += F(x);
            }
            var result = h * sum;
            label5.Text = Convert.ToString(result);
        }
        private static double F(double x)
        {
            return Math.Sqrt(1 + x);
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
