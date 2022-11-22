using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STD_START_72
{
    //Today 타입은 int 가 부모이므로 long 값을 지정하면 오류가 발생한다
    enum Today
    {
        Sunday =5,  //5
        Monday =10, //10
        Tusday, //11
        Wednesday,  //12
        Thursday=15,    //15
        Friday, //16
        Saturday,   //17
    }
    [Flags]//flag 특성을 지정해서 열거형 타입 정의를 할때 지정해준다
    enum Days   //이렇게 정의하면 | 연산자를 사용해 정수형 값을 겹칠 수 있고, 
                //hashflag 메서드를 사용해 특정 요소 값을 포함하고 있는지도 판단할 수 있다
    {
       Sunday =1,
       Monday =2,
       Tuesday =4,
       Wednesday =8,
       Thursday =16,
       Friday=32,
       Saturday =64,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Days workingDay = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday;
            Console.WriteLine(workingDay.HasFlag(Days.Sunday)); //sunday를 포함하고 있는지 검사

            Days today = Days.Friday;
            Console.WriteLine(workingDay.HasFlag(today));   //today를 포함하고 있는가?

            Console.WriteLine(workingDay);//62
            
        }
    }
}
