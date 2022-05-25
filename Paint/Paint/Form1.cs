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
                } else if (index == 2) { 
                    px = e.Location;
                    graphics.DrawLine(pen, px, py);
                    py = px;
                }
            }
            pic.Refresh();
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

        }

        private void pencilButton_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void eraserButton_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void PaintApplication_Load(object sender, EventArgs e)
        {

        }
    }
}
