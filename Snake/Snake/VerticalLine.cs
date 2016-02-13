using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yBottom, int yTop, int x, char syml)
        {
            pList = new List<Point>();
            for (int y = yBottom; y <= yTop; y++)
            {
                Point p = new Point(x, y, syml);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
