using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public class workmen
        {
            public string vivod;
            public void vod(string a, string b, string c, int d)
            {
                if(d > 0 && d <= 10)
                {
                    vivod = "ИМЯ - " + a + Environment.NewLine + "АДРЕС - " + b + Environment.NewLine + "ДОЛЖНОСТЬ - " + c + Environment.NewLine + "ВОЗРАСТ - " + d + Environment.NewLine + "Начинающий так как возраст - " + d.ToString();
                }
                if(d > 10 && d <= 30)
                {
                    vivod = "ИМЯ - " + a + Environment.NewLine + "АДРЕС - " + b + Environment.NewLine + "ДОЛЖНОСТЬ - " + c + Environment.NewLine + "ВОЗРАСТ - " + d + Environment.NewLine + "Адепт так как возраст - " + d.ToString();
                }
                if (d > 30 && d <= 50)
                {
                    vivod = "ИМЯ - " + a + Environment.NewLine + "АДРЕС - " + b + Environment.NewLine + "ДОЛЖНОСТЬ - " + c + Environment.NewLine + "ВОЗРАСТ - " + d + Environment.NewLine +  "Продвинутый так как возраст - " + d.ToString();
                }
                if (d > 50 && d <= 90)
                {
                    vivod = "ИМЯ - " + a + Environment.NewLine + "АДРЕС - " + b + Environment.NewLine + "ДОЛЖНОСТЬ - " + c + Environment.NewLine + "ВОЗРАСТ - " + d + Environment.NewLine + "Он в своем познании настолько преисполнился, что он как будто бы уже сто триллионов миллиардов лет проживает на триллионах и триллионах таких же планет - Возраст " + d.ToString();
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string A, B, C;
            int D;
            workmen viivod = new workmen();
            A = textBox1.Text;
            B = textBox2.Text;
            C = textBox3.Text;
            D = Convert.ToInt32(textBox4.Text);
            viivod.vod(A,B,C,D);
            textBox5.Text += viivod.vivod.ToString();
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
