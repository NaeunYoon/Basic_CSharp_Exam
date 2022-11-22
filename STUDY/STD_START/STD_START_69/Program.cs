using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_69
{/*
  out : 참조에 의한 호출을 가능케 하는 예약어
        1. out으로 지정된 인자에 넘길 변수는 초기화하지 않아도 된다
           초기화 되어 있더라도, out 인자를 받는 메서드에서는 그 값을 사용할 수 없다
        2. out으로 지정된 인자를 받는 메서드는 반드시 변수에 값을 넣어서 반환해야 한다

        예를 들어, 메서드는 단 1개의 반환값만 가질 수 있지만, out으로 지정된 매개변수를 사용함으로써
        여러개의 값을 반환할 수 있다.
  
  */
    internal class Program
    {
        //1. 분모가 0인 경우도 동일한 값을 반환하는 것은 잘못된 구현
        int Divide1 (int n1, int n2)
        {
            if (n2 == 0)
            {
                return 0;
            }
            return n1 / n2;
        }                       
        //2. 나누기를 할 수 있는지의 여부를 불린형으로 반환한다 (구조체 사용)
        struct DivideResult //구조체
        {
            public bool Success;
            public int Result;
        }

        DivideResult Divide2(int n1, int n2)
        {
            DivideResult divideResult = new DivideResult();

            if(n2 == 0)
            {
                divideResult.Success = false;
                return divideResult;
            }

            divideResult.Success = true;
            divideResult.Result = n1 / n2;
            return divideResult;
        }
        //3. 예약어를 사용해서 한다
        //out 으로 지정된 ret 변수는 메서드가 return하기 전에 초기화 되어야 한다

        static bool Divide3(int n1, int n2, out int ret)
        {
            if (n2 == 0)
            {
                ret = 0;
                return false;
            }
            ret = n1 / n2;
            return true;
        }

        static void Main(string[] args)
        {
            int quotient;
            if(Divide3(15,3,out quotient) == true)
            {
                Console.WriteLine(quotient);
            }

        }
    }
}
