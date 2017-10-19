namespace affine_transform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.intersectionTb = new System.Windows.Forms.TextBox();
            this.intersectionBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.belongsToConvexLbl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rotateAroundPointCb = new System.Windows.Forms.CheckBox();
            this.chosenPointTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ninetyDegBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.applyBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.polyChk = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lineChk = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pointPositionTb = new System.Windows.Forms.TextBox();
            this.pointPositionBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pointPositionBtn);
            this.groupBox1.Controls.Add(this.pointPositionTb);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.intersectionTb);
            this.groupBox1.Controls.Add(this.intersectionBtn);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.belongsToConvexLbl);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rotateAroundPointCb);
            this.groupBox1.Controls.Add(this.chosenPointTb);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ninetyDegBtn);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.applyBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.polyChk);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lineChk);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1408, 139);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // intersectionTb
            // 
            this.intersectionTb.Location = new System.Drawing.Point(931, 103);
            this.intersectionTb.Margin = new System.Windows.Forms.Padding(4);
            this.intersectionTb.Name = "intersectionTb";
            this.intersectionTb.Size = new System.Drawing.Size(132, 22);
            this.intersectionTb.TabIndex = 28;
            this.intersectionTb.Text = "Неизвестно";
            // 
            // intersectionBtn
            // 
            this.intersectionBtn.Location = new System.Drawing.Point(1092, 100);
            this.intersectionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.intersectionBtn.Name = "intersectionBtn";
            this.intersectionBtn.Size = new System.Drawing.Size(227, 29);
            this.intersectionBtn.TabIndex = 27;
            this.intersectionBtn.Text = "Найти пересечение";
            this.intersectionBtn.UseVisualStyleBackColor = true;
            this.intersectionBtn.Click += new System.EventHandler(this.intersectionBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(928, 77);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 17);
            this.label12.TabIndex = 26;
            this.label12.Text = "Точка пересечения";
            // 
            // belongsToConvexLbl
            // 
            this.belongsToConvexLbl.Location = new System.Drawing.Point(931, 41);
            this.belongsToConvexLbl.Margin = new System.Windows.Forms.Padding(4);
            this.belongsToConvexLbl.Name = "belongsToConvexLbl";
            this.belongsToConvexLbl.Size = new System.Drawing.Size(132, 22);
            this.belongsToConvexLbl.TabIndex = 25;
            this.belongsToConvexLbl.Text = "Неизвестно";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(928, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Принадлежность полигону";
            // 
            // rotateAroundPointCb
            // 
            this.rotateAroundPointCb.AutoSize = true;
            this.rotateAroundPointCb.Location = new System.Drawing.Point(550, 95);
            this.rotateAroundPointCb.Name = "rotateAroundPointCb";
            this.rotateAroundPointCb.Size = new System.Drawing.Size(168, 21);
            this.rotateAroundPointCb.TabIndex = 23;
            this.rotateAroundPointCb.Text = "Вокруг данной точки";
            this.rotateAroundPointCb.UseVisualStyleBackColor = true;
            // 
            // chosenPointTb
            // 
            this.chosenPointTb.Location = new System.Drawing.Point(743, 41);
            this.chosenPointTb.Margin = new System.Windows.Forms.Padding(4);
            this.chosenPointTb.Name = "chosenPointTb";
            this.chosenPointTb.Size = new System.Drawing.Size(132, 22);
            this.chosenPointTb.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(740, 19);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Выбранная точка";
            // 
            // ninetyDegBtn
            // 
            this.ninetyDegBtn.BackgroundImage = global::affine_transform.Properties.Resources._90;
            this.ninetyDegBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ninetyDegBtn.Location = new System.Drawing.Point(1347, 19);
            this.ninetyDegBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ninetyDegBtn.Name = "ninetyDegBtn";
            this.ninetyDegBtn.Size = new System.Drawing.Size(53, 49);
            this.ninetyDegBtn.TabIndex = 20;
            this.ninetyDegBtn.UseVisualStyleBackColor = true;
            this.ninetyDegBtn.Click += new System.EventHandler(this.ninetyDegBtn_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label9.Location = new System.Drawing.Point(1338, 14);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1, 117);
            this.label9.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(551, 41);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 22);
            this.textBox5.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(339, 98);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Y";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Поворот";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(365, 95);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(365, 41);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Масштаб";
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(752, 88);
            this.applyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(113, 37);
            this.applyBtn.TabIndex = 11;
            this.applyBtn.Text = "Применить";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(139, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 117);
            this.label4.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(180, 95);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 8;
            // 
            // polyChk
            // 
            this.polyChk.Appearance = System.Windows.Forms.Appearance.Button;
            this.polyChk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("polyChk.BackgroundImage")));
            this.polyChk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.polyChk.Location = new System.Drawing.Point(69, 23);
            this.polyChk.Margin = new System.Windows.Forms.Padding(4);
            this.polyChk.Name = "polyChk";
            this.polyChk.Size = new System.Drawing.Size(53, 49);
            this.polyChk.TabIndex = 5;
            this.polyChk.UseVisualStyleBackColor = true;
            this.polyChk.CheckedChanged += new System.EventHandler(this.polyChk_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(153, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "X";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(180, 41);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Смещение";
            // 
            // lineChk
            // 
            this.lineChk.Appearance = System.Windows.Forms.Appearance.Button;
            this.lineChk.BackgroundImage = global::affine_transform.Properties.Resources.icons8_Line2_96;
            this.lineChk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.lineChk.Location = new System.Drawing.Point(8, 23);
            this.lineChk.Margin = new System.Windows.Forms.Padding(4);
            this.lineChk.Name = "lineChk";
            this.lineChk.Size = new System.Drawing.Size(53, 49);
            this.lineChk.TabIndex = 4;
            this.lineChk.UseVisualStyleBackColor = true;
            this.lineChk.CheckedChanged += new System.EventHandler(this.lineChk_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 87);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 161);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1408, 566);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1133, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Положение точки";
            // 
            // pointPositionTb
            // 
            this.pointPositionTb.Location = new System.Drawing.Point(1136, 41);
            this.pointPositionTb.Margin = new System.Windows.Forms.Padding(4);
            this.pointPositionTb.Name = "pointPositionTb";
            this.pointPositionTb.Size = new System.Drawing.Size(132, 22);
            this.pointPositionTb.TabIndex = 30;
            this.pointPositionTb.Text = "Неизвестно";
            // 
            // pointPositionBtn
            // 
            this.pointPositionBtn.Location = new System.Drawing.Point(1092, 71);
            this.pointPositionBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pointPositionBtn.Name = "pointPositionBtn";
            this.pointPositionBtn.Size = new System.Drawing.Size(227, 29);
            this.pointPositionBtn.TabIndex = 31;
            this.pointPositionBtn.Text = "Найти положение точки";
            this.pointPositionBtn.UseVisualStyleBackColor = true;
            this.pointPositionBtn.Click += new System.EventHandler(this.pointPositionBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1437, 742);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
		private System.Windows.Forms.CheckBox lineChk;
		private System.Windows.Forms.CheckBox polyChk;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ninetyDegBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox chosenPointTb;
        private System.Windows.Forms.CheckBox rotateAroundPointCb;
        private System.Windows.Forms.TextBox belongsToConvexLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox intersectionTb;
        private System.Windows.Forms.Button intersectionBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox pointPositionTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button pointPositionBtn;
    }
}

