namespace affine_transforms_in_space
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
            this.transGroupBox = new System.Windows.Forms.GroupBox();
            this.applyTransBtn = new System.Windows.Forms.Button();
            this.transZNUD = new System.Windows.Forms.NumericUpDown();
            this.transYNUD = new System.Windows.Forms.NumericUpDown();
            this.transXNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rotationGroupBox = new System.Windows.Forms.GroupBox();
            this.applyRotBtn = new System.Windows.Forms.Button();
            this.rotZNUD = new System.Windows.Forms.NumericUpDown();
            this.rotYNUD = new System.Windows.Forms.NumericUpDown();
            this.rotXNUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.scaleGroupBox = new System.Windows.Forms.GroupBox();
            this.applyScaleBtn = new System.Windows.Forms.Button();
            this.scaleZNUD = new System.Windows.Forms.NumericUpDown();
            this.scaleYNUD = new System.Windows.Forms.NumericUpDown();
            this.scaleXNUD = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.reflectGroupBox = new System.Windows.Forms.GroupBox();
            this.reflectByZBtn = new System.Windows.Forms.Button();
            this.reflectByYBtn = new System.Windows.Forms.Button();
            this.reflectByXBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.phComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.transGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transZNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transYNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transXNUD)).BeginInit();
            this.rotationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotZNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotYNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotXNUD)).BeginInit();
            this.scaleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleZNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleYNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleXNUD)).BeginInit();
            this.reflectGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(272, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 437);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // transGroupBox
            // 
            this.transGroupBox.Controls.Add(this.applyTransBtn);
            this.transGroupBox.Controls.Add(this.transZNUD);
            this.transGroupBox.Controls.Add(this.transYNUD);
            this.transGroupBox.Controls.Add(this.transXNUD);
            this.transGroupBox.Controls.Add(this.label3);
            this.transGroupBox.Controls.Add(this.label2);
            this.transGroupBox.Controls.Add(this.label1);
            this.transGroupBox.Location = new System.Drawing.Point(12, 12);
            this.transGroupBox.Name = "transGroupBox";
            this.transGroupBox.Size = new System.Drawing.Size(125, 130);
            this.transGroupBox.TabIndex = 1;
            this.transGroupBox.TabStop = false;
            this.transGroupBox.Text = "Translation";
            // 
            // applyTransBtn
            // 
            this.applyTransBtn.Location = new System.Drawing.Point(29, 96);
            this.applyTransBtn.Name = "applyTransBtn";
            this.applyTransBtn.Size = new System.Drawing.Size(84, 23);
            this.applyTransBtn.TabIndex = 2;
            this.applyTransBtn.Text = "Apply";
            this.applyTransBtn.UseVisualStyleBackColor = true;
            this.applyTransBtn.Click += new System.EventHandler(this.applyTransBtn_Click);
            // 
            // transZNUD
            // 
            this.transZNUD.Location = new System.Drawing.Point(29, 70);
            this.transZNUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.transZNUD.Name = "transZNUD";
            this.transZNUD.Size = new System.Drawing.Size(84, 20);
            this.transZNUD.TabIndex = 5;
            // 
            // transYNUD
            // 
            this.transYNUD.Location = new System.Drawing.Point(29, 46);
            this.transYNUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.transYNUD.Name = "transYNUD";
            this.transYNUD.Size = new System.Drawing.Size(84, 20);
            this.transYNUD.TabIndex = 4;
            // 
            // transXNUD
            // 
            this.transXNUD.Location = new System.Drawing.Point(29, 22);
            this.transXNUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.transXNUD.Name = "transXNUD";
            this.transXNUD.Size = new System.Drawing.Size(84, 20);
            this.transXNUD.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // rotationGroupBox
            // 
            this.rotationGroupBox.Controls.Add(this.applyRotBtn);
            this.rotationGroupBox.Controls.Add(this.rotZNUD);
            this.rotationGroupBox.Controls.Add(this.rotYNUD);
            this.rotationGroupBox.Controls.Add(this.rotXNUD);
            this.rotationGroupBox.Controls.Add(this.label4);
            this.rotationGroupBox.Controls.Add(this.label5);
            this.rotationGroupBox.Controls.Add(this.label6);
            this.rotationGroupBox.Location = new System.Drawing.Point(141, 12);
            this.rotationGroupBox.Name = "rotationGroupBox";
            this.rotationGroupBox.Size = new System.Drawing.Size(125, 130);
            this.rotationGroupBox.TabIndex = 2;
            this.rotationGroupBox.TabStop = false;
            this.rotationGroupBox.Text = "Rotation";
            // 
            // applyRotBtn
            // 
            this.applyRotBtn.Location = new System.Drawing.Point(29, 96);
            this.applyRotBtn.Name = "applyRotBtn";
            this.applyRotBtn.Size = new System.Drawing.Size(84, 23);
            this.applyRotBtn.TabIndex = 2;
            this.applyRotBtn.Text = "Apply";
            this.applyRotBtn.UseVisualStyleBackColor = true;
            this.applyRotBtn.Click += new System.EventHandler(this.applyRotBtn_Click);
            // 
            // rotZNUD
            // 
            this.rotZNUD.Location = new System.Drawing.Point(29, 70);
            this.rotZNUD.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotZNUD.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.rotZNUD.Name = "rotZNUD";
            this.rotZNUD.Size = new System.Drawing.Size(84, 20);
            this.rotZNUD.TabIndex = 5;
            // 
            // rotYNUD
            // 
            this.rotYNUD.Location = new System.Drawing.Point(29, 46);
            this.rotYNUD.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotYNUD.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.rotYNUD.Name = "rotYNUD";
            this.rotYNUD.Size = new System.Drawing.Size(84, 20);
            this.rotYNUD.TabIndex = 4;
            // 
            // rotXNUD
            // 
            this.rotXNUD.Location = new System.Drawing.Point(29, 22);
            this.rotXNUD.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.rotXNUD.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.rotXNUD.Name = "rotXNUD";
            this.rotXNUD.Size = new System.Drawing.Size(84, 20);
            this.rotXNUD.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Z:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "X:";
            // 
            // scaleGroupBox
            // 
            this.scaleGroupBox.Controls.Add(this.applyScaleBtn);
            this.scaleGroupBox.Controls.Add(this.scaleZNUD);
            this.scaleGroupBox.Controls.Add(this.scaleYNUD);
            this.scaleGroupBox.Controls.Add(this.scaleXNUD);
            this.scaleGroupBox.Controls.Add(this.label7);
            this.scaleGroupBox.Controls.Add(this.label8);
            this.scaleGroupBox.Controls.Add(this.label9);
            this.scaleGroupBox.Location = new System.Drawing.Point(12, 148);
            this.scaleGroupBox.Name = "scaleGroupBox";
            this.scaleGroupBox.Size = new System.Drawing.Size(125, 130);
            this.scaleGroupBox.TabIndex = 3;
            this.scaleGroupBox.TabStop = false;
            this.scaleGroupBox.Text = "Scale";
            // 
            // applyScaleBtn
            // 
            this.applyScaleBtn.Location = new System.Drawing.Point(29, 96);
            this.applyScaleBtn.Name = "applyScaleBtn";
            this.applyScaleBtn.Size = new System.Drawing.Size(84, 23);
            this.applyScaleBtn.TabIndex = 2;
            this.applyScaleBtn.Text = "Apply";
            this.applyScaleBtn.UseVisualStyleBackColor = true;
            this.applyScaleBtn.Click += new System.EventHandler(this.applyScaleBtn_Click);
            // 
            // scaleZNUD
            // 
            this.scaleZNUD.DecimalPlaces = 1;
            this.scaleZNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.scaleZNUD.Location = new System.Drawing.Point(29, 70);
            this.scaleZNUD.Name = "scaleZNUD";
            this.scaleZNUD.Size = new System.Drawing.Size(84, 20);
            this.scaleZNUD.TabIndex = 5;
            this.scaleZNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // scaleYNUD
            // 
            this.scaleYNUD.DecimalPlaces = 1;
            this.scaleYNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.scaleYNUD.Location = new System.Drawing.Point(29, 46);
            this.scaleYNUD.Name = "scaleYNUD";
            this.scaleYNUD.Size = new System.Drawing.Size(84, 20);
            this.scaleYNUD.TabIndex = 4;
            this.scaleYNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // scaleXNUD
            // 
            this.scaleXNUD.DecimalPlaces = 1;
            this.scaleXNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.scaleXNUD.Location = new System.Drawing.Point(29, 22);
            this.scaleXNUD.Name = "scaleXNUD";
            this.scaleXNUD.Size = new System.Drawing.Size(84, 20);
            this.scaleXNUD.TabIndex = 3;
            this.scaleXNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Z:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Y:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "X:";
            // 
            // reflectGroupBox
            // 
            this.reflectGroupBox.Controls.Add(this.reflectByZBtn);
            this.reflectGroupBox.Controls.Add(this.reflectByYBtn);
            this.reflectGroupBox.Controls.Add(this.reflectByXBtn);
            this.reflectGroupBox.Location = new System.Drawing.Point(143, 148);
            this.reflectGroupBox.Name = "reflectGroupBox";
            this.reflectGroupBox.Size = new System.Drawing.Size(125, 130);
            this.reflectGroupBox.TabIndex = 4;
            this.reflectGroupBox.TabStop = false;
            this.reflectGroupBox.Text = "Reflection";
            // 
            // reflectByZBtn
            // 
            this.reflectByZBtn.Location = new System.Drawing.Point(27, 96);
            this.reflectByZBtn.Name = "reflectByZBtn";
            this.reflectByZBtn.Size = new System.Drawing.Size(84, 23);
            this.reflectByZBtn.TabIndex = 2;
            this.reflectByZBtn.Text = "Reflect by Z";
            this.reflectByZBtn.UseVisualStyleBackColor = true;
            this.reflectByZBtn.Click += new System.EventHandler(this.reflectByZBtn_Click);
            // 
            // reflectByYBtn
            // 
            this.reflectByYBtn.Location = new System.Drawing.Point(27, 62);
            this.reflectByYBtn.Name = "reflectByYBtn";
            this.reflectByYBtn.Size = new System.Drawing.Size(84, 23);
            this.reflectByYBtn.TabIndex = 1;
            this.reflectByYBtn.Text = "Reflect by Y";
            this.reflectByYBtn.UseVisualStyleBackColor = true;
            this.reflectByYBtn.Click += new System.EventHandler(this.reflectByYBtn_Click);
            // 
            // reflectByXBtn
            // 
            this.reflectByXBtn.Location = new System.Drawing.Point(27, 24);
            this.reflectByXBtn.Name = "reflectByXBtn";
            this.reflectByXBtn.Size = new System.Drawing.Size(84, 23);
            this.reflectByXBtn.TabIndex = 0;
            this.reflectByXBtn.Text = "Reflect by X";
            this.reflectByXBtn.UseVisualStyleBackColor = true;
            this.reflectByXBtn.Click += new System.EventHandler(this.reflectByXBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 374);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Choose polyhedron";
            // 
            // phComboBox
            // 
            this.phComboBox.FormattingEnabled = true;
            this.phComboBox.Items.AddRange(new object[] {
            "Tetrahedron",
            "Hexahedron",
            "Octahedron",
            "Icosahedron"});
            this.phComboBox.Location = new System.Drawing.Point(12, 396);
            this.phComboBox.Name = "phComboBox";
            this.phComboBox.Size = new System.Drawing.Size(121, 21);
            this.phComboBox.TabIndex = 6;
            this.phComboBox.SelectionChangeCommitted += new System.EventHandler(this.phComboBox_SelectionChangeCommitted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.phComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.reflectGroupBox);
            this.Controls.Add(this.scaleGroupBox);
            this.Controls.Add(this.rotationGroupBox);
            this.Controls.Add(this.transGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Affine transformations in space";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.transGroupBox.ResumeLayout(false);
            this.transGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transZNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transYNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transXNUD)).EndInit();
            this.rotationGroupBox.ResumeLayout(false);
            this.rotationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rotZNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotYNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotXNUD)).EndInit();
            this.scaleGroupBox.ResumeLayout(false);
            this.scaleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scaleZNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleYNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scaleXNUD)).EndInit();
            this.reflectGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox transGroupBox;
        private System.Windows.Forms.Button applyTransBtn;
        private System.Windows.Forms.NumericUpDown transZNUD;
        private System.Windows.Forms.NumericUpDown transYNUD;
        private System.Windows.Forms.NumericUpDown transXNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox rotationGroupBox;
        private System.Windows.Forms.Button applyRotBtn;
        private System.Windows.Forms.NumericUpDown rotZNUD;
        private System.Windows.Forms.NumericUpDown rotYNUD;
        private System.Windows.Forms.NumericUpDown rotXNUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox scaleGroupBox;
        private System.Windows.Forms.Button applyScaleBtn;
        private System.Windows.Forms.NumericUpDown scaleZNUD;
        private System.Windows.Forms.NumericUpDown scaleYNUD;
        private System.Windows.Forms.NumericUpDown scaleXNUD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox reflectGroupBox;
        private System.Windows.Forms.Button reflectByZBtn;
        private System.Windows.Forms.Button reflectByYBtn;
        private System.Windows.Forms.Button reflectByXBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox phComboBox;
    }
}

