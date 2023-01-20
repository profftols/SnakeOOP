﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    internal class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        { 
            x = _x;
            y = _y;
            sym = _sym;
        } 

        public Point (Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.Right) x = x + offset;
            else if(direction == Direction.Left) x = x - offset;
            else if(direction == Direction.Up) y = y - offset;
            else if(direction == Direction.Down) y = y + offset;
        }

        public void Draw ()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }

        public bool IsHit(Point p)
        {
            return p.x == x && p.y == y;
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }
    }
}
