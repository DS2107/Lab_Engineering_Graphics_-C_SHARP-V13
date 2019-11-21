using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_StaticImages
{
    public partial class StaticImageLab : Form
    {
        Graphics g;
        public StaticImageLab()
        {
            InitializeComponent();
          
        }


       
        protected override void OnPaint(PaintEventArgs e)
        {

            g = e.Graphics;
            SolidBrush myFire1 = new SolidBrush(Color.LightGray);
            SolidBrush myFire2 = new SolidBrush(Color.LightGreen);
            SolidBrush stolb = new SolidBrush(Color.Black);
            // Рисуем луну
            // Определяем закраску изображением
            Image img = Image.FromFile("Pl.jpg");
            TextureBrush tb = new TextureBrush(img);
            g.FillRectangle(tb, 0, 350, 900, 100);
            SolidBrush zd1 = new SolidBrush(Color.Brown);
            SolidBrush zd2 = new SolidBrush(Color.BurlyWood);
            SolidBrush zd3 = new SolidBrush(Color.Chocolate);
            SolidBrush zd4 = new SolidBrush(Color.Crimson);
            g.FillRectangle(zd1, 400, 200, 150, 150);
            g.FillRectangle(zd2, 200, 150, 100, 200);
            g.FillRectangle(zd3, 600, 200, 150, 150);
            g.FillRectangle(zd4, 80, 200, 100, 100);

            Pen pen = new Pen(Color.Black, 4);
            g.DrawLine(pen, 100, 600, 100, 350);
            g.DrawLine(pen, 200, 200, 100, 200);
            g.DrawLine(pen, 200, 260, 200, 200);
            int x = 200; int y = 250;
            SolidBrush myStar = new SolidBrush(Color.OrangeRed);
            g.FillPolygon(myStar, new Point[] {

     
                new Point(x+15,y+10),new Point(x+5,y+15),
                new Point(x,y+20),new Point(x-5,y+15),
                new Point(x-15,y+10),new Point(x-5,y+5)

                    });
            // Звезды
            PrintStar();

            // Рисуем луну
            g.FillEllipse(myFire1, 550, 40, 70, 70);
           

        }
      public void PrintStar()
        {
            SolidBrush myStar = new SolidBrush(Color.GreenYellow);
            // Рисуем звезду
            int y = 50;
            for (int x = 0; x < 2000; x += 100)
            {

                if (y == 100)
                {
                    g.FillPolygon(myStar, new Point[] {

                new Point(x,y),new Point(x+5,y+5),
                new Point(x+15,y+10),new Point(x+5,y+15),
                new Point(x,y+20),new Point(x-5,y+15),
                new Point(x-15,y+10),new Point(x-5,y+5)

                    });
                    y -= 50;
                }
                else if (y == 50)
                {
                    g.FillPolygon(myStar, new Point[] {

                    new Point(x,y),new Point(x+5,y+5),
                    new Point(x+15,y+10),new Point(x+5,y+15),
                    new Point(x,y+20),new Point(x-5,y+15),
                    new Point(x-15,y+10),new Point(x-5,y+5)

                    });
                    y += 50;
                }

            }
        }
    }

}


