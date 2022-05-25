using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class PaintApplication : Form
    {
        Bitmap bm;
        Graphics graphics;
        bool paint = false;
        Point px, py;
        Pen pen = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;
        int x, y, sX, sY, cX, cY;
        public PaintApplication()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            graphics = Graphics.FromImage(bm);
            graphics.Clear (Color.White);
            pic.Image = bm;

        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;

        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if(index == 1)
                {
                    px = e.Location;
                    graphics.DrawLine(pen, px, py);
                    py = px;
                }
                if (index == 2) { 
                    px = e.Location;
                    graphics.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pic.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX;
            sY = y - cY;
            if (index == 3)
            {
                graphics.DrawEllipse(pen, cX, cY, sX, sY);
            }
            if(index == 4)
            {
                graphics.DrawRectangle(pen, cX, cY, sX, sY);
            }
            if(index == 5)
            {
                graphics.DrawLine(pen, cX, cY, x, y);
            }
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    graphics.DrawEllipse(pen, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    graphics.DrawRectangle(pen, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    graphics.DrawLine(pen, cX, cY, x, y);
                }
            }
        }

        private void pencilButton_Click(object sender, EventArgs e)
        {
            index = 1;
        }
        private void eraserButton_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        private void ellipseButton_Click(object sender, EventArgs e)
        {
            index = 3;
        }
        private void rectangleButton_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void lineButton_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        private void PaintApplication_Load(object sender, EventArgs e)
        {

        }
    }
}
