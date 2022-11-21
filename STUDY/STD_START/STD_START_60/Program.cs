using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_60
{/*
  IEnumerable 인터페이스
  
  */

    public interface IEnumarator
    {
        object Current { get; } //현재 요소를 반환하도록 약속된 get 프로퍼티
        bool MoveNext();    //다음 순서의 요소로 넘어가도록 약속된 메서드
        void Reset();   //열거 순서를 처음으로 되돌릴 때 호출하는 메서드

        //IEnumerable을 구현한 전형적인 예는 System.Array 이다
    }

    public interface IEnumerable
    {
        IEnumerable GetEnumerator();    //열거자 라는 객체를 반환하도록 약속되어 있다
                                        //열거자란 IEnumerator 인터페이스를 구현한 객체를 일컫는다
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };

            IEnumerator enumerator = intArray.GetEnumerator();

            while (enumerator.MoveNext())
            {
                Console.Write(enumerator.Current + ",");
            }
            Console.WriteLine("");

            string name = "KOREA";
            foreach (char ch in name)
            {
                Console.Write(ch+",");
            }
            Console.WriteLine("");
        }
    }
}
