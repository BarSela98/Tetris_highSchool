using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Final_Project___Tetris
{
    class Shape_J:Shape
    {
        
        Shape[] arr_J = new Shape[4];


        public Shape_J(Point p): base(p)
        {
            p.X += 80;
            for (int i = 0; i < 1; i++)
            {
                arr_J[i] = new Shape(p);
                p.X += 40;
            }

            p.X -=120;
            p.Y += 40;
            for (int i = 1; i < 4; i++)
            {
                arr_J[i] = new Shape(p);
                p.X += 40;
            }
        }

        public override void PrintShape(Graphics g)
        {
            base.PrintShape( g);
        }

        public void MoveRight(Graphics g)
        {
            base.MoveRight(arr_J, g);
        }

        public void MoveLeft(Graphics g)
        {
            base.MoveLeft(arr_J, g);
        }

        public void MoveDown(Graphics g)
        {
            base.MoveDown(arr_J, g);
        }
      
    }
}

