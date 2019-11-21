using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_BrushesDiagramm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.Show();
            // Создаем графический контекст формы
            Graphics g = this.CreateGraphics();
            // Выводим подсказку
            g.DrawString("Кликните мышкой по элементу PictureBox",
            new Font("Arial", 10, FontStyle.Regular), Brushes.Red, 0, 0);
            // Уничтожаем графический контест формы
            g.Dispose();
        } // MainForm

       

        private void PictBox_Graphics_Click(object sender, EventArgs e)
        {
            // Создаем графический контест pictureBox1
            Graphics g = PictBox_Graphics.CreateGraphics();
            // Задаем координаты точек многоугольника
            Point[] point = new Point[13] { new Point(120, 20),
new Point(180, 30), new Point(240, 20),
new Point(300, 30), new Point(360, 20),
new Point(420, 30), new Point(420, 80),
new Point(360, 90), new Point(300, 80),
new Point(240, 90), new Point(180, 80),
new Point(120, 90), new Point(135, 55)
};
            // Рисуем многоугольник
            g.DrawPolygon(new Pen(Color.Blue, 2), point);
            // Задаем фонт и выранивание по центру
            Font fn = new Font("Arial", 10, FontStyle.Bold);
            StringFormat sf = new StringFormat();

            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            // Задаем и выводим поясняющую надпись
            string s = "Количество студентов факультета девяти годов рождения.";
            g.DrawString(s, fn, Brushes.Red, new Rectangle(125, 20, 300, 70), sf);
            // Рисуем рамку по периметру pictureBox1
            g.DrawRectangle(new Pen(Color.LightSeaGreen, 5), 0, 0,
            PictBox_Graphics.Width - 1, PictBox_Graphics.Height - 1);
            // Задаем координаты начала и конца осей x и y
            int nachalo_x = 30; int konec_x = PictBox_Graphics.Width - 10;
            int nachalo_y = 120; int konec_y = PictBox_Graphics.Height - 20;
            // Рисуем ось x
            g.DrawLine(new Pen(Color.Black, 1), nachalo_x, konec_y,
            konec_x, konec_y);
            // Рисуем ось y
            g.DrawLine(new Pen(Color.Black, 1), nachalo_x, nachalo_y,
            nachalo_x, konec_y);
            // Задаем значения годов
            string[] year = new string[9] { "2009", "2010", "2011",
"2012", "2013", "2014", "2015", "2016", "2017"};
            // Задаем значения элементов массива заработных плат
            int[] value = new int[9] { 1000, 1250, 1320, 1444, 1557, 1670, 1722, 1811, 2000 };
            // Находим максимум в массиве заработных плат
            int max = -1;
            for (int i = 0; i < value.Length; i++) { if (value[i] > max) max = value[i]; }
            // Задаем масштабный делитель
            double mash = 5.0;
            // Определяем количество точек на единицу заработной платы
            double dy = (konec_y - nachalo_y) / (max / mash);
            // Задаем ширину прямоугольников диаграммы
            int widthRect = ((konec_x - nachalo_x) / value.Length) / 2;
            // Определяем сплошную закраску
            SolidBrush sb = new SolidBrush(Color.CornflowerBlue);
            // Определяем закраску штриховкой
            System.Drawing.Drawing2D.HatchBrush hb = new System.Drawing.Drawing2D.HatchBrush(System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal,
            Color.CornflowerBlue, Color.LightSkyBlue);
            // Определяем закраску изображением
            Image img = Image.FromFile("img.bmp");
            TextureBrush tb = new TextureBrush(img);

            // Задаем начальную координату x
            int x = nachalo_x + widthRect;
            // Организуем цикл по элементам массива заработных плат
            for (int i = 0; i < value.Length; i++)
            {
                // Задаем прямоугольную область элемента диаграммы
                Rectangle rect = new Rectangle(x, konec_y - (int)(dy * (value[i] /
                mash)), widthRect, (int)(dy * (value[i] / mash)));
                // Выводим закрашенные разными стилями и цветом прямоугольники
                if (i < 3) g.FillRectangle(sb, rect);
                if ((i >= 3) && (i < 6)) g.FillRectangle(hb, rect);
                if ((i >= 6) && (i < 9)) g.FillRectangle(tb, rect);
                // Выводим рамку вокруг прямоугольника
                g.DrawRectangle(new Pen(Color.Black, 1), rect);
                // Переходим к отображению следующего элемента
                x += 2 * widthRect;
            }
            // Разметка по оси Y
            Pen p = new Pen(Color.Blue, 2);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            fn = new Font("Arial", 8, FontStyle.Bold);
            sf.Alignment = StringAlignment.Near;
            sf.LineAlignment = StringAlignment.Center;
            for (int i = 0; i < value.Length; i++)
            {
                // Рисуем штрихпунктирные линии
                g.DrawLine(p, nachalo_x - 5, konec_y - (int)(dy * (value[i] /
                mash)), konec_x, konec_y - (int)(dy * (value[i] / mash)));
                // Выводим размеры зарплат
                g.DrawString(value[i].ToString(), fn, Brushes.Black,
                new Rectangle(1, konec_y - (int)(dy * (value[i] / mash)) -
                (int)fn.Size, 30, 20), sf);
            }
            // Разметка по оси X
            sf.Alignment = StringAlignment.Center;
            x = nachalo_x + widthRect + widthRect / 2;
            for (int i = 0; i < year.Length; i++)
            {
                // Рисуем черточки по оси X
                g.DrawLine(new Pen(Color.Black, 1), x, konec_y - 5, x,
                konec_y + 5);
                // Выводим годы
                g.DrawString(year[i], fn, Brushes.Black, new Rectangle(x - 25,
                konec_y, 50, 22), sf);
                x += 2 * widthRect;

            }
        }
    }
}
