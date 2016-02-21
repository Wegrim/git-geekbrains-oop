using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class FoodCreator
    {
        int mapWight;
        int mapHeight;
        char syml;

        Random random = new Random();

        public FoodCreator(int mapWight, int mapHeight, char syml)
        {
            this.mapWight = mapWight;
            this.mapHeight = mapHeight;
            this.syml = syml;
        }

        public Point CreateFood()
        {
            int x = random.Next(2, mapWight - 2);
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, syml);
        }
    }
}
