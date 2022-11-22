using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_71
{/*
  열거형 : 값 형식의 하나로, byte sbyte short ushort int uint long ulong
           만들 상속 받아 정의할 수 있는 제한된 사용자 정의 타입
           enum 타입은 숫자형 값에 사람이 인식하기 쉬운 문자열 이름을 부여한다. 
           상속 타입을 지정하지 않는 경우 기본적으로 system.int32가 된다
  
  */

    enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Days today = Days.Sunday;

            Console.WriteLine(today);   //sunday
            Console.WriteLine(Convert.ToInt32(today));  //0
            Console.WriteLine((int)today);  //0

            today = Days.Friday;
            int n = (int)today; //enum 에서 int 형으로 명시적 형변환
            Console.WriteLine(n);   //5
            short s = (short)today; //enum 에서 short 형으로 명시적 형변환
            Console.WriteLine(s);   //5

            today = (Days)3;    //숫자형에서 enum형으로 명시적 형변환
            Console.WriteLine(today);   //WEDNESSDAY

        }
    }
}
