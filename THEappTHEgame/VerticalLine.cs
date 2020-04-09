﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THEappTHEgame
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yU, int yD, int x, char sym)
        {
            pList = new List<Point>();
            for (int y = yU; y <= yD; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
    }
}
