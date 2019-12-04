namespace Lab7_Animation
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
            this.MyShip = new System.Windows.Forms.PictureBox();
            this.myship3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MyShip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myship3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MyShip
            // 
            this.MyShip.Image = global::Lab7_Animation.Properties.Resources.Cjkywt;
            this.MyShip.Location = new System.Drawing.Point(621, -54);
            this.MyShip.Name = "MyShip";
            this.MyShip.Size = new System.Drawing.Size(210, 212);
            this.MyShip.TabIndex = 4;
            this.MyShip.TabStop = false;
            // 
            // myship3
            // 
            this.myship3.BackColor = System.Drawing.Color.White;
            this.myship3.BackgroundImage = global::Lab7_Animation.Properties.Resources._5;
            this.myship3.Image = global::Lab7_Animation.Properties.Resources._5;
            this.myship3.Location = new System.Drawing.Point(1, 200);
            this.myship3.Name = "myship3";
            this.myship3.Size = new System.Drawing.Size(151, 195);
            this.myship3.TabIndex = 3;
            this.myship3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Highlight;
            this.pictureBox1.Location = new System.Drawing.Point(1, 395);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(801, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.MyShip);
            this.Controls.Add(this.myship3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.MyShip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myship3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox myship3;
        private System.Windows.Forms.PictureBox MyShip;
    }
}

