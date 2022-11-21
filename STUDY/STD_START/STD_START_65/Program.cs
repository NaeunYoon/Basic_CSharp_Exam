using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_65
{/*
  ref 예약어 : 변수의 스택값이 복사되는 상황을 특별히 메서드의 인자 전달과 관련해
               값에 의한 호출 CallByValue 라고 한다

               이와 구분해서 참조에 의한 호출 이라는 방법도 있다.
               이 방식으로 메서드에 인자를 전달하면, 변수의 스택값이 복사되는 것이 아니라
               해당 변수의 스택값을 담고 있는 주소 자체가 전달된다
               c# 에서는 참조에 의한 호출을 지원하기 위해 두 가지 예약어를 추가했는데
               ref와out 이다

               1. 메서드의 매개변수를 선언할 때 함꼐 표기
               2. 해당 메서드를 호출하는 측에서도 명시
  
  */

    struct Vector
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

            Change(ref v1); //메서드 호출 시 ref 예약어 사용
            Console.WriteLine("v1 = x "+v1.x + " v1.y = " + v1.y);      //값이 바뀜

        }

        static void Change(ref Vector vt)   //메서드 측에서도 해당 매개변수에 ref 예약어 사용
        {
            vt.x = 7;
            vt.y = 14;
        }
    }
}
