using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_63
{/*
  구조체 : 1. 인스턴스 생성을 new로 해도 되고 안해도 된다
           2. 기본 생성자는 명시적으로 정의할 수 없다
           3. 매개변수를 갖는 생성자를 정의해도 마치 기본 생성자가 있는 것처럼
              c# 컴파일러에 의해 자동으로 지원된다 ( 클래스의 경우에는 포함되지 않는다)
           4. 매개변수를 받는 생성자의 경우, 반드시 해당 코드 내에서 구조체의 모든 필드에 값을 할당해야 한다
  */

    struct Vector
    {
        public int X;
        public int Y;   

        public Vector(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public override string ToString()
        {
            return "x : " + X + " y : " + Y;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector();   //new를 사용해 인스턴스 생성 가능 => 해당 변수의 값을 0으로 할당하는것과 동일한 효과
            Vector v2;  //new가 없어도 인스턴스 생성 가능
            v2.X = 0;
            v2.Y = 0;
            Vector v3 = new Vector(0, 0);  //명시적으로 생성자 지정 가능
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);

            Console.WriteLine("");


            int n1 = new int();
            int n2;
            n2 = 0;
            int n3 = 0;

            /*Console.WriteLine(n2);*/  //오류남

        }
    }
}
