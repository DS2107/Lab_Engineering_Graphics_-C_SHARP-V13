using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_LineDrawing
{
    public partial class MainForm : Form
    {
        public MainForm(){

            InitializeComponent();

        } // MainForm

        private void Button_ViewGraphTemp_Click(object sender, EventArgs e){
            // Массив температуры (Точки для рисования линий)
            int[] t = { -10, 3, 11, 8, -2, 9, 15, -2, 1, -3, -10, 5, 0,
            8, 4, 12, -1, 2, 15, -1, 5, 0, -3, 7, 6, 4, 14,
            10, 8, 8, 7 };

            Graphics Graphic = PictBox_GraphTemp.CreateGraphics();

            // Создаем перо для Оси координат
            Pen MyPen = new Pen(Color.Black);

            // Ширифт для оси координат
            Font fn = new Font("Times New Roman", 10);

            // Линии координатной плоскости по центру 
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            // Рисуем ось X
            // начальная точка первой линии
            int x1 = 0; int y1 = PictBox_GraphTemp.Size.Height / 2;
            // конечная точка первой линии
            int x2 = PictBox_GraphTemp.Size.Width;
            int y2 = PictBox_GraphTemp.Size.Height / 2;
            Graphic.DrawLine(MyPen, x1, y1, x2, y2);
            // Рисуем ось Y
            // начальная точка первой линии
            x1 = 0; y1 = 0;
            // конечная точка первой линии
            x2 = 0; y2 = PictBox_GraphTemp.Size.Height;
            Graphic.DrawLine(MyPen, x1, y1, x2, y2);
            // Находим максимум в массиве темепратур
            int max = -1;
            for (int i = 0; i < t.Length; i++) { if (t[i] > max) max = t[i]; }
            // Находим количество экранных точек в единице длины по оси Y
            int dy = PictBox_GraphTemp.Size.Height / (2 * max);
            // Находим количество экранных точек в единице длины по оси X
            int dx = PictBox_GraphTemp.Size.Width / 31;
            // ************** Ставим метки по оси Y вверх **************
            int y = PictBox_GraphTemp.Size.Height / 2;
            for (int i = 0; i <= max; i++)
            {
                Graphic.DrawString(Convert.ToString(i), fn, Brushes.Red, 10, y, sf);
                Graphic.DrawLine(MyPen, 0, y, PictBox_GraphTemp.Size.Width, y);
                y = y - dy;
            }
            // ************** Ставим метки по оси Y вниз ****************
            y = PictBox_GraphTemp.Size.Height / 2;
            for (int i = 0; i <= max; i++)
            {
                Graphic.DrawString(Convert.ToString(i), fn, Brushes.Red, 10, y, sf);
                Graphic.DrawLine(MyPen, 0, y, PictBox_GraphTemp.Size.Width, y);
                y = y + dy;
            }
            // *************** Ставим метки по оси X ********************
            int x = dx;
            for (int i = 1; i <= 31; i++)
            {
                Graphic.DrawString(Convert.ToString(i), fn, Brushes.Red, x,
                PictBox_GraphTemp.Size.Height / 2 - 22, sf);
                Graphic.DrawLine(MyPen, x, PictBox_GraphTemp.Size.Height / 2 - 5, x,
                PictBox_GraphTemp.Size.Height / 2 + 5);
                x = x + dx;
            }
            MyPen.Dispose();
            // *************** Выводим график температур ***************
            // Задаем цвет и толщину пера для вывода графика температур
            MyPen = new Pen(Color.BlueViolet, 2);
            // Задаем стиль линии "точечная"
            MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            // Задаем начальную координату x
            x = dx;
            // Отмечаем кружком значение температуры в первый день
            Graphic.DrawEllipse(Pens.Red, x - 3, PictBox_GraphTemp.Size.Height / 2 - t[0] * dy - 3, 6, 6);
            // Организуем цикл по элементам массива температур
            for (int i = 1; i <= t.Length - 1; i++)
            {
                // Проводим линию из одного значения температуры в другое
                if (t[i] < 0)
                {
                    MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    Graphic.DrawLine(MyPen, x, PictBox_GraphTemp.Size.Height / 2 - t[i - 1] * dy,
                    x + dx, PictBox_GraphTemp.Size.Height / 2 - t[i] * dy);
                }
                else
                {
                    MyPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    Graphic.DrawLine(MyPen, x, PictBox_GraphTemp.Size.Height / 2 - t[i - 1] * dy,
                   x + dx, PictBox_GraphTemp.Size.Height / 2 - t[i] * dy);
                }
                // Отмечаем кружком значение температуры
                Graphic.DrawEllipse(Pens.Red, x + dx - 3, PictBox_GraphTemp.Size.Height / 2 - t[i] * dy - 3, 6, 6);
                // Переходим к следующему дню месяца
                x = x + dx;
            }
            MyPen.Dispose();

        } // Button_ViewGraphTemp_Click
    }
}
