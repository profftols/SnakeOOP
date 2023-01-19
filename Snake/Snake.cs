using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace Snake
{
    internal class Snake : Figure
    {
        Direction direction;

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

        internal void Move()
        {
            Point tail = pList.First();
            pList.Remove(tail);
            Point head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = pList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1 , direction); 
            return nextPoint;
        }

        public void HandleKey (ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.Left;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.Right;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.Down;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.Up;
        }
    }
}
