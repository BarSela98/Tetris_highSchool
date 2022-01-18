using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Final_Project___Tetris
{
    class Shape_Z:Shape
    {
        Shape[] arr_Z = new Shape[4];


        public Shape_Z(Point p): base(p)
        {

            for (int i = 0; i < 2; i++)
            {
                arr_Z[i] = new Shape(p);
                p.X += 40;
            }

            p.X -= 40;
            p.Y += 40;
            for (int i = 2; i < 4; i++)
            {
                arr_Z[i] = new Shape(p);
                p.X += 40;
            }

        }

        public override void PrintShape(Graphics g)
        {
            base.PrintShape( g);
        }

        public void MoveRight(Graphics g)
        {
            base.MoveRight(arr_Z, g);
        }

        public void MoveLeft(Graphics g)
        {
            base.MoveLeft(arr_Z, g);
        }

        public void MoveDown(Graphics g)
        {
            base.MoveDown(arr_Z, g);
        }
    }
}
