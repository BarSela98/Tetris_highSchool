using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;



namespace Final_Project___Tetris
{
     class Shape
    {
        Rectangle rec;
        Size s;
        int Move_X = 40;
        int Move_Y = 40;
        protected Shape[] arrShape;// = new Shape[4];

        public Shape(Point p)
        {
            s = new Size(40, 40);
            rec = new Rectangle(p, s);
            arrShape = new Shape[4];
        }

        public Rectangle Get_RectangleShape()
        {
            return rec;
        }

        public  virtual void PrintShape( Graphics g)
        {
            g.FillRectangle(Brushes.Blue, arrShape[0].Get_RectangleShape());
            g.FillRectangle(Brushes.Blue, arrShape[1].Get_RectangleShape());
            g.FillRectangle(Brushes.Blue, arrShape[2].Get_RectangleShape());
            g.FillRectangle(Brushes.Blue, arrShape[3].Get_RectangleShape());
        }

        public void DeletShape(Shape[] arr, Graphics g)
        {
            g.FillRectangle(Brushes.Gainsboro, arr[0].Get_RectangleShape());
            g.FillRectangle(Brushes.Gainsboro, arr[1].Get_RectangleShape());
            g.FillRectangle(Brushes.Gainsboro, arr[2].Get_RectangleShape());
            g.FillRectangle(Brushes.Gainsboro, arr[3].Get_RectangleShape());
        }

        public void MoveRight(Shape[] arr, Graphics g)
        {
            if (arr[0].rec.X < 360 && arr[1].rec.X < 360
                && arr[2].rec.X < 360 && arr[3].rec.X < 360)
            {
                DeletShape(arr, g);
                arr[0].rec.X += Move_X;
                arr[1].rec.X += Move_X;
                arr[2].rec.X += Move_X;
                arr[3].rec.X += Move_X;
                PrintShape( g);
            }
        }

        public void MoveLeft(Shape[] arr, Graphics g)
        {
            if (arr[0].rec.X > 0 && arr[1].rec.X > 0
                && arr[2].rec.X > 0 && arr[3].rec.X > 0)
            {
                DeletShape(arr, g);
                arr[0].rec.X -= Move_X;
                arr[1].rec.X -= Move_X;
                arr[2].rec.X -= Move_X;
                arr[3].rec.X -= Move_X;
                PrintShape( g);
            }
        }

        public void MoveDown(Shape[] arr, Graphics g)
        {
            if (arr[0].rec.Y < 680 && arr[1].rec.Y < 680
                && arr[2].rec.Y < 680 && arr[3].rec.Y < 680)
            {
                DeletShape(arr, g);
                arr[0].rec.Y += Move_Y;
                arr[1].rec.Y += Move_Y;
                arr[2].rec.Y += Move_Y;
                arr[3].rec.Y += Move_Y;
                PrintShape( g);
            }
        }

        public void Reverse(Shape[] arr, Graphics g)
        {

        }




    }
}
