namespace raster_algorithms
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chooseColorBtn = new System.Windows.Forms.Button();
            this.chooseImageBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.floodRedrawBtn = new System.Windows.Forms.Button();
            this.floodFIllBtn = new System.Windows.Forms.Button();
            this.penBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(830, 504);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // chooseColorBtn
            // 
            this.chooseColorBtn.Location = new System.Drawing.Point(889, 204);
            this.chooseColorBtn.Name = "chooseColorBtn";
            this.chooseColorBtn.Size = new System.Drawing.Size(145, 54);
            this.chooseColorBtn.TabIndex = 1;
            this.chooseColorBtn.Text = "Выбрать цвет заливки";
            this.chooseColorBtn.UseVisualStyleBackColor = true;
            this.chooseColorBtn.Click += new System.EventHandler(this.chooseColorBtn_Click);
            // 
            // chooseImageBtn
            // 
            this.chooseImageBtn.Location = new System.Drawing.Point(889, 289);
            this.chooseImageBtn.Name = "chooseImageBtn";
            this.chooseImageBtn.Size = new System.Drawing.Size(145, 54);
            this.chooseImageBtn.TabIndex = 2;
            this.chooseImageBtn.Text = "Выбрать изображение";
            this.chooseImageBtn.UseVisualStyleBackColor = true;
            this.chooseImageBtn.Click += new System.EventHandler(this.chooseImageBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(889, 454);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(145, 54);
            this.exitBtn.TabIndex = 3;
            this.exitBtn.Text = "Выход";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // floodRedrawBtn
            // 
            this.floodRedrawBtn.Location = new System.Drawing.Point(889, 376);
            this.floodRedrawBtn.Name = "floodRedrawBtn";
            this.floodRedrawBtn.Size = new System.Drawing.Size(145, 54);
            this.floodRedrawBtn.TabIndex = 4;
            this.floodRedrawBtn.Text = "Прорисовать границу";
            this.floodRedrawBtn.UseVisualStyleBackColor = true;
            this.floodRedrawBtn.Click += new System.EventHandler(this.floodRedrawBtn_Click);
            // 
            // floodFIllBtn
            // 
            this.floodFIllBtn.Location = new System.Drawing.Point(889, 109);
            this.floodFIllBtn.Name = "floodFIllBtn";
            this.floodFIllBtn.Size = new System.Drawing.Size(145, 32);
            this.floodFIllBtn.TabIndex = 6;
            this.floodFIllBtn.Text = "Заливка";
            this.floodFIllBtn.UseVisualStyleBackColor = true;
            this.floodFIllBtn.Click += new System.EventHandler(this.floodFIllBtn_Click);
            // 
            // penBtn
            // 
            this.penBtn.Location = new System.Drawing.Point(889, 52);
            this.penBtn.Name = "penBtn";
            this.penBtn.Size = new System.Drawing.Size(145, 32);
            this.penBtn.TabIndex = 7;
            this.penBtn.Text = "Карандаш";
            this.penBtn.UseVisualStyleBackColor = true;
            this.penBtn.Click += new System.EventHandler(this.penBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 564);
            this.Controls.Add(this.penBtn);
            this.Controls.Add(this.floodFIllBtn);
            this.Controls.Add(this.floodRedrawBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.chooseImageBtn);
            this.Controls.Add(this.chooseColorBtn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button chooseColorBtn;
        private System.Windows.Forms.Button chooseImageBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button floodRedrawBtn;
        private System.Windows.Forms.Button floodFIllBtn;
        private System.Windows.Forms.Button penBtn;
    }
}

