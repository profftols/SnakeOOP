using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    internal class Snake : Figure
    {
        public Snake(Point tail, int lenght, Direction direcrion)
        {
            pList = new List<Point>();

            for(int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direcrion);
                pList.Add(p);
            }
        }
    }
}
