namespace Paint
{
    partial class PaintApplication
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintApplication));
            this.panelTop = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.colorPicker = new System.Windows.Forms.PictureBox();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.lineButton = new System.Windows.Forms.Button();
            this.ellipseButton = new System.Windows.Forms.Button();
            this.eraserButton = new System.Windows.Forms.Button();
            this.pencilButton = new System.Windows.Forms.Button();
            this.fillButton = new System.Windows.Forms.Button();
            this.ColorButton = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.panelTop.Controls.Add(this.saveButton);
            this.panelTop.Controls.Add(this.clearButton);
            this.panelTop.Controls.Add(this.colorPicker);
            this.panelTop.Controls.Add(this.rectangleButton);
            this.panelTop.Controls.Add(this.lineButton);
            this.panelTop.Controls.Add(this.ellipseButton);
            this.panelTop.Controls.Add(this.eraserButton);
            this.panelTop.Controls.Add(this.pencilButton);
            this.panelTop.Controls.Add(this.fillButton);
            this.panelTop.Controls.Add(this.ColorButton);
            this.panelTop.Controls.Add(this.pic_color);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(944, 100);
            this.panelTop.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(202)))), ((int)(((byte)(236)))));
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.saveButton.Location = new System.Drawing.Point(807, 6);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(85, 42);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(202)))), ((int)(((byte)(236)))));
            this.clearButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.clearButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.clearButton.Location = new System.Drawing.Point(807, 51);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(85, 42);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // colorPicker
            // 
            this.colorPicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorPicker.Image = ((System.Drawing.Image)(resources.GetObject("colorPicker.Image")));
            this.colorPicker.Location = new System.Drawing.Point(12, 10);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(146, 83);
            this.colorPicker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colorPicker.TabIndex = 9;
            this.colorPicker.TabStop = false;
            this.colorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colorPicker_MouseClick);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(202)))), ((int)(((byte)(236)))));
            this.rectangleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.rectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangleButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rectangleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.rectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("rectangleButton.Image")));
            this.rectangleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rectangleButton.Location = new System.Drawing.Point(636, 4);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(76, 87);
            this.rectangleButton.TabIndex = 8;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // lineButton
            // 
            this.lineButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(202)))), ((int)(((byte)(236)))));
            this.lineButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.lineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lineButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lineButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.lineButton.Image = ((System.Drawing.Image)(resources.GetObject("lineButton.Image")));
            this.lineButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lineButton.Location = new System.Drawing.Point(718, 6);
            this.lineButton.Name = "lineButton";
            this.lineButton.Size = new System.Drawing.Size(76, 87);
            this.lineButton.TabIndex = 7;
            this.lineButton.Text = "Line";
            this.lineButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lineButton.UseVisualStyleBackColor = true;
            this.lineButton.Click += new System.EventHandler(this.lineButton_Click);
            // 
            // ellipseButton
            // 
            this.ellipseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ellipseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(202)))), ((int)(((byte)(236)))));
            this.ellipseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.ellipseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ellipseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ellipseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.ellipseButton.Image = ((System.Drawing.Image)(resources.GetObject("ellipseButton.Image")));
            this.ellipseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ellipseButton.Location = new System.Drawing.Point(554, 4);
            this.ellipseButton.Name = "ellipseButton";
            this.ellipseButton.Size = new System.Drawing.Size(76, 87);
            this.ellipseButton.TabIndex = 5;
            this.ellipseButton.Text = "Ellipse";
            this.ellipseButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ellipseButton.UseVisualStyleBackColor = true;
            this.ellipseButton.Click += new System.EventHandler(this.ellipseButton_Click);
            // 
            // eraserButton
            // 
            this.eraserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraserButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(202)))), ((int)(((byte)(236)))));
            this.eraserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.eraserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraserButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.eraserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.eraserButton.Image = ((System.Drawing.Image)(resources.GetObject("eraserButton.Image")));
            this.eraserButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eraserButton.Location = new System.Drawing.Point(472, 6);
            this.eraserButton.Name = "eraserButton";
            this.eraserButton.Size = new System.Drawing.Size(76, 87);
            this.eraserButton.TabIndex = 4;
            this.eraserButton.Text = "Eraser";
            this.eraserButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eraserButton.UseVisualStyleBackColor = true;
            this.eraserButton.Click += new System.EventHandler(this.eraserButton_Click);
            // 
            // pencilButton
            // 
            this.pencilButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pencilButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(202)))), ((int)(((byte)(236)))));
            this.pencilButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.pencilButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencilButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pencilButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.pencilButton.Image = ((System.Drawing.Image)(resources.GetObject("pencilButton.Image")));
            this.pencilButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pencilButton.Location = new System.Drawing.Point(389, 8);
            this.pencilButton.Name = "pencilButton";
            this.pencilButton.Size = new System.Drawing.Size(76, 87);
            this.pencilButton.TabIndex = 3;
            this.pencilButton.Text = "Pencil";
            this.pencilButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pencilButton.UseVisualStyleBackColor = true;
            this.pencilButton.Click += new System.EventHandler(this.pencilButton_Click);
            // 
            // fillButton
            // 
            this.fillButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fillButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(202)))), ((int)(((byte)(236)))));
            this.fillButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.fillButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fillButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.fillButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.fillButton.Image = ((System.Drawing.Image)(resources.GetObject("fillButton.Image")));
            this.fillButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fillButton.Location = new System.Drawing.Point(307, 8);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(76, 87);
            this.fillButton.TabIndex = 2;
            this.fillButton.Text = "Fill";
            this.fillButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // ColorButton
            // 
            this.ColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ColorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(202)))), ((int)(((byte)(236)))));
            this.ColorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ColorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(147)))), ((int)(((byte)(213)))));
            this.ColorButton.Image = ((System.Drawing.Image)(resources.GetObject("ColorButton.Image")));
            this.ColorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ColorButton.Location = new System.Drawing.Point(225, 8);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(76, 87);
            this.ColorButton.TabIndex = 1;
            this.ColorButton.Text = "Color";
            this.ColorButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(164, 33);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(55, 40);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 457);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 54);
            this.panel1.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(944, 511);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // PaintApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PaintApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint Application";
            this.Load += new System.EventHandler(this.PaintApplication_Load);
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colorPicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button lineButton;
        private System.Windows.Forms.Button ellipseButton;
        private System.Windows.Forms.Button eraserButton;
        private System.Windows.Forms.Button pencilButton;
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.PictureBox colorPicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button clearButton;
    }
}
