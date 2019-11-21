using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab2_Function_Graphing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Pixel_Click(object sender, EventArgs e){

            // Создаем переменную класса Graphics
            Graphics graphic = MyPictureBox.CreateGraphics();

            // Создаем кисть Черного цвета толщиной 3
            Pen myPen = new Pen(Color.Black, 3);
            
            // Закрашиваем BackGround PictureBox
            MyPictureBox.BackColor = Color.FromName("Cornsilk");

            // Обновляем
            MyPictureBox.Refresh();

            // Рамзеры
            MyPictureBox.Height = 402;
            MyPictureBox.Width = 802;

            // Нарисовать контур
            graphic.DrawRectangle(myPen, 0, 0, MyPictureBox.Size.Width - 1, MyPictureBox.Size.Height - 1);

            // Координаты перекрестия
            Point x1 = new Point(MyPictureBox.Size.Width / 2, 0);
            Point x2 = new Point(MyPictureBox.Size.Width / 2, MyPictureBox.Size.Height);
            Point y1 = new Point(0, MyPictureBox.Size.Height / 2);
            Point y2 = new Point(MyPictureBox.Size.Width, MyPictureBox.Size.Height / 2);

           // Координаты края
            int cx = MyPictureBox.Size.Width;
            int cy = MyPictureBox.Size.Height / 2;

            int Ot = 20;

            // Рисуем координатную плоскость
            graphic.DrawLine(myPen, x1, x2);
            graphic.DrawLine(myPen, y1, y2);

            // массив точек по которым будем строить график
            var ArrayPoint = new PointF[MyPictureBox.Size.Width];

            // Создаем массив
            for (int i = 0; i < MyPictureBox.Size.Width; i++)
            {
                ArrayPoint[i].Y = (float)(cy * (1 - Math.Sin(((i - 1) - Math.Abs(i)) * Ot * Math.PI / (cx - 1))));
                ArrayPoint[i].X = i;
            }
            
            // Создаем ксить для рисования самого графика
            Pen myPen2 = new Pen(Color.DarkGreen, 3);
        
            // Рисуем линию по точкам , для ислоьзуем DrawLines, Который принимает кисть и массив точек
            graphic.DrawLines(myPen2, ArrayPoint);

            
            graphic.Dispose();

        } // Button_Pixel_Click

        private void Button_Clear_Click(object sender, EventArgs e){
            MyPictureBox.Image = null;

        } // Button_Clear_Click

        private void Button_Milimeter_Click(object sender, EventArgs e){
            Graphics graphic = MyPictureBox.CreateGraphics();
            Pen myPen = new Pen(Color.Black, 1f);
            MyPictureBox.BackColor = Color.FromName("Cornsilk");
            // Получает или задает единицу измерения, используемую для координат страницы в этой графике .
            graphic.PageUnit = GraphicsUnit.Millimeter;
            MyPictureBox.Refresh();
            MyPictureBox.Height = 402;
            MyPictureBox.Width = 802;
            graphic.DrawRectangle(myPen, 0, 0, (212 - 1), (106 - 1));


            Point x1 = new Point((212 / 2), 0);
            Point x2 = new Point((212 / 2), 106);
            Point y1 = new Point(0, (106 / 2));
            Point y2 = new Point(212, 106 / 2);
            int cx = 212;
            int cy = 106 / 2;

            int Ot = 20;
            graphic.DrawLine(myPen, x1, x2);
            graphic.DrawLine(myPen, y1, y2);

            var ArrayPoint = new PointF[MyPictureBox.Size.Width];
            for (int i = 0; i < MyPictureBox.Size.Width; i++)
            {
                ArrayPoint[i].Y = (float)(cy * (1 - Math.Sin(((i - 1) - Math.Abs(i)) * Ot * Math.PI / (cx - 1))));
                ArrayPoint[i].X = i;
            }

            Pen myPen2 = new Pen(Color.Green, 1F);

            graphic.DrawLines(myPen2, ArrayPoint);

           
            graphic.Dispose();
        }

        private void Button_Inch_Click(object sender, EventArgs e)
        {
            Graphics graphic = MyPictureBox.CreateGraphics();
            Pen myPen = new Pen(Color.Black, 0.05f);
            MyPictureBox.BackColor = Color.FromName("Cornsilk");
            MyPictureBox.Refresh();
            graphic.PageUnit = GraphicsUnit.Inch;

            graphic.DrawRectangle(myPen, 0,0,8,3.9f);
            MyPictureBox.Height = 380;
            MyPictureBox.Width = 800;

            Point x1 = new Point(8 / 2, 0);
            Point x2 = new Point(8 / 2, 4);
            Point y1 = new Point(0, 4 / 2);
            Point y2 = new Point(8, 4 / 2);

            graphic.DrawLine(myPen, x1, x2);
            graphic.DrawLine(myPen, y1, y2);

            int cx = 8;
            int cy = 4 / 2;

            int Ot = 20;

            var ArrayPoint = new PointF[MyPictureBox.Size.Width];
            for (int i = 0; i < MyPictureBox.Size.Width; i++)
            {
                ArrayPoint[i].Y = (float)(cy * (1 - Math.Sin(((i - 1) - Math.Abs(i)) * Ot * Math.PI / (cx - 1))));
                ArrayPoint[i].X = i;
            }

            Pen myPen2 = new Pen(Color.Green, 0.05F);

            graphic.DrawLines(myPen2, ArrayPoint);

          /*Используйте этот метод, чтобы закрыть или освободить неуправляемые
                ресурсы, такие как файлы, потоки и дескрипторы, содержащиеся в
                экземпляре класса, который реализует этот интерфейс.*/
            graphic.Dispose();

        }
    }
}
