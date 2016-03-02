using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace UseCaseHelper
{
    class DrawActor
    {
       private int x;
       private int y;
       private string naam;
       private Rectangle vak;

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public Rectangle Vak { get { return vak; } }
        public string Naam { get { return naam; } }

        public DrawActor (int xpos , int ypos, string Naamact)
        {
            x = xpos;
            y = ypos;
            naam = Naamact;

        }


        public static void Draw (Graphics Graph, DrawActor act)
        {
            int x = act.x;
            int y = act.y;
            string naam = act.naam;
            Font DrawFont = new Font("Arial", 12);
            SolidBrush DrawBrush = new SolidBrush(Color.Black);


            Graph.FillEllipse(Brushes.Black, x, y, 10, 10); //Hoofd
            Graph.DrawLine(Pens.Black, x + 5, y + 5, x + 5, y + 25); //Lichaam
            Graph.DrawLine(Pens.Black, x - 5, y + 15, x + 15, y + 15);//Arm
            Graph.DrawLine(Pens.Black, x + 5, y + 25, x + 15, y + 35);//Rechterbeen
            Graph.DrawLine(Pens.Black, x + 5, y + 25, x - 5, y + 35);//Linkerbeen
            Graph.DrawString(naam, DrawFont, DrawBrush, x-15 , y+35);//naam
            act.vak = new Rectangle(x-15, y-10, 50, 60);//vierkant
        }
    }
}
