using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Final_Project___Tetris
{
    class Shape_O:Shape
    {
        Shape[] arr_O = new Shape[4];


        public Shape_O(Point p):base(p)
        {
            for (int i = 0; i < 2; i++)
            {
                arr_O[i] = new Shape(p);
                p.X += 40;
            }

            p.X -= 80;
            p.Y += 40;

            for (int i = 2; i < 4; i++)
            {
                arr_O[i] = new Shape(p);
                p.X += 40;
            }

        }

        public override void PrintShape(Graphics g)
        {
            base.PrintShape(g);
        }

        public void MoveRight(Graphics g)
        {
            base.MoveRight(arr_O, g);
        }

        public void MoveLeft(Graphics g)
        {
            base.MoveLeft(arr_O, g);
        }

        public void MoveDown(Graphics g)
        {
            base.MoveDown(arr_O, g);
        }



    }
}
