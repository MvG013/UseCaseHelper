using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UseCaseHelper
{
    class DrawUsecase
    {
        private int x;
        private int y;

        public int X { get { return x; } }
        public int Y { get { return y; } }

        public DrawUsecase(int xpos, int ypos)
        {
            x = xpos;
            y = ypos;
        }

        public static void Draw(Graphics Graph, DrawUsecase Case)
        {
            int x = Case.x;
            int y = Case.y;

            Graph.DrawEllipse(Pens.Black, x-75 , y-45, 200, 100);

        }
    }
}
