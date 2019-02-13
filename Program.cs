using Project13._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCanvas.CreateNewButton(0, 600, 800, 0);
            MyCanvas.CreateNewButton(500, 500, 700, 300);
            MyCanvas.CreateNewButton(300, 200, 400, 100);            
            MyCanvas.MoveButton(1, 50, 50);
            MyCanvas.Print();
            Console.WriteLine(MyCanvas.GetCurrentNumberOfButton());
            Console.WriteLine(MyCanvas.GetMaxNumberOfButtons());
            Console.WriteLine(MyCanvas.GetTheMaxHeightOfAButton());
            Console.WriteLine(MyCanvas.GetTheMaxWidthOfAButton());
            Console.WriteLine(MyCanvas.IsPointInsideAButton(400,400));
            Console.WriteLine(MyCanvas.CheckIfAnyButtonIsOverlapping());
            //Console.WriteLine(MyCanvas.DeleteLastButton()); 
            //פתרתי את זה בדרך הפשוטה, לכן אני לא רוצה להשתמש הפונקצייה הזאת, כי היא נחותה :)
            //Console.WriteLine(MyCanvas.GetCurrentNumberOfButton());            
            //כנ"ל זאתי
            Console.ReadLine();
        }
    }
}
