using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_77
{
  /*
  상수 : 변하는 값을 고정된 식별자로 가리키는 것이 변수라면,
         상수는 변하지 않는 값인 리터럴을 식별자로 재사용 할 수 있게 만들어준다

         상수는 readonly 변수와 유사하지만 차이가 있다
         1. 상수는 static 예약어가 허용되지 않으나 의미상으로는 이미 static에 해당
         2. 기본 자료형에서 다룬 형식에 대해서만 상수 정의가 허용된다
         3. 반드시 상수 정의와 함께 값을 대입해야 한다 ( 생성자에서 접근할 수 없다)
         4. 상서는 컴파일 할 떄, 해당 소스코드에 값이 직접 치환되는 방식으로 구현된다

         숫자형 상수는 서로 연관된 것들끼리 모아서 enum 타입으로 정리할 수 있다
  */

    enum Days
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday 
    }

    internal class Program
    {
        const string text = "변수 값 ";

        const int Sunday = 0;
        const int Monday = 1;
        const int Tuesday = 2;
        const int Wednesday = 3;
        const int Thursday = 4;
        const int Friday = 5;
        const int Saturday = 6;
        
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            Console.WriteLine("x변수의 값 "+x);
            Console.WriteLine("y변수의 값 "+y);
            //=> "변수의 값"이 중복되어 사용된다.
            //"변수의 값" 을 "변수값"으로 바꾸는 경우
            Console.WriteLine("");

            Console.WriteLine("x"+text+x);
            Console.WriteLine("y"+text+y);

            Console.WriteLine("\n상수값들");
            Console.WriteLine("sbyte "+ sbyte.MinValue + "~ "+sbyte.MaxValue);
            Console.WriteLine("byte " + byte.MinValue + "~ " + byte.MaxValue);
            Console.WriteLine("short " + short.MinValue + "~ " + short.MaxValue);
            Console.WriteLine("usbyte " + ushort.MinValue + "~ " + ushort.MaxValue);
            Console.WriteLine("char " + char.MinValue + "~ " + char.MaxValue);
            Console.WriteLine("int " + int.MinValue + "~ " + int.MaxValue);
            Console.WriteLine("uint " + uint.MinValue + "~ " + uint.MaxValue);
            Console.WriteLine("long " + long.MinValue + "~ " + long.MaxValue);
            Console.WriteLine("ulong " + ulong.MinValue + "~ " + ulong.MaxValue);
            Console.WriteLine("float " + float.MinValue + "~ " + float.MaxValue);
            Console.WriteLine("double " + double.MinValue + "~ " + double.MaxValue);
            Console.WriteLine("decimal " + decimal.MinValue + "~ " + decimal.MaxValue);


        }
    }
}
