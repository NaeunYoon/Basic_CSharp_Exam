using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_67
{
    class Point
    {
        public int x;
        public int y;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point pt = null;

            Change1(pt);    //메서드 호출 (얕은 복사)
            Console.WriteLine("pt ; "+ pt);

            Change2(ref pt);    //메서드 호출 (ref사용)            
            {
            Console.WriteLine("pt.x =" + pt.x + " pt.y = "+pt.y);
            }

            
        }

        static void Change1(Point pt)
        {
            pt = new Point();

            pt.x = 6;
            pt.y = 12;
        }

        static void Change2(ref Point pt)
        {
            pt = new Point();

            pt.x = 8;
            pt.y = 16;
        }
        
    }
}
