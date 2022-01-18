using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Final_Project___Tetris
{
    class Shape_T:Shape
    {
        Shape[] arr_T = new Shape[4];


        public Shape_T(Point p): base(p)
        {

            p.X += 40;
            for (int i = 0; i < 1; i++)
            {
                arr_T[i] = new Shape(p);
                p.X += 40;
            }

            p.Y += 40;
            p.X -= 80;
            for (int i = 1; i < 4; i++)
            {
                arr_T[i] = new Shape(p);
                p.X += 40;
            }
        }

        public override void PrintShape(Graphics g)
        {
            base.PrintShape( g);
        }

        public void MoveRight(Graphics g)
        {
            base.MoveRight(arr_T, g);
        }

        public void MoveLeft(Graphics g)
        {
            base.MoveLeft(arr_T, g);
        }

        public void MoveDown(Graphics g)
        {
            base.MoveDown(arr_T, g);
        }
    }
}
