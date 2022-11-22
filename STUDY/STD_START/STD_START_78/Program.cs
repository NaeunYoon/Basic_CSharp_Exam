using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_78
{
    /*
     이벤트 
            1. 클래스에서 이벤트(콜백)을 제공한다
            2. 외부에서 자유롭게 해당 이벤트(콜백)을 구독하거나 해지하는 것이 가능하다
            3. 외부에서 구독/해지는 가능하지만 이벤트 발생은 오직 내부에서만 가능하다
            4. 이벤트 콜백의 첫번쨰 인자는 이벤트를 발생시킨 타입의 인스턴스다
            5. 이벤트 콜백의 두 번쨰 인자로는 해당 이벤트에 속한 의미있는 값이 제공된다
     */

    class CallbackArg { }   //콜백의 값을 담는 클래스의 최상위 부모 클래스 역할

    class PrimeCallbackArg : CallbackArg
    {
        public int Prime;

        public PrimeCallbackArg(int prime)  //생성자
        {
            Prime = prime;
        }
    }

    class PrimeGenerator    //소수생성기
    {
        public delegate void PrimeDelegate(object sender, CallbackArg arg); //콜백을 위한 델리게이트 타입 정의

        PrimeDelegate callbacks;    //콜백 메서드를 보관하는 델리게이트 인스턴스 필드

        public void AddDelegate(PrimeDelegate callback) //콜백 메서드를 추가
        {
            callbacks = Delegate.Combine(callbacks, callback) as PrimeDelegate;
        }

        public void RemoveDelelgate(PrimeDelegate callback) //콜백 메서드를 삭제
        {
            callbacks = Delegate.Remove(callbacks,callback) as PrimeDelegate;
        }

        public void Run(int limit)
        {
            for (int i = 0; i < limit; i++) //주어진 수까지 루프를 돌면서 소수가 발견되면 콜백메서드 호출
            {
                if(IsPrime(i)==true && callbacks != null)
                {
                    callbacks(this, new PrimeCallbackArg(i));   //콜백을 발생시킨 측의 인스턴스와
                                                                //발견된 소수를 콜백 메서드에 전달
                }
            }
        }

        private bool IsPrime(int candidate) //소수판정 메서드, 이해하지 못해도 상관없음
        {
            if((candidate & 1) == 0)
            {
                return candidate == 2;
            }
            for (int i = 3; (i*i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                    return false;
            }
            return candidate != 1;
        }

    }


    internal class Program
    {
        //콜백으로 등록될 메서드1

        static void PrintPrime(object sender, CallbackArg arg)
        {
            Console.Write((arg as PrimeCallbackArg).Prime+",");
        }

        static int sum;

        //콜백으로 등록될 메서드

        static void SumPrime(object sender, CallbackArg arg)
        {
            sum += (arg as PrimeCallbackArg).Prime;
        }

        static void Main(string[] args)
        {
            PrimeGenerator gen = new PrimeGenerator();

            //PrintPrime 콜백 메서드 추가

            PrimeGenerator.PrimeDelegate callPrint = PrintPrime;
            gen.AddDelegate(callPrint);

            //SumPrime 콜백 메서드 추가

            PrimeGenerator.PrimeDelegate callSum = SumPrime;
            gen.AddDelegate(callSum);

            //1~10까지 소수를 구하고

            gen.Run(10);
            Console.WriteLine();
            Console.WriteLine(sum);

            //sumPrime 콜백 메서드를 제거한 후 다시 1~15까지 소수를 구하는 메서드 호출
            gen.RemoveDelelgate(callSum);
            gen.Run(15);

        }
    }
}
