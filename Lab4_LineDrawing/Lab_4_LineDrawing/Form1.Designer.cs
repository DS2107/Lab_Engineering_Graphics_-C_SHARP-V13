namespace Lab_4_LineDrawing
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
            this.Button_ViewGraphTemp = new System.Windows.Forms.Button();
            this.PictBox_GraphTemp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictBox_GraphTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_ViewGraphTemp
            // 
            this.Button_ViewGraphTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_ViewGraphTemp.Location = new System.Drawing.Point(829, 257);
            this.Button_ViewGraphTemp.Name = "Button_ViewGraphTemp";
            this.Button_ViewGraphTemp.Size = new System.Drawing.Size(248, 69);
            this.Button_ViewGraphTemp.TabIndex = 0;
            this.Button_ViewGraphTemp.Text = "Вывести график температур";
            this.Button_ViewGraphTemp.UseVisualStyleBackColor = true;
            this.Button_ViewGraphTemp.Click += new System.EventHandler(this.Button_ViewGraphTemp_Click);
            // 
            // PictBox_GraphTemp
            // 
            this.PictBox_GraphTemp.Location = new System.Drawing.Point(2, 4);
            this.PictBox_GraphTemp.Name = "PictBox_GraphTemp";
            this.PictBox_GraphTemp.Size = new System.Drawing.Size(793, 565);
            this.PictBox_GraphTemp.TabIndex = 1;
            this.PictBox_GraphTemp.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 604);
            this.Controls.Add(this.PictBox_GraphTemp);
            this.Controls.Add(this.Button_ViewGraphTemp);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "(Струченков Данил, ИВТ-7, Вариант13) Рисование линий ";
            ((System.ComponentModel.ISupportInitialize)(this.PictBox_GraphTemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_ViewGraphTemp;
        private System.Windows.Forms.PictureBox PictBox_GraphTemp;
    }
}

