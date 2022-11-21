using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_64
{/*
  깊은 복사와 얕은 복사
  
  */

    struct Vector
    {
        public int x;
        public int y;
    }

    class Point
    {
        public int x;
        public int y;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1;
            v1.x = 5;
            v1.y = 10;

            Vector v2 = v1; //값 형식의 대입

            v2.x = 7;
            v2.y = 14;

            Console.WriteLine("v1 : x =" + v1.x + " v1 : y =" + v1.y);
            Console.WriteLine("v2 : x =" + v2.x + " v2 : y =" + v2.y);
            //-------------------------------------------------
            Point pt1 = new Point();
            pt1.x = 6;
            pt1.y = 12;

            Point pt2 = pt1;    //참조 형식의 대입

            pt2.x= 7;
            pt2.y = 14;

            Console.WriteLine("pt1 : x =" + pt1.x + " pt1 : y =" + pt1.y);
            Console.WriteLine("pt2 : x =" + pt2.x + " pt2 : y =" + pt2.y);
            //같은 메모리 상의 인스턴스를 가리키고 있으므로, 둘 중 어느 하나라도 해당 필드의 값을
            //변경하면, 변수의 결과값이 함께 변경된 것 처럼 보인다

            Change(v1);
            Console.WriteLine("vt : v1 =" + v1.x + " vt : v2 =" + v1.y);

            Change(pt1);
            Console.WriteLine("pt : v1 =" + pt1.x + " pt : v2 =" + pt1.y);


        }

        private static void Change(Vector vt)
        {
            vt.x = 9;
            vt.y = 99;
        }

        private static void Change(Point point)
        {
            point.x = 9;
            point.y = 99;
        }

    }
}
