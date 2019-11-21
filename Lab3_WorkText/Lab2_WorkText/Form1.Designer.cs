namespace Lab2_WorkText
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
            this.Button_SaveFile = new System.Windows.Forms.Button();
            this.Button_View = new System.Windows.Forms.Button();
            this.Button_Clear = new System.Windows.Forms.Button();
            this.My_PictBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.My_PictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_SaveFile
            // 
            this.Button_SaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_SaveFile.Location = new System.Drawing.Point(23, 881);
            this.Button_SaveFile.Name = "Button_SaveFile";
            this.Button_SaveFile.Size = new System.Drawing.Size(139, 36);
            this.Button_SaveFile.TabIndex = 0;
            this.Button_SaveFile.Text = "Запись в файл";
            this.Button_SaveFile.UseVisualStyleBackColor = true;
            this.Button_SaveFile.Click += new System.EventHandler(this.Button_SaveFile_Click);
            // 
            // Button_View
            // 
            this.Button_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_View.Location = new System.Drawing.Point(446, 881);
            this.Button_View.Name = "Button_View";
            this.Button_View.Size = new System.Drawing.Size(139, 36);
            this.Button_View.TabIndex = 1;
            this.Button_View.Text = "Отображение";
            this.Button_View.UseVisualStyleBackColor = true;
            this.Button_View.Click += new System.EventHandler(this.Button_View_Click);
            // 
            // Button_Clear
            // 
            this.Button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Clear.Location = new System.Drawing.Point(859, 881);
            this.Button_Clear.Name = "Button_Clear";
            this.Button_Clear.Size = new System.Drawing.Size(139, 36);
            this.Button_Clear.TabIndex = 2;
            this.Button_Clear.Text = "Очистка";
            this.Button_Clear.UseVisualStyleBackColor = true;
            this.Button_Clear.Click += new System.EventHandler(this.Button_Clear_Click);
            // 
            // My_PictBox
            // 
            this.My_PictBox.BackColor = System.Drawing.Color.LightBlue;
            this.My_PictBox.Location = new System.Drawing.Point(3, 3);
            this.My_PictBox.Name = "My_PictBox";
            this.My_PictBox.Size = new System.Drawing.Size(1003, 859);
            this.My_PictBox.TabIndex = 3;
            this.My_PictBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 944);
            this.Controls.Add(this.My_PictBox);
            this.Controls.Add(this.Button_Clear);
            this.Controls.Add(this.Button_View);
            this.Controls.Add(this.Button_SaveFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "(Струченков Данил, ИВТ-7, Вариант 13)  Работа с текстом";
            ((System.ComponentModel.ISupportInitialize)(this.My_PictBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_SaveFile;
        private System.Windows.Forms.Button Button_View;
        private System.Windows.Forms.Button Button_Clear;
        private System.Windows.Forms.PictureBox My_PictBox;
    }
}

