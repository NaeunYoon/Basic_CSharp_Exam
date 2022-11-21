using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace STD_START_66
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
            Point pt1 = new Point();

            pt1.x = 5;
            pt1.y = 10;


            Change(ref pt1);
            Console.WriteLine("pt1 : x = "+pt1.x+" pt1 : y "+pt1.y);

        }

        private static void Change(ref Point point)
        {
            point.x = 7;
            point.y = 14;
        }

    }
}
