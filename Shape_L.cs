using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Final_Project___Tetris
{
    class Shape_L:Shape
    {
        Shape[] arr_L = new Shape[4];

        public Shape_L(Point p): base(p)
        {

            for (int i = 0; i < 1; i++)
            {
                arr_L[i] = new Shape(p);
                p.X += 40;
            }

            p.X -= 40;
            p.Y += 40;
            for (int i = 1; i < 4; i++)
            {
                arr_L[i] = new Shape(p);
                p.X += 40;
            }
        }

        public override void PrintShape(Graphics g)
        {
            base.PrintShape(g);
        }

        public void MoveRight(Graphics g)
        {
            base.MoveRight(arr_L, g);
        }

        public void MoveLeft(Graphics g)
        {
            base.MoveLeft(arr_L, g);
        }

        public void MoveDown(Graphics g)
        {
            base.MoveDown(arr_L, g);
        }
       
    }
}
