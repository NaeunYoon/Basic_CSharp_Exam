using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_70
{/*
  TryParse : 변환이 성공했는지의 여부를 true, false로 반환하고
             반환이 성공했다면 out으로 지정된 ret 변수에 값을 반환한다


    ref : 메서드를 호출하는 측에서 변수의 값을 초기화함으로써 메서드에 의미있는 값 전달
          ref 도 참조에 의한 전달이라 메서드측에서 의미있는 값을 호출하는 측에 전달할 수 있음 [in/out] : 전달하고 받기도 함
    out : 메서드 측에서 반드시 값을 할당해서 반환함으로써 메서드를 호출한 측에 의미있는 값 반환 [out] : 전달 받기만 가능
  */
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. int형 변수 n을 1234567 문자열로 바꾸는 것에 성공하면 n 출력
            //System.Int3의 TryParse를 호출
            int n;
            if(int.TryParse("1234567",out n) == true)
            {
                Console.WriteLine(n);   //1234567
            }

            //2. double은 지수 표기법의 문자열도 지원한다 
            double d;
            if(double.TryParse("12E3",out d) == true)
            {
                Console.WriteLine(d);   //12000
            }

            //3. bool타입도 관련된 문자열 해석
            bool b;
            if(bool.TryParse("true",out b) == true)
            {
                Console.WriteLine(b);
            }

            //4.false가 반환되었으므로 실행되지 않는다
            short s;
            if(short.TryParse("Not a number",out s) == true)
            {
                Console.WriteLine(s);   
            }

            //5.short의 범위를 초과했으므로 실행되지 않는다
            if(short.TryParse("1234567890",out s) == true)
            {
                Console.WriteLine(s);
            }

            //6. 실행
            if (short.TryParse("123", out s) == true)
            {
                Console.WriteLine(s);
            }
            /*
             TryParse와 System.Object 로부터 재정의된 Tostring은 문자열과 타입 간의 변환에 있어 쌍을 이룬ㄷ
             */

            int n1 = 500;
            string txt = n1.ToString();
            Console.WriteLine(txt); //500출력 ( int형 값을 문자열로 반환)

            int result;
            int.TryParse(txt,out result);
            Console.WriteLine(result);  //500출력 (문자열로부터 int형 값을 복원)
        }
    }
}
