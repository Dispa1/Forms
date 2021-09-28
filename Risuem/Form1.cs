using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testCharts
{
    public partial class Form1 : Form
    {
        Image image;
        public Form1()
        {
            InitializeComponent();
            //создаём точки
            var points = new Point[100];
            var random = new Random();
            //каждая точка будет создаваться на новом столбце пикселей
            for (var i = 0; i < points.Length; i++)
                points[i] = new Point(random.Next(0, 1100), random.Next(0, 875));
            points = points.OrderBy(point => point.X).ToArray();
            //задаём размер изображению
            image = new Bitmap(1100, 875);
            //точки будут соеденяться фиолетовой гранью
            var pen = new Pen(Color.Tomato, 3f);
            //наш график который будет рисоваться на нашей панели
            var graphics = Graphics.FromImage(image);
            for (var i = 0; i < points.Length - 1; i++)
                //с помощью DrawLine будут соеденяться наши точки
                graphics.DrawLine(pen, points[i], points[i + 1]);
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = panel1.CreateGraphics();
            Pen pen = new Pen(Color.Black, 2);

          
            int width = panel1.Width;
            int height = panel1.Height;

            
            graphics.DrawLine(pen, width / 2, 0, width / 2, height);
            graphics.DrawLine(pen, 0, height / 2, width, height / 2);

            graphics.DrawLine(pen, width / 2, 0, width / 2 + 5, 10);
            graphics.DrawLine(pen, width / 2, 0, width / 2 - 5, 10);
            graphics.DrawLine(pen, width, height / 2, width - 10, height / 2 + 5);
            graphics.DrawLine(pen, width, height / 2, width - 10, height / 2 - 5);

            graphics.DrawString("Y", new Font("10_IC_1", 12), Brushes.Red, width / 2 + 10, -5);
            graphics.DrawString("X", new Font("10_IC_1", 12), Brushes.Red, width - 15, height / 2 + 10); 


            int lx = -width / 40 + 1;
            for (int i = 20; i < width - 20; i += 20)
            {
                if (lx != 0)
                {
                    graphics.DrawLine(new Pen(Color.Black, 1), 0 + i + 10, 0, 0 + i + 10, height); 
                    graphics.DrawString(lx.ToString(), new Font("10_IC_1", 8, FontStyle.Bold), Brushes.Black, 0 + i + 5, height / 2 + 5); 
                }
                graphics.DrawLine(new Pen(Color.Black, 2), 0 + i + 10, height / 2 - 5, 0 + i + 10, height / 2 + 5); 

                ++lx;
            }

            int ly = height / 40 - 1;
            for (int i = 20; i < height; i += 20)
            {
                if (ly != 0)
                {
                    graphics.DrawLine(new Pen(Color.Black, 1), 0, 0 + i, width, 0 + i); 
                    graphics.DrawString(ly.ToString(), new Font("10_IC_1", 8, FontStyle.Bold), Brushes.Black, width / 2 + 5, 0 + i - 5); 
                }
                graphics.DrawLine(new Pen(Color.Black, 2), width / 2 - 5, 0 + i, width / 2 + 5, 0 + i); 

                --ly;
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            graphics.DrawImage(image, new Point());
        }
    }
}
