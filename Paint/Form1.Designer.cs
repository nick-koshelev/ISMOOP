namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxShapes = new System.Windows.Forms.ListBox();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonLine = new System.Windows.Forms.Button();
            this.buttonCircle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonColor = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.buttonRect = new System.Windows.Forms.Button();
            this.buttonEllipse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxShapes
            // 
            this.listBoxShapes.FormattingEnabled = true;
            this.listBoxShapes.ItemHeight = 16;
            this.listBoxShapes.Location = new System.Drawing.Point(12, 60);
            this.listBoxShapes.Name = "listBoxShapes";
            this.listBoxShapes.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxShapes.Size = new System.Drawing.Size(120, 276);
            this.listBoxShapes.TabIndex = 0;
            this.listBoxShapes.SelectedIndexChanged += new System.EventHandler(this.listBoxShapes_SelectedIndexChanged);
            // 
            // buttonPoint
            // 
            this.buttonPoint.Location = new System.Drawing.Point(141, 17);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(97, 32);
            this.buttonPoint.TabIndex = 1;
            this.buttonPoint.Text = "Point";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.Location = new System.Drawing.Point(235, 17);
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(97, 32);
            this.buttonLine.TabIndex = 2;
            this.buttonLine.Text = "Line";
            this.buttonLine.UseVisualStyleBackColor = true;
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonCircle
            // 
            this.buttonCircle.Location = new System.Drawing.Point(329, 17);
            this.buttonCircle.Name = "buttonCircle";
            this.buttonCircle.Size = new System.Drawing.Size(97, 32);
            this.buttonCircle.TabIndex = 3;
            this.buttonCircle.Text = "Circle";
            this.buttonCircle.UseVisualStyleBackColor = true;
            this.buttonCircle.Click += new System.EventHandler(this.buttonCircle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(138, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 307);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(12, 8);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(46, 46);
            this.buttonColor.TabIndex = 6;
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonRect
            // 
            this.buttonRect.Location = new System.Drawing.Point(423, 17);
            this.buttonRect.Name = "buttonRect";
            this.buttonRect.Size = new System.Drawing.Size(97, 32);
            this.buttonRect.TabIndex = 7;
            this.buttonRect.Text = "Rectangle";
            this.buttonRect.UseVisualStyleBackColor = true;
            this.buttonRect.Click += new System.EventHandler(this.buttonRect_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Location = new System.Drawing.Point(512, 17);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(97, 32);
            this.buttonEllipse.TabIndex = 8;
            this.buttonEllipse.Text = "Ellipse";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonEllipse);
            this.Controls.Add(this.buttonRect);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonCircle);
            this.Controls.Add(this.buttonLine);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.listBoxShapes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxShapes;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonLine;
        private System.Windows.Forms.Button buttonCircle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Button buttonRect;
        private System.Windows.Forms.Button buttonEllipse;
    }
}

