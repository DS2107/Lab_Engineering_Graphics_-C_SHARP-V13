namespace Lab5_BrushesDiagramm
{
    partial class MainForm
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
            this.PictBox_Graphics = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictBox_Graphics)).BeginInit();
            this.SuspendLayout();
            // 
            // PictBox_Graphics
            // 
            this.PictBox_Graphics.Location = new System.Drawing.Point(12, 22);
            this.PictBox_Graphics.Name = "PictBox_Graphics";
            this.PictBox_Graphics.Size = new System.Drawing.Size(872, 522);
            this.PictBox_Graphics.TabIndex = 0;
            this.PictBox_Graphics.TabStop = false;
            this.PictBox_Graphics.Click += new System.EventHandler(this.PictBox_Graphics_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 593);
            this.Controls.Add(this.PictBox_Graphics);
            this.Name = "MainForm";
            this.Text = "(Струченков Данил, ИВТ-7, Вариант 13) Кисти и заполнения областей. Построение ком" +
    "мерческих диаграмм ";
            
            ((System.ComponentModel.ISupportInitialize)(this.PictBox_Graphics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictBox_Graphics;
    }
}

