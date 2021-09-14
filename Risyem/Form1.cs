using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Risyem
{
    public partial class Form1 : Form
    {
        Image image;
        public Form1()
        {
            InitializeComponent();
            var points = new Point[400];
            var random = new Random();
            for (var i = 0; i < points.Length; i++)
                points[i] = new Point(random.Next(0, 400), random.Next(0, 400));
            points = points.OrderBy(point => point.X).ToArray();
            image = new Bitmap(800, 450);
            var pen = new Pen(Color.Purple, 1f);
            var graphics = Graphics.FromImage(image);
            for (var i = 0; i < points.Length - 1; i++)
                graphics.DrawLine(pen, points[i], points[i + 1]);
            panel1.Paint += new PaintEventHandler(panel1_Paint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;
            graphics.DrawImage(image, new Point());
        }
    }
}
