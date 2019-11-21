using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace Lab2_WorkText
{
    public partial class MainForm : Form
    {
        // Объявляем объект "g" класса Graphics
        Graphics Graphic;
                string FileName = @"Strings.txt";
                string[] ArrayWords = {

                "First line", "Second line", "Third line",
                "Fourth line", "Fifth line", "Sixth line",
                "Seventh line", "Eighth line", "Ninth line",
                "Tenth line", "Eleven line", "Twelve line",
                "Thirteenth line", "Fourteenth line"
        };

        public MainForm(){
            InitializeComponent();
            // Предоставляем объекту "g" класса Graphics возможность
            // рисования на pictureBox1:
            Graphic = My_PictBox.CreateGraphics();
        } // MainForm

        private void Button_SaveFile_Click(object sender, EventArgs e) {
            // Создаем новый файл 
            StreamWriter NewFile = new StreamWriter(new FileStream(FileName,
            FileMode.Create, FileAccess.Write));

            // Записываем строки в файл
            foreach (string s in ArrayWords)           
                NewFile.WriteLine(s);
            
            // Закрываем поток
            NewFile.Close();
            MessageBox.Show("13 строк записано в файл !");

        } // Button_SaveFile_Click

        private void Button_Clear_Click(object sender, EventArgs e){
            // Меняем цвет PictureBox
            Graphic.Clear(Color.FromArgb(255, 255, 255));
            // Удаляем файл
            File.Delete(FileName);
            // Оповещаем
            MessageBox.Show("Файл Strings.txt удалён !");
        } // Button_Clear_Click

        private void Button_View_Click(object sender, EventArgs e){
            int k = 0;
            // Чтение строк из файла
            try
            {
                StreamReader f = new StreamReader(new FileStream(FileName,
                FileMode.Open, FileAccess.Read));
                for (int i = 0; i < 14; i++) { ArrayWords[i] = f.ReadLine(); }
                f.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            // **** Отображение строк разными шрифтами и выравниванием **
            My_PictBox.BackColor = Color.FromName("Azure");
            My_PictBox.Refresh();
            for (int i = 0; i < 14; i++)
            {
                // Отображение первой группы строк
                if ((i >= 0) && (i < 6)){
                  
                    Font fn = new Font("Arial Black", 24, FontStyle.Bold);
                    StringFormat sf =
                    (StringFormat)StringFormat.GenericTypographic.Clone();              
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Far;
                   
                    Graphic.DrawString(ArrayWords[i], fn, Brushes.Blue,
                    new RectangleF(0, -100 + i * 24, My_PictBox.Size.Width - 20,
                    My_PictBox.Size.Height - 20), sf);
                    fn.Dispose();
                } // if
                
                // Отображение второй группы строк
                if ((i >= 6) && (i < 13)){
                   
                    Font fn = new Font("Corbel", 18, FontStyle.Italic);
                    StringFormat sf =
                    (StringFormat)StringFormat.GenericTypographic.Clone();               
                    sf.Alignment = StringAlignment.Center;
                    sf.LineAlignment = StringAlignment.Far;
                    Graphic.DrawString(ArrayWords[i], fn, Brushes.Black,
                    new RectangleF(0, -280 + i * 24, My_PictBox.Size.Width - 20,
                    My_PictBox.Size.Height - 20), sf);
                    fn.Dispose();
                } // if
               
                // Отображение третьей группы строк
                if (i == 13){
                    k = i - 14;
                    Font fn = new Font("Imprint MT Shadow", 108, FontStyle.Regular);
                    StringFormat sf =
                    (StringFormat)StringFormat.GenericTypographic.Clone();
                    sf.Alignment = StringAlignment.Near;
                    sf.FormatFlags = StringFormatFlags.DirectionVertical;
                    sf.LineAlignment = StringAlignment.Center;
                    Graphic.DrawString(ArrayWords[i], fn, Brushes.Green,
                    new RectangleF(0 + k * 108, 0, My_PictBox.Size.Width - 20,
                    My_PictBox.Size.Height - 20), sf);
                    fn.Dispose();
                } // if
                
            }
        } // Button_View_Click

    } // MainForm
}
