using System;
using System.Collections.Generic;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(2, 3, '*');
            Point p2 = new Point(8, 4, '#');

            HorizontalLine xline = new HorizontalLine(5, 10, 8, '_');
            xline.Drow();

            Console.WriteLine();

            VerticalLine yline = new VerticalLine(9, 12, 4, '|');
            yline.Draw();

        }


    }
}
