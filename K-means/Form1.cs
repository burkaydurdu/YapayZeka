using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yapay
{
    public partial class Form1 : Form
    {
        private int pic_width;
        private int pic_height;
        private int center_x;
        private int center_y;
        private int max_x; 
        private Point [] points;
        private Random rand;
        private Pen pen1;
        private Bitmap bitMapPen;
        public Form1()
        {
            InitializeComponent();

            pic_width = picture.Width;
            pic_height = picture.Height;
            center_x = pic_width / 2;
            center_y = pic_height / 2;
            max_x = 1000;

            bitMapPen = new Bitmap(1, 1);
            bitMapPen.SetPixel(0, 0, Color.Green);

            rand = new Random();
            pen1 = new Pen(Color.White, 2f);
        }

        private void randomPoint(object sender, EventArgs e)
        {
            picture.Invalidate();
        }
        private void randPoint(Graphics e)
        {
            if(point_bet_text.Text == "")
            {
                return;
            }
            int bet = Int32.Parse(point_bet_text.Text);
            points = new Point[bet];
            for (int i = 0; i < bet; i++)
            {
                Point p = new Point(rand.Next(550), rand.Next(420));
                e.FillRectangle (Brushes.Red, p.X, p.Y, 5 , 5);
                points[i] = p;
            }
        }
        private void cartesianCoordinate(Graphics g)
        {
            Point center = new Point(center_x, center_y);
            g.DrawLine(pen1, new Point(center_x, 0), new Point(center_x, pic_height));
            g.DrawLine(pen1, new Point(0, center_y), new Point(pic_width, center_y));
        }

        private void functionDraw(Graphics g, double a, double b, double c)
        {

            for (double x = 0; x < max_x; x += 0.01)
            {
                double y = a * (x * x) + b * x + c;
                g.DrawImageUnscaled(bitMapPen, new Point(center_x + (int)x, center_y - (int)y));
                g.DrawImageUnscaled(bitMapPen, new Point(center_x - (int)x, center_y - (int)y));
                if (y >= center_y) break;
            }
        }

        private void random_bet_track_Scroll(object sender, EventArgs e)
        {
            int value = random_bet_track.Value;
            point_bet_text.Text =  value.ToString();
        }

        private void picture_Paint(object sender, PaintEventArgs e)
        {
            //randPoint(e.Graphics);
            cartesianCoordinate(e.Graphics);
            functionDraw(e.Graphics, -2, -20, 1);
        }
        
    }
}
