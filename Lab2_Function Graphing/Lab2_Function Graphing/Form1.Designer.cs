namespace Lab2_Function_Graphing
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
            this.MyPictureBox = new System.Windows.Forms.PictureBox();
            this.Button_Pixel = new System.Windows.Forms.Button();
            this.Button_Milimeter = new System.Windows.Forms.Button();
            this.Button_Inch = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MyPictureBox
            // 
            this.MyPictureBox.Location = new System.Drawing.Point(1, 3);
            this.MyPictureBox.Name = "MyPictureBox";
            this.MyPictureBox.Size = new System.Drawing.Size(802, 402);
            this.MyPictureBox.TabIndex = 0;
            this.MyPictureBox.TabStop = false;
            // 
            // Button_Pixel
            // 
            this.Button_Pixel.Location = new System.Drawing.Point(24, 550);
            this.Button_Pixel.Name = "Button_Pixel";
            this.Button_Pixel.Size = new System.Drawing.Size(75, 38);
            this.Button_Pixel.TabIndex = 1;
            this.Button_Pixel.Text = "Pixel";
            this.Button_Pixel.UseVisualStyleBackColor = true;
            this.Button_Pixel.Click += new System.EventHandler(this.Button_Pixel_Click);
            // 
            // Button_Milimeter
            // 
            this.Button_Milimeter.Location = new System.Drawing.Point(124, 550);
            this.Button_Milimeter.Name = "Button_Milimeter";
            this.Button_Milimeter.Size = new System.Drawing.Size(75, 38);
            this.Button_Milimeter.TabIndex = 2;
            this.Button_Milimeter.Text = "Millimeter";
            this.Button_Milimeter.UseVisualStyleBackColor = true;
            this.Button_Milimeter.Click += new System.EventHandler(this.Button_Milimeter_Click);
            // 
            // Button_Inch
            // 
            this.Button_Inch.Location = new System.Drawing.Point(221, 550);
            this.Button_Inch.Name = "Button_Inch";
            this.Button_Inch.Size = new System.Drawing.Size(75, 38);
            this.Button_Inch.TabIndex = 3;
            this.Button_Inch.Text = "Inch";
            this.Button_Inch.UseVisualStyleBackColor = true;
            this.Button_Inch.Click += new System.EventHandler(this.Button_Inch_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Location = new System.Drawing.Point(323, 550);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(75, 38);
            this.Button_Clear.TabIndex = 4;
            this.Button_Clear.Text = "Очистить";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 600);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_Inch);
            this.Controls.Add(this.Button_Milimeter);
            this.Controls.Add(this.Button_Pixel);
            this.Controls.Add(this.MyPictureBox);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №2 Построение графиков функций(Струченков) ";
            ((System.ComponentModel.ISupportInitialize)(this.MyPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MyPictureBox;
        private System.Windows.Forms.Button Button_Pixel;
        private System.Windows.Forms.Button Button_Milimeter;
        private System.Windows.Forms.Button Button_Inch;
        private System.Windows.Forms.Button Button_Clear;
    }
}

