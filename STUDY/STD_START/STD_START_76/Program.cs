using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_76
{/*
  불변객체 만들기 : 객체의 상태가 한 번 지정되면, 다시 바뀔 수 없음
  */

    public class Point
    {
        int x, y;

        public int X    //프로퍼티
        {
            get { return x; }
        }

        public int Y    //프로퍼티
        {
            get { return y; }
        }

        public Point(int x, int y)  //생성자
        {
            this.x = x;
            this.y = y;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point pt = new Point(5,10);

            //기존 pt 값에서 x,y 방향으로 +1 증가한 상태를 얻고 싶지만,
            //내부에서 값을 변경할 수 없으므로 새롭게 Point 객체를 만들어야 한다
            Point point = new Point(pt.X+1,pt.Y+1);
            //이런 경우에 readonly 예약어가 도움이 된다.
            //Point 클래스가 내부적으로 불변상태가 보장되는 것은 아니기 때문이다


        }
    }
}
