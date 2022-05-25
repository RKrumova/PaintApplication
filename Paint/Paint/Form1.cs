using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace Paint
{
    public partial class PaintApplication : Form
    {
        Bitmap bm;
        Graphics graphics;
        bool paint = false;
        Point px, py;
        int index;
        int x, y, sX, sY, cX, cY;
        Pen pen = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        ColorDialog colorDialog = new ColorDialog();
        Color newColor;

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
        static Point setPoints(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }
        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color oldColor, Color newColor)
        {
            Color cx = bm.GetPixel(x, y);
            if(cx == oldColor)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, newColor);

            }
        }
        public void Fill(Bitmap bm, int x, int y, Color newColor)
        {
            Color oldColor = bm.GetPixel(x,y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x,y, newColor);
            if (oldColor == newColor) return;
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width-1 && pt.Y < bm.Height - 1){
                    validate(bm, pixel, pt.X - 1, pt.Y, oldColor, newColor);
                    validate(bm, pixel, pt.X, pt.Y - 1, oldColor, newColor);
                    validate(bm, pixel, pt.X + 1, pt.Y, oldColor, newColor);
                    validate(bm, pixel, pt.X, pt.Y + 1, oldColor, newColor);
                }
            }
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
        private void colorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = setPoints(colorPicker, e.Location);
            pic_color.BackColor = ((Bitmap)colorPicker.Image).GetPixel(point.X, point.Y);
            newColor = pic_color.BackColor;
            pen.Color = pic_color.BackColor;
        }
        private void ColorButton_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            newColor = colorDialog.Color;
            pic_color.BackColor = colorDialog.Color;
            pen.Color = colorDialog.Color;

        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = setPoints(pic, e.Location);
                Fill(bm, point.X, point.Y, newColor);
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pic.Image = bm;
            index = 0;
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
        private void saveButton_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*)";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
                    
             }
        }
        private void fillButton_Click(object sender, EventArgs e)
        {
            index = 7;
        }
        
        private void PaintApplication_Load(object sender, EventArgs e)
        {

        }
    }
}
