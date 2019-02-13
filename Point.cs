using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13._2
{
    class Point
    {
        private int _x, _y;

        internal Point(int x, int y)
        {
            SetX(x);
            SetY(y);
        }

        internal void SetX(int x)
        {
            if (x >= 0 && x <= MyCanvas.MAX_WIDTH)
            {
                _x = x;
            }
            else
            {
                Console.WriteLine($"Exceeds The Border Of The Screen ({x} Is Not Between 0 and 800)");
            }
        }

        internal void SetY(int y)
        {
            if (y >= 0 && y <= MyCanvas.MAX_HEIGHT)
            {
                _y = y;
            }
            else
            {
                Console.WriteLine($"Exceeds The Border Of The Screen ({y} Is Not Between 0 and 600)");
            }
        }

        internal int GetX()
        {
            return _x;
        }

        internal int GetY()
        {
            return _y;
        }

        public override string ToString()
        {
            return $"x: {_x},\ny: {_y}\n";
        }
    }
}
