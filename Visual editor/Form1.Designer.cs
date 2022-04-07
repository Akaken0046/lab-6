namespace Visual_editor
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.CircleButton = new System.Windows.Forms.RadioButton();
            this.ChangeColorButton = new System.Windows.Forms.Button();
            this.PolygonButton = new System.Windows.Forms.RadioButton();
            this.StarButton = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.numeriсCountV = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericalSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericalAngle = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriсCountV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericalSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericalAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(234, 34);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(476, 375);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            this.pictureBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseClick);
            // 
            // CircleButton
            // 
            this.CircleButton.AutoCheck = false;
            this.CircleButton.AutoSize = true;
            this.CircleButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CircleButton.Location = new System.Drawing.Point(728, 44);
            this.CircleButton.Name = "CircleButton";
            this.CircleButton.Size = new System.Drawing.Size(64, 23);
            this.CircleButton.TabIndex = 1;
            this.CircleButton.TabStop = true;
            this.CircleButton.Text = "Круг";
            this.CircleButton.UseVisualStyleBackColor = true;
            this.CircleButton.CheckedChanged += new System.EventHandler(this.CircleButton_CheckedChanged);
            this.CircleButton.Click += new System.EventHandler(this.CircleButton_Click);
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.BackColor = System.Drawing.Color.Black;
            this.ChangeColorButton.Location = new System.Drawing.Point(734, 385);
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(102, 24);
            this.ChangeColorButton.TabIndex = 2;
            this.ChangeColorButton.UseVisualStyleBackColor = false;
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorbutton_Click);
            // 
            // PolygonButton
            // 
            this.PolygonButton.AutoSize = true;
            this.PolygonButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PolygonButton.Location = new System.Drawing.Point(728, 73);
            this.PolygonButton.Name = "PolygonButton";
            this.PolygonButton.Size = new System.Drawing.Size(141, 23);
            this.PolygonButton.TabIndex = 3;
            this.PolygonButton.TabStop = true;
            this.PolygonButton.Text = "Многоугольник";
            this.PolygonButton.UseVisualStyleBackColor = true;
            this.PolygonButton.CheckedChanged += new System.EventHandler(this.PolygonButton_CheckedChanged);
            // 
            // StarButton
            // 
            this.StarButton.AutoSize = true;
            this.StarButton.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StarButton.Location = new System.Drawing.Point(728, 102);
            this.StarButton.Name = "StarButton";
            this.StarButton.Size = new System.Drawing.Size(78, 23);
            this.StarButton.TabIndex = 4;
            this.StarButton.TabStop = true;
            this.StarButton.Text = "Звезда";
            this.StarButton.UseVisualStyleBackColor = true;
            this.StarButton.CheckedChanged += new System.EventHandler(this.StarButton_CheckedChanged);
            // 
            // numeriсCountV
            // 
            this.numeriсCountV.Location = new System.Drawing.Point(731, 244);
            this.numeriсCountV.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numeriсCountV.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numeriсCountV.Name = "numeriсCountV";
            this.numeriсCountV.Size = new System.Drawing.Size(61, 22);
            this.numeriсCountV.TabIndex = 6;
            this.numeriсCountV.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numeriсCountV.Visible = false;
            this.numeriсCountV.ValueChanged += new System.EventHandler(this.NumericCountV_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(727, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Кол-во вершин:";
            this.label2.Visible = false;
            // 
            // numericalSize
            // 
            this.numericalSize.Location = new System.Drawing.Point(731, 172);
            this.numericalSize.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericalSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericalSize.Name = "numericalSize";
            this.numericalSize.Size = new System.Drawing.Size(61, 22);
            this.numericalSize.TabIndex = 8;
            this.numericalSize.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericalSize.ValueChanged += new System.EventHandler(this.NumericalSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(730, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Изменить цвет:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(727, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Размер:";
            // 
            // numericalAngle
            // 
            this.numericalAngle.Location = new System.Drawing.Point(734, 322);
            this.numericalAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericalAngle.Name = "numericalAngle";
            this.numericalAngle.Size = new System.Drawing.Size(61, 22);
            this.numericalAngle.TabIndex = 10;
            this.numericalAngle.Visible = false;
            this.numericalAngle.ValueChanged += new System.EventHandler(this.NumericalAngle_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(730, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Поворот:";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 340);
            this.label5.TabIndex = 12;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(894, 452);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericalAngle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericalSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numeriсCountV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StarButton);
            this.Controls.Add(this.PolygonButton);
            this.Controls.Add(this.ChangeColorButton);
            this.Controls.Add(this.CircleButton);
            this.Controls.Add(this.pictureBox);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriсCountV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericalSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericalAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton CircleButton;
        private System.Windows.Forms.Button ChangeColorButton;
        private System.Windows.Forms.RadioButton PolygonButton;
        private System.Windows.Forms.RadioButton StarButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.NumericUpDown numeriсCountV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericalSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericalAngle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

