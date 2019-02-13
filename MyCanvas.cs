using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project13._2
{
    public class MyCanvas
    {
        public const int MAX_WIDTH = 800;
        public const int MAX_HEIGHT = 600;
        private static int _buttonIndex = 0;
        private static int MaxButtons = 3;
        private static MyButton[] _buttons = new MyButton[MaxButtons];
        //private static List<MyButton> _buttons = new List<MyButton>();        

        public static bool CreateNewButton(int x1, int y1, int x2, int y2)
        {
            if(_buttonIndex < MaxButtons)
            {
                
                _buttons[_buttonIndex] = new MyButton(new Point(x1, y1), new Point(x2, y2));
                Point _tempPointTopLeft = _buttons[_buttonIndex].GetTopLeft();
                Point _tempPointBottomRight = _buttons[_buttonIndex].GetBottomRight();
                _buttonIndex++;
                //if (_tempPointTopLeft.GetX() <= 0 && _tempPointTopLeft.GetY() >=MyCanvas.MAX_HEIGHT && _tempPointBottomRight.GetX() >= MyCanvas.MAX_WIDTH && _tempPointBottomRight.GetY() <= 0)
                //{
                //    Console.WriteLine($"Button {_buttonIndex} Was Not Created!!");                                       
                //}                               
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool MoveButton(int buttonNumber, int x, int y)
        {
            Point _tempPointTopLeft = _buttons[buttonNumber].GetTopLeft();
            Point _tempPointBottomRight = _buttons[buttonNumber].GetBottomRight();
            bool succeedTopLeft = _buttons[buttonNumber].SetTopLeft(new Point(x + _tempPointTopLeft.GetX(), y + _tempPointTopLeft.GetY()));
            bool succeedBottomRight = _buttons[buttonNumber].SetBottomRight(new Point(x + _tempPointBottomRight.GetX(), y + _tempPointBottomRight.GetY()));            
            return (succeedTopLeft && succeedBottomRight);
            


        }

        public static bool DeleteLastButton()
        {            
            if (_buttonIndex > 0)
            {
                //_buttons = _buttons.Where((source, index) => index != _buttonIndex-1);
                _buttonIndex--;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ClearAllButton()
        {
            for (int i = _buttonIndex; i < 0; _buttonIndex--)
            {
                //_buttons = _buttons.Where((source, index) => index != _buttonIndex - 1).ToArray();
            }
        }

        public static int GetCurrentNumberOfButton()
        {
            return _buttonIndex;
        }

        public static int GetMaxNumberOfButtons()
        {
            return MaxButtons+1;
        }

        public static int GetTheMaxWidthOfAButton()
        {
            int i = 0;
            foreach (MyButton item in _buttons)
            {
                if(item.GetWidth() > i)
                {
                    i = item.GetWidth();
                }                
            }
            return i;
        }

        public static int GetTheMaxHeightOfAButton()
        {
            int i = 0;
            foreach (MyButton item in _buttons)
            {
                if (item.GetHeight() > i)
                {
                    i = item.GetHeight();
                }
            }
            return i;
        }

        public static void Print()
        {
            foreach (MyButton item in _buttons)
            {
                Console.WriteLine(item);
            }

        }

        public static bool IsPointInsideAButton(int x, int y)
        {
            bool i = false;
            foreach (MyButton item in _buttons) 
            {
                Point _tempPointTopLeft = item.GetTopLeft();
                Point _tempPointBottomRight = item.GetBottomRight();
                if (_tempPointTopLeft.GetX() < x && _tempPointTopLeft.GetY() > y && _tempPointBottomRight.GetX() > x && _tempPointBottomRight.GetY() < y)
                    {
                        i = true;
                    }
                if (i == true)
                {
                    break;
                }
            }
            return i;
            
        }

        public static bool CheckIfAnyButtonIsOverlapping()
        {
            bool i = false;
            foreach (MyButton item in _buttons)
            {
                Point _tempPointTopLeft = item.GetTopLeft();
                Point _tempPointBottomRight = item.GetBottomRight();
                foreach (MyButton item2 in _buttons)
                {                    
                    Point _tempPointTopLeft2 = item2.GetTopLeft();
                    Point _tempPointBottomRight2 = item2.GetBottomRight();
                    if (_tempPointTopLeft.GetY() > _tempPointBottomRight2.GetY() && _tempPointTopLeft.GetY() < _tempPointTopLeft2.GetY()
                        && _tempPointTopLeft.GetX() < _tempPointBottomRight2.GetX() && _tempPointTopLeft.GetX() > _tempPointTopLeft2.GetX())
                    {
                        return true;
                    }
                    if(_tempPointTopLeft.GetY() > _tempPointBottomRight2.GetY() && _tempPointTopLeft.GetY() < _tempPointTopLeft2.GetY()
                        && _tempPointBottomRight.GetX() < _tempPointBottomRight2.GetX() && _tempPointBottomRight.GetX() > _tempPointTopLeft2.GetX())
                    {
                        return true;
                    }                    
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"Number Of Buttons On The Canvas: {_buttonIndex}\n";
        }
    }
}
