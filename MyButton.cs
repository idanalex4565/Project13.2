using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13._2
{
    class MyButton
    {        
        private int _width, _height;
        protected Point _topLeft, _bottomRight;

        internal MyButton(Point topLeft, Point bottomRight)
        {
            _topLeft = new Point(0, MyCanvas.MAX_HEIGHT);
            _bottomRight = new Point(MyCanvas.MAX_WIDTH, 0);
            SetTopLeft(topLeft);
            SetBottomRight(bottomRight);            
        }

        internal int GetWidth()
        {
            return _width;
        }

        internal int GetHeight()
        {
            return _height;
        }

        internal bool SetTopLeft(Point topLeft)
        {
            if (topLeft.GetX() < _bottomRight.GetX() && topLeft.GetY() > _bottomRight.GetY())
            {                
                _topLeft = topLeft;                                
                _width = _bottomRight.GetX() - topLeft.GetX();
                _height = topLeft.GetY() - _bottomRight.GetY();
                
                return true;
            }
            else
            {
                return false;
            }
        }

        internal bool SetBottomRight(Point bottomRight)
        {
            if (bottomRight.GetX() > _topLeft.GetX() && bottomRight.GetY() < _topLeft.GetY())
            {                
                _bottomRight = bottomRight;
                _width =  bottomRight.GetX() - _topLeft.GetX();
                _height = _topLeft.GetY() - bottomRight.GetY();
                
                return true;
            }
            else
            {                
                return false;
            }
        }

        internal Point GetTopLeft()
        {
            return _topLeft;
        }

        internal Point GetBottomRight()
        {
            return _bottomRight;
        }

        public override string ToString()
        {            
            return $"Button:\nHeight: {_height}\nWidth: {_width}\nTopLeft: {_topLeft.ToString()}BottomRight: {_bottomRight.ToString()}";
            
        }
    }
}
