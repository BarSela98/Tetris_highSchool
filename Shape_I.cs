using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Final_Project___Tetris
{
     class Shape_I:Shape
    {
       // Shape[] arr_I = new Shape[4];

        public Shape_I(Point p):base(p)
        {
            for (int i = 0; i < arrShape.Length; i++)
            {
                arrShape[i] = new Shape(p);
                p.X += 40;
            }
        }

        public override void PrintShape( Graphics g)
        {
            base.PrintShape( g);
        }

        public void MoveRight(Graphics g)
        {
            base.MoveRight(arrShape, g);
        }

        public void MoveLeft(Graphics g)
        {
            base.MoveLeft(arrShape, g);
        }

        public void MoveDown(Graphics g)
        {
            base.MoveDown(arrShape, g);
        }
    }
}
