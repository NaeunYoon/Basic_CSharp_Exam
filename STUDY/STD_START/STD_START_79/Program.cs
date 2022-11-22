using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_79
{
    class PrimeCallbackArg : EventArgs  //콜백값을 담는 클래스 정의
    {
        public int Prime;
        public PrimeCallbackArg(int prime)
        {
            Prime = prime;
        }   
    }

    class PrimeGenerator    //소수생성기
    {
        public event EventHandler PrimeGenerated;
        public void Run(int limit)
        {
            for (int i = 0; i < limit; i++) //주어진 수까지 루프를 돌면서 소수가 발견되면 콜백메서드 호출
            {
                if (IsPrime(i) == true && PrimeGenerated != null)
                {
                    PrimeGenerated(this, new PrimeCallbackArg(i));   //콜백을 발생시킨 측의 인스턴스와
                                                                     //발견된 소수를 콜백 메서드에 전달
                }
            }
        }
        private bool IsPrime(int candidate) //소수판정 메서드, 이해하지 못해도 상관없음
        {
            if ((candidate & 1) == 0)
            {
                return candidate == 2;
            }
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                    return false;
            }
            return candidate != 1;
        }
    }
        

        internal class Program
        {
        
        static void PrintPrime(object sender, EventArgs arg)
        {
            Console.Write((arg as PrimeCallbackArg).Prime + ",");
        }

        static int sum;

        //콜백으로 등록될 메서드

        static void SumPrime(object sender, EventArgs arg)
        {
            sum += (arg as PrimeCallbackArg).Prime;
        }
        static void Main(string[] args)
        {
            PrimeGenerator gen = new PrimeGenerator();

            gen.PrimeGenerated += PrintPrime;

            gen.PrimeGenerated -= SumPrime;

            gen.Run(10);
            Console.WriteLine();
            Console.WriteLine(sum);

            gen.PrimeGenerated -= SumPrime;
            gen.Run(15);
        }
    }
}
